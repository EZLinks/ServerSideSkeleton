namespace MFD.Common.Api.Infrastructure.Constants
{
    /// <summary>
    /// <see cref="SecurityConstants"/> presents the security-related constant members for use everywhere in the code.
    /// </summary>
    public static class SecurityConstants
    {
        #region Static and Constants

        /// <summary>
        /// The global permissions claim key. "permissions.global": intvalue in the token.
        /// </summary>
        public const string GlobalPermissionsClaimKey = "permissions.global";

        /// <summary>
        /// The vendor identifier claim key
        /// </summary>
        public const string VendorIdClaimKey = "vendor_id";

        /// <summary>
        /// The application role type. Use this instead of ClaimTypes.Role because that type doesn't work correctly.
        /// </summary>
        public const string RoleType = "role";

        /// <summary>
        /// The cloud system scope value. e.g. scope:Cloud in the token.
        /// </summary>
        public const string CloudSystemScopeValue = "Cloud";

        /// <summary>
        /// The external system scope value. e.g. scope:External in the token.
        /// </summary>
        public const string ExternalSystemScopeValue = "External";

        /// <summary>
        /// The admin scope value. e.g. role:admin in the token.
        /// </summary>
        public const string AdminRoleValue = "admin";

        /// <summary>
        /// The user scope value. e.g. role:user in the token.
        /// </summary>
        public const string UserRoleValue = "user";

        /// <summary>
        /// The vendor scope value. This means you're an external entity, whether that's 3rd party vendor, 
        /// club external access, or another IBS application hitting a club's data.
        /// </summary>
        public const string VendorRoleValue = "vendor";

        /// <summary>
        /// The user id claim
        /// </summary>
        public const string USER_ID_CLAIM = "user_id";

        /// <summary>
        /// The pin g_ scope
        /// </summary>
        public const string PingScopeValue = "ping";

        #endregion
    }
}