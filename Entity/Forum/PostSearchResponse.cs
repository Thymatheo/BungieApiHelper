using BungieApiHelper.Entity.GroupsV2;
using BungieApiHelper.Entity.Queries;
using BungieApiHelper.Entity.Tags.Models.Contracts;
using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.Forum
{
    public class PostSearchResponse
    {
        public IEnumerable<PostResponse> relatedPosts { get; set; }
        public IEnumerable<GeneralUser> authors { get; set; }
        public IEnumerable<GroupResponse> groups { get; set; }
        public IEnumerable<TagResponse> searchedTags { get; set; }
        public IEnumerable<PollResponse> polls { get; set; }
        public IEnumerable<ForumRecruitmentDetail> recruitmentDetails { get; set; }
        public int availablePages { get; set; }
        public IEnumerable<PostResponse> results { get; set; }
        public int totalResults { get; set; }
        public bool hasMore { get; set; }
        public PagedQuery query { get; set; }
        public string replacementContinuationToken { get; set; }

        /// <summary>
        /// <para>If useTotalResults is true, then totalResults represents an accurate count.</para>
        /// <para>If False, it does not, and may be estimated/only the size of the current page.</para>
        /// <para>Either way, you should probably always only trust hasMore.</para>
        /// <para>This is a long-held historical throwback to when we used to do paging with known total results.</para>
        /// <para>Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</para>
        /// </summary>
        public bool useTotalResults { get; set; }
    }
}
