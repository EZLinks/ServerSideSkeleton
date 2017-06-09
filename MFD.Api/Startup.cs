using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using MFD.Common.Api.Filters;
using Microsoft.Extensions.Configuration;
using MFD.Common.Api.Configuration;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using MFD.Common.Api.Constants;
using MFD.Common.Api.Security.Models;
using Microsoft.AspNetCore.Mvc;
using MFD.Api.Infrastructure.Security;
using MFD.Common.Api.Security.Services;

namespace MFD.Api
{
    /// <summary> 
    /// The class called when starting up the application 
    /// </summary> 
    public partial class Startup
    {
        /// <summary> 
        /// The configuration. 
        /// </summary> 
        private readonly IConfigurationRoot _configuration;

        /// <summary> 
        /// Initializes a new instance of the <see cref="Startup"/> class. 
        /// </summary> 
        /// <param name="env"> 
        /// The env. 
        /// </param> 
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();

            AppConfig.Initialize(_configuration);
        }

        /// <summary> 
        /// Gets the configuration. 
        /// </summary> 
        public IConfigurationRoot Configuration
        {
            get
            {
                return _configuration;
            }
        }

        /// <summary> 
        /// This method gets called by the runtime. Use this method to add services to the container. 
        /// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940 
        /// </summary> 
        /// <param name="services">The </param> 
        public void ConfigureServices(IServiceCollection services)
        {
            var mvcBuilder = services.AddMvc();

            mvcBuilder.AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            mvcBuilder.AddMvcOptions(o => o.Filters.Add(new GlobalExceptionFilter(new LoggerFactory())));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "MFD API", Version = "v1" });

                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "MFD.Api.xml");
                c.IncludeXmlComments(xmlPath);
                c.AddSecurityDefinition("BearerAuth", new ApiKeyScheme
                {
                    Name = "Authorization",
                    Description = "Log in with your bearer authenticatation token",
                    In = "header",
                    Type = "apiKey"
                });
            });

            services.AddApiVersioning(o => {
                o.ReportApiVersions = true;
                o.DefaultApiVersion = ApiVersion.Parse("1.0");
                o.AssumeDefaultVersionWhenUnspecified = true;
            });

            services.Configure<JwtTokenOptions>(Configuration.GetSection("Jwt"));
            services.AddAuthorization(
                a =>
                {
                    a.AddPolicy(
                        "Bearer",
                        new AuthorizationPolicyBuilder()
                        .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                        .RequireAuthenticatedUser()
                        .RequireClaim(SecurityConstants.UserIdClaim)
                        .Build());
                }
            );

            SetupApi(services);

            services.AddSingleton(Configuration);

            services.AddCors();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline. 
        /// </summary>
        /// <param name="app">The application builder</param>
        /// <param name="env">The hosting environment.</param>
        /// <param name="loggerFactory">The logger.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IIdentityService identityService)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<JwtCookieAuthMiddleware>();

            var bearerOptions = identityService.CreateJwtBearerOptions();
            app.UseJwtBearerAuthentication(bearerOptions);

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MFD API");
            });

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials());

            app.UseMvc();
        }
    }
}