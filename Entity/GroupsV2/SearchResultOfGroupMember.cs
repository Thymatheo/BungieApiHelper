using BungieApiHelper.Entity.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.GroupsV2
{
    public class SearchResultOfGroupMember
    {
        public IEnumerable<GroupMember> results { get; set; }
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
        /// If False, it does not, and may be estimated/only the size of the current page.
        /// <para>
        /// </para>
        /// <para>
        /// Either way, you should probably always only trust hasMore.
        /// </para>
        /// </remarks>
        public bool useTotalResults { get; set; }
    }
}
