using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideSkeleton.Authentication.Models
{
    /// <summary> 
    /// The information needed to generate a token. 
    /// </summary> 
    [ExcludeFromCodeCoverage]
    public class TokenPostModel
    {
        /// <summary> 
        /// The user name used to get a token. 
        /// </summary> 
        [Required]
        [MinLength(1)]
        public string UserName { get; set; }

        /// <summary> 
        /// The password of the user attempting to get a token. 
        /// </summary> 
        [Required]
        [MinLength(1)]
        public string Password { get; set; }
    }
}