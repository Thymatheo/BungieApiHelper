using System.Net.Http;
using System.Net.Http.Headers;

namespace BungieApiHelper.Helper.Auth {
    public class BasicAuthHelper : BasicHelper {
        public BasicAuthHelper(string controllerName) : base(controllerName) { }

        protected override HttpRequestMessage BuildDefaultBungieClient(HttpMethodEnum methodes, string pathParam, string queryParam) {
            HttpRequestMessage request = base.BuildDefaultBungieClient(methodes, pathParam, queryParam);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenManager.GetTokenValue());
            return request;
        }
    }
}
