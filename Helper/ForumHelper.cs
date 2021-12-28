using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Forum;
using BungieApiHelper.Entity.Tags.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper
{
    public class ForumHelper : BasicHelper
    {
        public ForumHelper() : base("Forum") { }

        /// <summary>
        /// Get topics from any forum.
        /// </summary>
        /// <param name="categoryFilter">A category filter</param>
        /// <param name="group">The group, if any.</param>
        /// <param name="page">Zero paged page number</param>
        /// <param name="quickDate">A date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default 'en'</param>
        /// <param name="tagstring">The tags to search, if any.</param>
        public async Task<BasicResponse<PostSearchResponse>> GetTopicsPaged(int categoryFilter, int page, int quickDate, byte sort, int group = 0, int pageSize = 0, string locales = "en", string tagstring = "")
        {
            List<QueryParam> param = new List<QueryParam>()
            {
                new QueryParam(){ Label = "locales", Value = locales},
            };
            if (!string.IsNullOrWhiteSpace(tagstring)) param.Add(new QueryParam() { Label = "tagstring", Value = tagstring });
            return await Get<PostSearchResponse>($"GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}", queryParam: BuildQueryParam(param));
        }

        /// <summary>
        /// Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <param name="categoryFilter">A category filter</param>
        /// <param name="page">Zero paged page number</param>
        /// <param name="quickDate">A date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default 'en'</param>
        public async Task<BasicResponse<PostSearchResponse>> GetCoreTopicsPaged(int categoryFilter, int page, int quickDate, byte sort, string locales = "en") =>
            await Get<PostSearchResponse>($"GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}", queryParam: BuildQueryParam(new List<QueryParam>()
            {
                new QueryParam(){ Label = "locales", Value = locales},
            }));

        /// <summary>
        /// Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public async Task<BasicResponse<PostSearchResponse>> GetPostsThreadedPaged(int parentPostId, int page, int pageSize, int replySize, bool getParentPost, bool rootThreadMode, int sortMode, string showbanned = "") =>
            await Get<PostSearchResponse>($"GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}", queryParam: BuildQueryParam(new List<QueryParam>()
            {
                new QueryParam(){ Label = "showbanned", Value = showbanned},
            }));

        /// <summary>
        /// Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public async Task<BasicResponse<PostSearchResponse>> GetPostsThreadedPagedFromChild(int childPostId, int page, int pageSize, int replySize, bool rootThreadMode, int sortMode, string showbanned = "") =>
            await Get<PostSearchResponse>($"GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}", queryParam: BuildQueryParam(new List<QueryParam>()
            {
                new QueryParam(){ Label = "showbanned", Value = showbanned},
            }));

        /// <summary>
        /// Returns the post specified and its immediate parent.
        /// </summary>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public async Task<BasicResponse<PostSearchResponse>> GetPostAndParent(int childPostId, string showbanned = "") =>
            await Get<PostSearchResponse>($"GetPostAndParent/{childPostId}", queryParam: BuildQueryParam(new List<QueryParam>()
            {
                new QueryParam(){ Label = "showbanned", Value = showbanned},
            }));

        /// <summary>
        /// Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public async Task<BasicResponse<PostSearchResponse>> GetPostAndParentAwaitingApproval(int childPostId, string showbanned = "") =>
            await Get<PostSearchResponse>($"GetPostAndParentAwaitingApproval/{childPostId}", queryParam: BuildQueryParam(new List<QueryParam>()
            {
                new QueryParam(){ Label = "showbanned", Value = showbanned},
            }));

        /// <summary>
        /// Gets the post Id for the given content item's comments, if it exists.
        /// </summary>
        public async Task<BasicResponse<int>> GetTopicForContent(int contentId) =>
            await Get<int>($"GetTopicForContent/{contentId}");

        /// <summary>
        /// Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        public async Task<BasicResponse<TagResponse>> GetForumTagSuggestions(string partialtag) =>
            await Get<TagResponse>($"GetForumTagSuggestions", BuildQueryParam(new List<QueryParam>() { new QueryParam() { Label = "partialtag", Value = partialtag } }));

        /// <summary>
        /// Gets the specified forum poll.
        /// </summary>
        public async Task<BasicResponse<PostSearchResponse>> Poll(int topicId) =>
            await Get<PostSearchResponse>($"Poll/{topicId}");

        /// <summary>
        /// Allows the caller to get a list of to 25 recruitment thread summary information objects.
        /// </summary>
        public async Task<BasicResponse<ForumRecruitmentDetail>> RecruitSummaries(IEnumerable<int> content) =>
            await Post<ForumRecruitmentDetail>($"Recruit/Summaries", content);
    }
}
