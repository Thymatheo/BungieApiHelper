using BungieApiHelper.Entity.User;
using System;

namespace BungieApiHelper.Entity.Application
{
    public class ApplicationDeveloper
    {
        public int role { get; set; }
        public int apiEulaVersion { get; set; }
        public UserInfoCard user { get; set; }
    }
}