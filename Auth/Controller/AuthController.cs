using BungieApiHelper.Auth.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;

namespace BungieApiHelper.Auth.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class AuthController : ControllerBase
    {
        private readonly BungieApiHelperConfig _config;
        private readonly IAuthHelper _authHelper;

        public AuthController()
        {
            _config = Locator.Config;
            _authHelper = new AuthHelper();
        }

        /// <summary>
        /// This endpoint redirect to the bungie login page
        /// </summary>
        [HttpGet]
        public ActionResult Get()
        {
            string state = _authHelper.RandomString();
            Response.Cookies.Append("State", state);
            return Redirect(_authHelper.InitAuth(state));
        }

        /// <summary>
        /// This is the redirection url you have register in the configuration of your api on the developer portail, when you succesfuly log to your bungie account, they'll redirect on this endpoint
        /// </summary>
        /// <param name="code">code returned by bungie after the authentification process</param>
        /// <param name="state">state</param>
        /// <returns></returns>
        [HttpGet("logged")]
        public async Task<ActionResult> GetResult([FromQuery][Required] string code, [FromQuery][Required] string state)
        {
            if (Request.Cookies["State"] != state)
                return BadRequest("The state must be the same !");
            AuthResponse token = await _authHelper.GetToken(code);
            Response.Cookies.Append("Code", code);
            AddToken(token);
            if (_config.ClientType == AuthTypeEnum.Confidential)
                AddRefreshToken(token);
            return Ok(token.access_token);
        }
        [HttpGet("refresh")]
        public async Task<ActionResult> RefreshToken()
        {
            if (_config.ClientType == AuthTypeEnum.Confidential)
            {
                AuthResponse token = await _authHelper.RefreshToken(Request.Cookies["Refresh"]);
                AddToken(token);
                AddRefreshToken(token);
                return Ok();
            }
            else return BadRequest("A token can only be refresh on a confidential app !");
        }

        [HttpDelete("loggout")]
        public ActionResult Loggout()
        {
            Response.Cookies.Delete("Membership_Id");
            Response.Cookies.Delete("Refresh");
            Response.Cookies.Delete("Refresh_Expire");
            Response.Cookies.Delete("Bearer");
            Response.Cookies.Delete("Bearer_Expire");
            Response.Cookies.Delete("State");
            Response.Cookies.Delete("Code");
            return Ok();
        }

        private void AddToken(AuthResponse token)
        {
            Response.Cookies.Append(token.token_type, token.access_token);
            Response.Cookies.Append($"Bearer_Expire", DateTime.Now.AddSeconds(token.expires_in).ToString());
            Response.Cookies.Append("Membership_Id", token.membership_id);
        }

        private void AddRefreshToken(AuthResponse token)
        {
            Response.Cookies.Append("Refresh", token.refresh_token);
            Response.Cookies.Append("Refresh_Expire", DateTime.Now.AddSeconds(token.refresh_expires_in).ToString());
        }
    }
}
