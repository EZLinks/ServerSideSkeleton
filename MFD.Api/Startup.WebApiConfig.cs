using MFD.Common.Api.Infrastructure.Attributes;
using MFD.Common.Api.Infrastructure.Handlers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using ExceptionLogger = MFD.Common.Api.Infrastructure.ExceptionLogger;

namespace MFD.Api
{
    public partial class Startup
    {
        public static void RegisterWebApi(HttpConfiguration config)
        {
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.LocalOnly;

            /*
            * Routes
            */
            config.MapHttpAttributeRoutes(new InheritedControllerRouteAttributesProvider());

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            /*
            * Formatters 
            */
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/problem+json"));
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // Add custom formatters here.
            settings.NullValueHandling = NullValueHandling.Ignore;

            AddDebugTraceWriter(settings);

            /*
            * MessageHandlers
            */
            config.MessageHandlers.Add(new JsonWebTokenValidationHandler
            {
                Audience = ConfigurationManager.AppSettings["jwt:ApiAudience"],
                SymmetricKey = ConfigurationManager.AppSettings["jwt:ClientSecret"],
                Issuer = ConfigurationManager.AppSettings["jwt:Domain"]
            });

            /*
            * Filters
            */
            config.Filters.Add(new HandleApiExceptionAttribute());

            /*
            * WebApi Services
            */
            config.Services.Add(typeof(IExceptionLogger), new ExceptionLogger());
            
        }

        // This conditional attribute means this method will only get compiled when the DEBUG flag is used
        [Conditional("DEBUG")]
        internal static void AddDebugTraceWriter(JsonSerializerSettings settings)
        {
            settings.TraceWriter = new DebugJsonTraceWriter();
        }
    }
}