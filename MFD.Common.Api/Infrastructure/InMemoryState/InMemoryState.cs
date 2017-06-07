using System;
using System.Runtime.Caching;

namespace MFD.Common.Api.Infrastructure
{
    /// <summary>
    /// <see cref="InMemoryState"/>.
    /// </summary>
    public class InMemoryState : IInMemoryState
    {
        #region Static and Constants

        private const string ClubKeyFormat = "*************Add format here*************";
        private static readonly ObjectCache Cache = MemoryCache.Default;

        private const int cacheTimeOutMinutes = 30;

        #endregion

        #region IInMemoryState Members        
        
        /* Add cache getter/setters here */

        #endregion

        #region Private Methods
        
        private static string GetCacheKey(string clubId, string keyFormat)
        {
            return String.Format(keyFormat, clubId).ToUpper();
        }

        #endregion
    }
}