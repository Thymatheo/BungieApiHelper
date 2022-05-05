using BungieApiHelper.Auth.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;

namespace BungieApiHelper.Auth.Controller {
    [ApiController()]
    [Route("api/[controller]")]
    public sealed class AuthController : ControllerBase {
        private readonly BungieApiHelperConfig _config;
        private readonly IAuthHelper _authHelper;

        public AuthController() {
            _config = Locator.Config;
            _authHelper = new AuthHelper();
        }

        /// <summary>
        /// This endpoint redirect to the bungie login page
        /// </summary>
        [HttpGet]
        public ActionResult Get() {
            string state = _authHelper.RandomString();
            Response.Cookies.Append("State", state);
            return Redirect(_authHelper.InitAuth(state));
        }

        [HttpGet("UserSessionInfo")]
        public ActionResult<AuthResponse> GetAuthInfo() => Ok(new AuthResponse() {
            token_type = "Bearer",
            membership_id = Request.Cookies["Membership_Id"],
            expires_in = int.Parse(Request.Cookies["Bearer_Expire"]),
            refresh_expires_in = int.Parse(Request.Cookies["Refresh_Expire"]),
            access_token = Request.Cookies["Bearer"],
            refresh_token = Request.Cookies["Refresh"],
        });

        /// <summary>
        /// This is the redirection url you have register in the configuration of your api on the developer portail, when you succesfuly log to your bungie account, they'll redirect on this endpoint
        /// </summary>
        /// <param name="code">code returned by bungie after the authentification process</param>
        /// <param name="state">state</param>
        /// <returns></returns>
        [HttpGet("logged")]
        public async Task<ActionResult> GetResult([FromQuery][Required] string code, [FromQuery][Required] string state) {
            if (Request.Cookies["State"] != state)
                return BadRequest("The state must be the same !");
            AuthResponse token = await _authHelper.GetToken(code);
            Response.Cookies.Append("Code", code);
            AddToken(token);
            if (_config.ClientType == AuthTypeEnum.Confidential)
                AddRefreshToken(token);
            return Redirect(!_config.IsApiMode ? "https://localhost:44307/swagger" : "http://localhost:80/guardianbagpack/");
        }
        [HttpGet("refresh")]
        public async Task<ActionResult> RefreshToken() {
            if (_config.ClientType == AuthTypeEnum.Confidential) {
                string refresh = Request.Cookies["Refresh"];
                AuthResponse token = await _authHelper.RefreshToken(refresh);
                AddToken(token);
                AddRefreshToken(token);
                return Ok();
            }
            else return BadRequest("A token can only be refresh on a confidential app !");
        }

        [HttpDelete("loggout")]
        public ActionResult Loggout() {
            Response.Cookies.Delete("Membership_Id");
            Response.Cookies.Delete("Refresh");
            Response.Cookies.Delete("Refresh_Expire");
            Response.Cookies.Delete("Bearer");
            Response.Cookies.Delete("Bearer_Expire");
            Response.Cookies.Delete("State");
            Response.Cookies.Delete("Code");
            return Ok();
        }

        private void AddToken(AuthResponse token) {
            Response.Cookies.Append(token.token_type, token.access_token);
            Response.Cookies.Append("Bearer_Expire", token.expires_in.ToString());
            Response.Cookies.Append("Membership_Id", token.membership_id);
        }

        private void AddRefreshToken(AuthResponse token) {
            Response.Cookies.Append("Refresh", token.refresh_token);
            Response.Cookies.Append("Refresh_Expire", token.refresh_expires_in.ToString());
        }
    }
}
