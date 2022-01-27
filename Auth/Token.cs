using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Auth
{
    public class Token
    {
        public string Value { get; set; }
        public DateTime BearerExpire { get; set; }
        public string refresh { get; set; }
        public DateTime RefreshExpire { get; set; }
        public int MembershipId { get; set; }
    }
}
