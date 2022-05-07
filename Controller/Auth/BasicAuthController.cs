using BungieApiHelper.Helper.Auth;

namespace BungieApiHelper.Controller.Auth {
    public class BasicAuthController<T> : BasicController<T> where T : BasicAuthHelper, new() {
        protected string GetToken() =>
            HttpContext.Request.Cookies["Bearer"];
    }
}
