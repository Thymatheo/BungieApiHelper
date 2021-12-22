using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Auth
{
    public sealed class AuthResponse
    {
        public string access_token;
        public string token_type;
        public int expires_in;
        public string refresh_token;
        public int refresh_expires_in;
        public string membership_id;
    }
}
