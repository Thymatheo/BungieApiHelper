using BungieApiHelper.Entity.User;

namespace BungieApiHelper.Entity.Responses {
    public class DestinyErrorProfile {
        /// <summary>
        /// The error that we encountered. You should be able to look up localized text to show to the user for these failures.
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// Basic info about the account that failed. Don't expect anything other than membership ID, Membership Type, and displayName to be populated.
        /// </summary>
        public UserInfoCard infoCard { get; set; }
    }
}
