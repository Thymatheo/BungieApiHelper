using BungieApiHelper.Entity.Queries;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupSearchResponse {
        public IEnumerable<GroupV2Card> results { get; set; }
        public int totalResults { get; set; }
        public bool hasMore { get; set; }
        public PagedQuery query { get; set; }
        public string replacementContinuationToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>
        /// If useTotalResults is true, then totalResults represents an accurate count.
        /// </para>
        /// <para>
        /// If False, it does not, and may be estimated/only the size of the current page.
        /// </para>
        /// <para>
        /// Either way, you should probably always only trust hasMore.
        /// </para>
        /// <para>
        /// This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.
        /// </para>
        /// </remarks>
        public bool useTotalResults { get; set; }
    }
}
