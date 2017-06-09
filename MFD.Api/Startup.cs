using IBS.Logging;
using MFD.Api;
using Microsoft.Owin;
using Owin;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace MFD.Api
{
    [ExcludeFromCodeCoverage]
    public partial class Startup
    {
        [ExcludeFromCodeCoverage]
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();

            /*
            * Logging configuration
            * WARN : do not move this line so logger could be inited first
            */
            LogManager.Initialize(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config"));

            RegisterCors(app);
            //RegisterAuth(app);
        }
    }
}