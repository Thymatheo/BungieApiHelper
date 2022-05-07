using BungieApiHelper.Entity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper {
    public abstract class BasicHelper {
        protected readonly string ControllerName;
        public BungieApiHelperConfig _config;

        protected BasicHelper(string controllerName) {
            ControllerName = controllerName;
            _config = Locator.Config;
        }

        protected async Task<BasicResponse<T>> Get<T>(string pathParam, string queryParam = "") =>
            await ReadRequestResult<T>(BuildRequestMessage(HttpMethodEnum.GET, pathParam, queryParam));

        protected async Task<BasicResponse<T>> Post<T>(string pathParam, object content, string queryParam = "") =>
            await ReadRequestResult<T>(BuildBody(BuildRequestMessage(HttpMethodEnum.POST, pathParam, queryParam), content));

        private string BuildPath(string pathParam, string queryParam) =>
            $"{_config.ApiPath}/{ControllerName}{(!string.IsNullOrEmpty(pathParam) ? $"/{pathParam}" : "")}/{(!string.IsNullOrEmpty(queryParam) ? $"?{queryParam}" : "")}";

        protected virtual HttpRequestMessage BuildDefaultBungieClient(HttpMethodEnum methodes, string pathParam, string queryParam) {
            HttpRequestMessage request = new(new(methodes.ToString()), BuildPath(pathParam, queryParam));
            request.Headers.Add("X-Api-Key", _config.ApiKey);
            return request;
        }

        private HttpRequestMessage BuildRequestMessage(HttpMethodEnum methodes, string pathParam = null, string queryParam = null) =>
            BuildDefaultBungieClient(methodes, pathParam, queryParam);

        private HttpRequestMessage BuildBody(HttpRequestMessage request, object content) {
            request.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return request;
        }
        private async Task<BasicResponse<T>> ReadRequestResult<T>(HttpRequestMessage request) {
            using HttpResponseMessage response = await GetClient().SendAsync(request);
            return JsonConvert.DeserializeObject<BasicResponse<T>>(await response.Content.ReadAsStringAsync(), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore, MaxDepth = null });
        }
        private HttpClient GetClient() {
            HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json") { CharSet = "UTF-8" });
            return client;
        }
        public static string BuildQueryParam(List<QueryParam> param) =>
            string.Join('&', param.Select(x => x.ToString()));
    }
}

