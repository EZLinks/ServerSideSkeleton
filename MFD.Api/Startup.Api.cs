using Microsoft.Extensions.DependencyInjection;
using MFD.Common.Api.Security.Services;

namespace MFD.Api
{
    public partial class Startup
    {
		public static void SetupApi(IServiceCollection services)
        {
            services.AddTransient<IIdentityService, IdentityService>();
        }
    }
}
