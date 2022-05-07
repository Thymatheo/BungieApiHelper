using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Application;
using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller {
    [ApiExplorerSettings(IgnoreApi = false)]
    public class AppController : BasicController<AppHelper> {
        /// <summary>
        /// Get API usage by application for time frame specified.
        /// </summary>
        /// <remarks>You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.</remarks>
        /// <param name="appId">ID of the application to get usage statistics.</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified.</param>
        /// <param name="end">End time for query. Goes to now if not specified.</param>
        [HttpGet("ApiUsage/{appId}")]
        public async Task<ActionResult<BasicResponse<ApiUsage>>> GetApplicationApiUsage([FromRoute] int appId, [FromQuery] DateTime? start = null, [FromQuery] DateTime? end = null) {
            return Ok(await _helper.GetApplicationApiUsage(appId, start, end));
        }
        /// <summary>
        /// Get list of applications created by Bungie.
        /// </summary>
        [HttpGet("FirstParty")]
        public async Task<ActionResult<BasicResponse<IEnumerable<Application>>>> GetBungieApplication() {
            return Ok(await _helper.GetBungieApplication());
        }
    }
}
