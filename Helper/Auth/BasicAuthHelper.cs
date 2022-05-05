using BungieApiHelper.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BungieApiHelper.Helper.Auth
{
    public class BasicAuthHelper : BasicHelper
    {
        public BasicAuthHelper(string controllerName) : base(controllerName) { }

        protected override HttpRequestMessage BuildDefaultBungieClient(HttpMethodEnum methodes, string pathParam, string queryParam)
        {
            HttpRequestMessage request = base.BuildDefaultBungieClient(methodes, pathParam, queryParam);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenManager.GetTokenValue());
            return request;
        }
    }
}
