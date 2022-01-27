using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Config;
using BungieApiHelper.Entity.GroupsV2;
using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller
{
    [ApiExplorerSettings(IgnoreApi = false)]
    public class GroupV2Controller : BasicController<GroupV2Helper>
    {
        /// <summary>
        /// Returns a list of all available group avatars for the signed-in user.
        /// </summary>
        [HttpGet("GetAvailableAvatars")]
        public async Task<ActionResult<BasicResponse<Dictionary<int, string>>>> GetAvailableAvatars()
        {
            return Ok(await _helper.GetAvailableAvatars());
        }

        /// <summary>
        /// Returns a list of all available group themes.
        /// </summary>
        [HttpGet("GetAvailableThemes")]
        public async Task<ActionResult<BasicResponse<IEnumerable<GroupTheme>>>> GetAvailableThemes()
        {
            return Ok(await _helper.GetAvailableThemes());
        }

        /// <summary>
        /// Search for Groups.
        /// </summary>
        [HttpPost("Search")]
        public async Task<ActionResult<BasicResponse<GroupResponse>>> Search([FromBody] GroupQuery content)
        {
            return Ok(await _helper.Search(content));
        }

        /// <summary>
        /// Get information about a specific group of the given ID.
        /// </summary>
        [HttpGet("{groupId}")]
        public async Task<ActionResult<BasicResponse<GroupResponse>>> Get([FromRoute] int groupId)
        {
            return Ok(await _helper.Get(groupId));
        }

        /// <summary>
        /// Get information about a specific group of the given ID.
        /// </summary>
        [HttpGet("Name/{groupName}/{groupType}")]
        public async Task<ActionResult<BasicResponse<GroupResponse>>> Name([FromRoute]string groupName,[FromRoute] int groupType)
        {
            return Ok(await _helper.Name(groupName, groupType));
        }

        /// <summary>
        /// Get information about a specific group with the given name and type. The POST version.
        /// </summary>
        [HttpPost("NameV2")]
        public async Task<ActionResult<BasicResponse<GroupResponse>>> NameV2([FromBody] GroupNameSearchRequest content)
        {
            return Ok(await _helper.NameV2(content));
        }

        /// <summary>
        /// Gets a list of available optional conversation channels and their settings.
        /// </summary>
        /// <param name="groupId">Requested group's id.</param>
        [HttpGet("{groupId}/OptionalConversations")]
        public async Task<ActionResult<BasicResponse<IEnumerable<GroupOptionalConversation>>>> OptionalConversations([FromRoute] int groupId)
        {
            return Ok(await _helper.OptionalConversations(groupId));
        }

        /// <summary>
        /// Get the list of members in a given group.
        /// </summary>
        /// <param name="groupId">The ID of the group.</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="memberType">Filter out other member types. Use None for all members.</param>
        /// <param name="nameSearch">The name fragment upon which a search should be executed for members with matching display or unique names.</param>
        [HttpGet("{groupId}/Members/{currentpage}")]
        public async Task<ActionResult<BasicResponse<IEnumerable<GroupOptionalConversation>>>> OptionalConversations([FromRoute] int groupId, [FromRoute] int currentpage, [FromQuery] int memberType, [FromQuery] string nameSearch)
        {
            return Ok(await _helper.Members(groupId, currentpage, memberType, nameSearch));
        }


        /// <summary>
        /// Get the list of members in a given group who are of admin level or higher.
        /// </summary>
        /// <param name="groupId">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="currentpage">The ID of the group.</param>
        [HttpGet("{groupId}/AdminsAndFounder/{currentpage}")]
        public async Task<ActionResult<BasicResponse<IEnumerable<GroupOptionalConversation>>>> AdminsAndFounder([FromRoute] int groupId, [FromRoute] int currentpage)
        {
            return Ok(await _helper.AdminsAndFounder(groupId, currentpage));
        }
    }
}
