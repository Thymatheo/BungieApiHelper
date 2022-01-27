﻿using BungieApiHelper.Helper.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Controller.Auth
{
    public class BasicAuthController<T> : BasicController<T> where T : BasicAuthHelper, new()
    {
        protected string GetToken() =>
            HttpContext.Request.Cookies["Bearer"];
    }
}
