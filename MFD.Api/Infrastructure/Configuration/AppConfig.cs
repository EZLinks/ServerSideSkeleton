using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace MFD.Common.Api.Configuration
{
    [ExcludeFromCodeCoverage]
    public static class AppConfig
    {
        #region Init 

        /// <summary> 
        /// The configuration. 
        /// </summary> 
        private static IConfiguration _configuration;

        /// <summary> 
        /// The initialize. 
        /// </summary> 
        /// <param name="configuration"> 
        /// The configuration. 
        /// </param> 
        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #endregion

        #region Properties 

        #endregion
    }
}