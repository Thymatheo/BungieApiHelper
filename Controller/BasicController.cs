using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [Exception]
    public class BasicController<T> : ControllerBase where T : BasicHelper, new()
    {
        protected readonly T _helper;

        public BasicController()
        {
            _helper = new T();
        }
    }
}
