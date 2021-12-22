using BungieApiHelper.Entity.Ignores;
using System;

namespace BungieApiHelper.Entity.User
{
    public class UserToUserContext
    {
        public bool isFollowing { get; set; }
        public IgnoreResponse ignoreStatus { get; set; }
        public DateTime? globalIgnoreEndDate { get; set; }
    }
}