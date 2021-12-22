using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Content;
using BungieApiHelper.Entity.Content.Models;
using BungieApiHelper.Entity.Unspecified;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper
{
    public class ContentHelper : BasicHelper
    {
        public ContentHelper() : base("Content") { }
        /// <summary>
        /// Gets an object describing a particular variant of content.
        /// </summary>
        /// <param name="type">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        public async Task<BasicResponse<ContentTypeDescription>> GetContentType(string type) =>
            await Get<ContentTypeDescription>($"GetContentType/{type}");

        /// <summary>
        /// Returns a content item referenced by id
        /// </summary>
        public async Task<BasicResponse<ContentItemPublicContract>> GetContentById(int id, string locale, bool head = false) =>
            await Get<ContentItemPublicContract>($"GetContentById/{id}/{locale}", queryParam: BuildQueryParam(new List<QueryParam>() { new QueryParam() { Label = "head", Value = head } }));

        /// <summary>
        /// Returns the newest item that matches a given tag and Content Type.
        /// </summary>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <param name="type">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        public async Task<BasicResponse<ContentItemPublicContract>> GetContentByTagAndType(string tag, string type, string locale, bool head = false) =>
            await Get<ContentItemPublicContract>($"GetContentByTagAndType/{tag}/{type}/{locale}", queryParam: BuildQueryParam(new List<QueryParam>() { new QueryParam() { Label = "head", Value = head } }));

        /// <summary>
        /// Gets content based on querystring information passed in. Provides basic search and text search capabilities.
        /// </summary>
        /// <param name="cType">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        /// <param name="searchtext">Word or phrase for the search.</param>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <param name="currentPage">Page number for the search results, starting with page 1.</param>
        /// <param name="source">For analytics, hint at the part of the app that triggered the search. Optional.</param>
        /// <param name="head"></param>
        public async Task<BasicResponse<SearchResultOfContentItemPublicContract>> Search(string locale, string cType, string searchtext, string tag, int currentPage = 1, string source = "", bool head = false)
        {
            List<QueryParam> param = new List<QueryParam>() {
                new QueryParam(){ Label = "cType", Value = cType },
                new QueryParam(){ Label = "searchtext", Value = searchtext },
                new QueryParam(){ Label = "tag", Value = tag },
                new QueryParam(){ Label = "head", Value = head  },
                new QueryParam(){ Label = "currentPage", Value = currentPage  },
            };
            if (!string.IsNullOrWhiteSpace(source))
                param.Add(new QueryParam() { Label = "source", Value = source });

            return await Get<SearchResultOfContentItemPublicContract>($"Search/{locale}", queryParam: BuildQueryParam(param));
        }

        /// <summary>
        /// Searches for Content Items that match the given Tag and Content Type.
        /// </summary>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <param name="type">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        /// <param name="itemsperpage">Not used.</param>
        /// <param name="currentPage">Page number for the search results starting with page 1.</param>
        /// <param name="head">Not used.</param>
        public async Task<BasicResponse<SearchResultOfContentItemPublicContract>> SearchContentByTagAndType(string tag, string type, string locale, int itemsperpage, int currentPage = 1, bool head = false) =>
            await Get<SearchResultOfContentItemPublicContract>($"SearchContentByTagAndType/{tag}/{type}/{locale}", queryParam: BuildQueryParam(new List<QueryParam>() {
                new QueryParam(){ Label = "currentPage", Value = currentPage  },
                new QueryParam(){ Label = "head", Value = head  },
                new QueryParam(){ Label = "itemsperpage", Value = itemsperpage  }
            }));

        /// <summary>
        /// Search for Help Articles.
        /// </summary>
        /// <param name="searchtext">Word or phrase for the search.</param>
        public async Task<BasicResponse<object>> SearchHelpArticles(string searchtext, int size) =>
            await Get<object>($"SearchHelpArticles/{searchtext}/{size}");
    }
}
