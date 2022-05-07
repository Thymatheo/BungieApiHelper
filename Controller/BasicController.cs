using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BungieApiHelper.Controller {
    [ApiController]
    [Route("api/[controller]")]
    [Exception]
    public class BasicController<T> : ControllerBase where T : BasicHelper, new() {
        protected readonly T _helper;

        public BasicController() {
            _helper = new T();
        }
    }
}
