﻿
using BungieApiHelper.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace BungieApiHelper
{
    public class ExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";
            context.Result = new ContentResult
            {
                Content = JsonConvert.SerializeObject(JsonConvert.DeserializeObject<BasicResponse<object>>(context.Exception.Message), Formatting.Indented),
                ContentType = "application/json",
                StatusCode = (int)500
            };
            base.OnException(context);
        }
    }
}