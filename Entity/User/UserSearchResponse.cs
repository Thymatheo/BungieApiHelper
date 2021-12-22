using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.User
{
    public class UserSearchResponse
    {
        public IEnumerable<UserSearchResponseDetail> searchResults { get; set; }
        public int page { get; set; }
        public bool hasMore { get; set; }
    }
}
