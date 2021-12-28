using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Forum;
using BungieApiHelper.Entity.Tags.Models.Contracts;
using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller
{
    public class ForumController : BasicController<ForumHelper>
    {
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
        [HttpGet("GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> GetTopicsPaged([FromRoute] int categoryFilter, [FromRoute] int page, [FromRoute] int quickDate, [FromRoute] byte sort, [FromRoute] int group = 0, [FromRoute] int pageSize = 0, [FromQuery] string locales = "en", [FromQuery] string tagstring = "")
        {
            return Ok(await _helper.GetTopicsPaged(categoryFilter, page, pageSize, sort, group, pageSize, locales, tagstring));
        }

        /// <summary>
        /// Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <param name="categoryFilter">A category filter</param>
        /// <param name="page">Zero paged page number</param>
        /// <param name="quickDate">A date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default 'en'</param>
        [HttpGet("GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> GetCoreTopicsPaged([FromRoute] int categoryFilter, [FromRoute] int page, [FromRoute] int quickDate, [FromRoute] byte sort, [FromQuery] string locales = "en")
        {
            return Ok(await _helper.GetCoreTopicsPaged(categoryFilter, page, quickDate, sort, locales));
        }

        /// <summary>
        /// Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        [HttpGet("GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> GetPostsThreadedPaged([FromRoute] int parentPostId, [FromRoute] int page, [FromRoute] int pageSize, [FromRoute] int replySize, [FromRoute] bool getParentPost, [FromRoute] bool rootThreadMode, [FromRoute] int sortMode, [FromQuery] string showbanned = "")
        {
            return Ok(await _helper.GetPostsThreadedPaged(parentPostId, page, pageSize, replySize, getParentPost, rootThreadMode, sortMode, showbanned));
        }

        /// <summary>
        /// Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        [HttpGet("GetPostsThreadedPagedFromChild/{parentPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> GetPostsThreadedPagedFromChild([FromRoute] int parentPostId, [FromRoute] int page, [FromRoute] int pageSize, [FromRoute] int replySize, [FromRoute] bool rootThreadMode, [FromRoute] int sortMode, [FromQuery] string showbanned = "")
        {
            return Ok(await _helper.GetPostsThreadedPagedFromChild(parentPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned));
        }

        /// <summary>
        /// Returns the post specified and its immediate parent.
        /// </summary>
        [HttpGet("GetPostAndParent/{childPostId}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> GetPostAndParent([FromRoute] int childPostId, [FromQuery] string showbanned = "")
        {
            return Ok(await _helper.GetPostAndParent(childPostId, showbanned));
        }

        /// <summary>
        /// Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        [HttpGet("GetPostAndParentAwaitingApproval/{childPostId}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> GetPostAndParentAwaitingApproval([FromRoute] int childPostId, [FromQuery] string showbanned = "")
        {
            return Ok(await _helper.GetPostAndParentAwaitingApproval(childPostId, showbanned));
        }

        /// <summary>
        /// Gets the post Id for the given content item's comments, if it exists.
        /// </summary>        
        [HttpGet("GetTopicForContent/{contentId}")]
        public async Task<ActionResult<BasicResponse<int>>> GetTopicForContent([FromRoute] int contentId)
        {
            return Ok(await _helper.GetTopicForContent(contentId));
        }

        /// <summary>
        /// Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        [HttpGet("GetForumTagSuggestions")]
        public async Task<ActionResult<BasicResponse<TagResponse>>> GetForumTagSuggestions([FromQuery] string partialtag)
        {
            return Ok(await _helper.GetForumTagSuggestions(partialtag));
        }

        /// <summary>
        /// Gets the specified forum poll.
        /// </summary>
        [HttpGet("Poll/{topicId}")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> Poll([FromQuery] int topicId)
        {
            return Ok(await _helper.Poll(topicId));
        }


        /// <summary>
        /// Allows the caller to get a list of to 25 recruitment thread summary information objects.
        /// </summary>
        [HttpGet("Recruit/Summaries")]
        public async Task<ActionResult<BasicResponse<PostSearchResponse>>> RecruitSummaries([FromBody] IEnumerable<int> content)
        {
            return Ok(await _helper.RecruitSummaries(content));
        }
    }
}
