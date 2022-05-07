using BungieApiHelper.Auth;
using System.Net;
using System.Threading.Tasks;

namespace BungieApiHelper {
    public class TokenRetreiver {
        private HttpListener Listener;
        public TokenRetreiver() {
            Listener = new HttpListener() {
                Prefixes = { "http://localhost:80/guardianbagpack/" }
            ,

            };
        }
        public async Task WaitLogin() {

            Listener.Start();
            var context = (await Listener.GetContextAsync());
            CookieCollection cookies = context.Request.Cookies;
            HttpListenerResponse response = context.Response;
            TokenManager.State = cookies["State"].Value;
            TokenManager.Code = cookies["Code"].Value;
            TokenManager.Token = new AuthResponse() {
                access_token = System.Web.HttpUtility.UrlDecode(cookies["Bearer"].Value),
                expires_in = int.Parse(System.Web.HttpUtility.UrlDecode(cookies["Bearer_Expire"].Value)),
                refresh_expires_in = int.Parse(System.Web.HttpUtility.UrlDecode(cookies["Refresh_Expire"].Value)),
                membership_id = System.Web.HttpUtility.UrlDecode(cookies["Membership_Id"].Value),
                token_type = "Bearer",
                refresh_token = System.Web.HttpUtility.UrlDecode(cookies["Refresh"].Value),
            };

            string responseString = "<HTML><BODY>Connection Successfull you can close this window and s</BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            // Get a response stream and write the response to it.
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            // You must close the output stream.
            output.Close();
            Listener.Stop();
            Listener.Close();
        }
    }
}
