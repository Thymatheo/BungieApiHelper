using System.Collections.Generic;

namespace BungieApiHelper.Entity.Application {
    public class ApiUsage {
        /// <summary>
        /// Counts for on API calls made for the time range.
        /// </summary>
        public IEnumerable<Series> apiCalls { get; set; }
        /// <summary>
        /// Instances of blocked requests or requests that crossed the warn threshold during the time range.
        /// </summary>
        public IEnumerable<Series> throttledRequests { get; set; }
    }
}
