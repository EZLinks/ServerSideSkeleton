using System;

namespace MFD.Domain.Models
{
    /// <summary>
    /// A user
    /// </summary>
    public class User
    {
        /// <summary>
        /// The id of the user.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Email { get; set; }
    }
}
