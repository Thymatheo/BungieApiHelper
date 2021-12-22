using BungieApiHelper.Auth;
using System;

namespace BungieApiHelper
{
    public sealed class BungieApiHelperConfig
    {
        private int? _clientId;
        private int? _stateLength;
        private string _apiKey;
        private string _apiPath;
        private string _clientSecret;
        private AuthTypeEnum? _clientType;

        public int? ClientId
        {
            get => _clientId ?? throw new NullReferenceException("Unable to find the ClientId Field in the configuration");
            set => _clientId = value;
        }
        public int? StateLength
        {
            get => _stateLength ?? throw new NullReferenceException("Unable to find the StateLength Field in the configuration");
            set => _stateLength = value;
        }

        public string? ApiKey
        {
            get => _apiKey ?? throw new NullReferenceException("Unable to find the ApiKey Field in the configuration");
            set => _apiKey = value;
        }
        public string? ApiPath
        {
            get => _apiPath ?? throw new NullReferenceException("Unable to find the Api Path Field in the configuration");
            set => _apiPath = value;
        }
        public string? ClientSecret
        {
            get => _clientSecret ?? throw new NullReferenceException("Unable to find the Client Secret Field in the configuration");
            set => _clientSecret = value;
        }
        public AuthTypeEnum ClientType
        {
            get => _clientType ?? throw new NullReferenceException("Unable to find the Client Type Field in the configuration");
            set => _clientType = value;
        }
    }

}
