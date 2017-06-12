using IBS.Cloud.Common.Web.Mvc.Core.Attributes;
using IBS.Cloud.Common.Web.Mvc.Core.Results;
using MFD.Api.Resources;
using MFD.Common.Api.Exceptions;
using MFD.Common.Api.Security.Services;
using MFD.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLog;
using ServerSideSkeleton.Authentication.Models;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading.Tasks;

namespace MFD.Authentication.Controllers
{
    /// <summary> 
    /// The token controller 
    /// </summary> 
    [ApiVersion("1.0")]
    [Route("api/token")]
    public class TokenController : Controller
    {
        /// <summary> 
        /// The default constructor. 
        /// </summary> 
        /// <param name="identityService"></param> 
        public TokenController(IIdentityService identityService)
        {
            IdentityService = identityService;
        }

        /// <summary> 
        /// The identity service. 
        /// </summary> 
        protected IIdentityService IdentityService { get; }

        /// <summary> 
        /// The logger. 
        /// </summary> 
        [ExcludeFromCodeCoverage]
        protected Logger Logger => LogManager.GetCurrentClassLogger();

        /// <summary> 
        /// Logs the user into the system 
        /// </summary> 
        /// <param name="model">The information needed to create a token.</param> 
        /// <returns> 
        /// A user object with . 
        /// </returns> 
        [HttpPost]
        [ModelValidation]
        public virtual async Task<IActionResult> Post([FromBody]TokenPostModel model)
        {
            User user;

            try
            {
                // Replace with get user call.
                user = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "some@email.com"
                };
            }
            catch (AuthorizationException)
            {
                return new ProblemResult
                {
                    Detail = ResponseMessages.LoginError,
                    Status = HttpStatusCode.BadRequest,
                };
            }

            var token = IdentityService.CreateToken(user);

            var viewModel = new TokenPostReturnModel
            {
                Token = token,
            };

            return Ok(viewModel);
        }
    }
}