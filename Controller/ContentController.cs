using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Content.Models;
using BungieApiHelper.Entity.Unspecified;
using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller
{
    public class ContentController : BasicController<ContentHelper>
    {
        /// <summary>
        /// Gets an object describing a particular variant of content.
        /// </summary>
        /// <param name="type">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        [HttpGet("GetContentType/{type}")]
        public async Task<ActionResult<BasicResponse<ContentTypeDescription>>> GetContentType([FromRoute] string type)
        {
            return Ok(await _helper.GetContentType(type));
        }

        /// <summary>
        /// Gets an object describing a particular variant of content.
        /// </summary>
        [HttpGet("GetContentById/{id}/{locale}")]
        public async Task<ActionResult<BasicResponse<ContentTypeDescription>>> GetContentById([FromRoute] int id, [FromRoute] string locale, [FromQuery] bool head = false)
        {
            return Ok(await _helper.GetContentById(id, locale, head));
        }

        /// <summary>
        /// Returns the newest item that matches a given tag and Content Type.
        /// </summary>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <param name="type">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        [HttpGet("GetContentByTagAndType/{tag}/{type}/{locale}")]
        public async Task<ActionResult<BasicResponse<ContentTypeDescription>>> GetContentByTagAndType([FromRoute] string tag, [FromRoute] string type, [FromRoute] string locale, [FromQuery] bool head = false)
        {
            return Ok(await _helper.GetContentByTagAndType(tag, type, locale, head));
        }

        /// <summary>
        /// Gets content based on querystring information passed in. Provides basic search and text search capabilities.
        /// </summary>
        /// <param name="cType">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        /// <param name="searchtext">Word or phrase for the search.</param>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <param name="currentPage">Page number for the search results, starting with page 1.</param>
        /// <param name="source">For analytics, hint at the part of the app that triggered the search. Optional.</param>
        /// <param name="head"></param>
        [HttpGet("Search/{locale}")]
        public async Task<ActionResult<BasicResponse<SearchResultOfContentItemPublicContract>>> Search([FromRoute] string locale, [FromQuery] string cType, [FromQuery] string searchtext, [FromQuery] string tag, [FromQuery] int currentPage = 1, [FromQuery] string source = "", [FromQuery] bool head = false)
        {
            return Ok(await _helper.Search(locale, cType, searchtext, tag, currentPage, source, head));
        }

        /// <summary>
        /// Searches for Content Items that match the given Tag and Content Type.
        /// </summary>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <param name="type">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        /// <param name="itemsperpage">Not used.</param>
        /// <param name="currentPage">Page number for the search results starting with page 1.</param>
        /// <param name="head">Not used.</param>
        [HttpGet("SearchContentByTagAndType/{tag}/{type}/{locale}")]
        public async Task<ActionResult<BasicResponse<SearchResultOfContentItemPublicContract>>> SearchContentByTagAndType([FromRoute] string tag, [FromRoute] string type, [FromRoute] string local,[FromQuery]int itemsperpage, [FromQuery] int currentPage = 1, [FromQuery] bool head = false)
        {
            return Ok(await _helper.SearchContentByTagAndType(tag, type, local, itemsperpage, currentPage, head));
        }

        /// <summary>
        /// Search for Help Articles.
        /// </summary>
        /// <param name="searchtext">Word or phrase for the search.</param>
        [HttpGet("SearchHelpArticles/{searchtext}/{size}")]
        public async Task<ActionResult<BasicResponse<SearchResultOfContentItemPublicContract>>> SearchHelpArticles([FromRoute] string searchtext, [FromRoute] int size)
        {
            return Ok(await _helper.SearchHelpArticles(searchtext, size));
        }
    }
}
