using BungieApiHelper.Auth.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Auth
{
    public class AuthHelper : IAuthHelper
    {
        private readonly BungieApiHelperConfig _config;

        public AuthHelper()
        {
            _config = Locator.Config;
        }

        public string InitAuth(string state) =>
            $"https://www.bungie.net/en/oauth/authorize?client_id={_config.ClientId}&response_type=code&state={state}";
        public async Task<AuthResponse> GetToken(string code) =>
            await ExecuteRequest(BuildRequest(new Dictionary<string, string>()
            {
                ["client_id"] = _config.ClientId.ToString(),
                ["grant_type"] = "authorization_code",
                ["code"] = code
            }));

        public async Task<AuthResponse> RefreshToken(string refreshToken) =>
            await ExecuteRequest(BuildRequest(new Dictionary<string, string>()
            {
                ["client_id"] = _config.ClientId.ToString(),
                ["grant_type"] = "refresh_token",
                ["refresh_token"] = refreshToken
            }));
        private async Task<AuthResponse> ExecuteRequest(HttpRequestMessage request)
        {
            using HttpResponseMessage response = (await new HttpClient().SendAsync(request));
            return JsonConvert.DeserializeObject<AuthResponse>(await response.EnsureSuccessStatusCode().Content.ReadAsStringAsync());
        }

        private HttpRequestMessage BuildRequest(Dictionary<string, string> content)
        {
            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(HttpMethodEnum.POST.ToString()), "https://www.bungie.net/platform/app/oauth/token/");
            if (_config.ClientType == AuthTypeEnum.Confidential)
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String($"{_config.ClientId}:{_config.ClientSecret}".Select(x => (byte)x).ToArray()));
            request.Content = new FormUrlEncodedContent(content);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            return request;
        }

        public string RandomString()
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            int length = (int)_config.StateLength;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];
                while (--length > 0)
                {
                    rng.GetBytes(uintBuffer);
                    res.Append(valid[(int)(BitConverter.ToUInt32(uintBuffer, 0) % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }
    }
}
