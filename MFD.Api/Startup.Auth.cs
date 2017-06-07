using MFD.Api.Infrastructure.Configuration;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System.Configuration;

namespace MFD.Api
{
    public partial class Startup
	{
        public void RegisterAuth(IAppBuilder app)
        {
            // see https://auth0.com/docs/server-apis/webapi-owin
            var issuer = ConfigurationManager.AppSettings["jwt:Domain"];
            string audience = ConfigurationManager.AppSettings["jwt:ApiAudience"];
            string symmetricKeyAsBase64 = ConfigurationManager.AppSettings["jwt:ClientSecret"];

            var format = new JwtTokenOptions
            {
                Issuer = issuer,
                Audience = audience,
                Base64Secret = symmetricKeyAsBase64
            };

            // see http://odetocode.com/blogs/scott/archive/2015/01/15/using-json-web-tokens-with-katana-and-webapi.aspx
            var authorizationOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = format.GetTokenExpiredTime(),
                AccessTokenFormat = format,

            };

#if DEBUG
            authorizationOptions.AllowInsecureHttp = true;
#endif
            app.UseOAuthAuthorizationServer(authorizationOptions);

            // This handles consumption of the generated tokens
            // Api controllers with an [Authorize] attribute will be validated with JWT
            app.UseJwtBearerAuthentication(
                new JwtBearerAuthenticationOptions
                {
                    AuthenticationMode = AuthenticationMode.Active,
                    AllowedAudiences = new[]
                    {
                        audience
                    },
                    IssuerSecurityTokenProviders = new IIssuerSecurityTokenProvider[]
                    {
                        new SymmetricKeyIssuerSecurityTokenProvider(issuer, TextEncodings.Base64Url.Decode(symmetricKeyAsBase64))
                    }
                }
            );
        }
    }
}