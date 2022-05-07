using BungieApiHelper.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BungieApiHelper {
    public static class TokenManager {
        public static string State { get; set; }
        public static string Code { get; set; }
        public static AuthResponse Token { get; set; }

        public static string GetTokenValue() {
            return Locator.Config.IsApiMode ? Locator.Provider.GetRequiredService<IHttpContextAccessor>().HttpContext.Request.Cookies["Bearer"] : Token.access_token ?? throw new Exception("You must set the oauth token by loggin into your bungie account");
        }
    }
}