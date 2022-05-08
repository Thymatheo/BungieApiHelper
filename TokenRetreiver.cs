using BungieApiHelper.Auth;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.IO;

namespace BungieApiHelper {
    public class TokenRetreiver {
        private readonly HttpListener _listener;
        public TokenRetreiver() {
            _listener = new HttpListener() {
                Prefixes = { Locator.Config.AppRedirectUrl }
            };
        }
        public async Task WaitLogin() {
            _listener.Start();
            var context = (await _listener.GetContextAsync());
            CookieCollection cookies = context.Request.Cookies;
            HttpListenerResponse response = context.Response;
            TokenManager.State = cookies["State"].Value;
            TokenManager.Code = cookies["Code"].Value;
            TokenManager.Token = new AuthResponse() {
                access_token = HttpUtility.UrlDecode(cookies["Bearer"].Value),
                expires_in = int.Parse(HttpUtility.UrlDecode(cookies["Bearer_Expire"].Value)),
                refresh_expires_in = int.Parse(.HttpUtility.UrlDecode(cookies["Refresh_Expire"].Value)),
                membership_id = HttpUtility.UrlDecode(cookies["Membership_Id"].Value),
                token_type = "Bearer",
                refresh_token = HttpUtility.UrlDecode(cookies["Refresh"].Value),
            };
            string responseString = "<HTML><BODY>Connection Successfull you can close this window and return to the app</BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
            _listener.Stop();
            _listener.Close();
        }
    }
}
