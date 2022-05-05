using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Auth {
    public sealed class AuthResponse {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; } = 3600;
        public string refresh_token { get; set; }
        public int refresh_expires_in { get; set; }
        public string membership_id { get; set; }
    }
}
