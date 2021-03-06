using System;

namespace BungieApiHelper.Entity.User {
    public class GeneralUser {
        public int membershipId { get; set; }
        public string uniqueName { get; set; }
        public string normalizedName { get; set; }
        public string displayName { get; set; }
        public string profilePicture { get; set; }
        public int profileTheme { get; set; }
        public int userTitle { get; set; }
        public int successMessageFlags { get; set; }
        public bool isDeleted { get; set; }
        public string about { get; set; }
        public DateTime firstAccess { get; set; }
        public DateTime? lastUpdate { get; set; }
        public int? legacyPortalUID { get; set; }
        public UserToUserContext context { get; set; }
        public string psnDisplayName { get; set; }
        public string xboxDisplayName { get; set; }
        public string fbDisplayName { get; set; }
        public bool? showActivity { get; set; }
        public string local { get; set; }
        public bool localeInheritDefault { get; set; }
        public int? lastBanReportId { get; set; }
        public bool showGroupMessaging { get; set; }
        public string profilePicturePath { get; set; }
        public string profilePictureWidePath { get; set; }
        public string profileThemeName { get; set; }
        public string userTitleDisplay { get; set; }
        public string statusText { get; set; }
        public string statusDate { get; set; }
        public DateTime? profileBanExpire { get; set; }
        public string blizzardDisplayName { get; set; }
        public string steamDisplayName { get; set; }
        public string stadiaDisplayName { get; set; }
        public string twitchDisplayName { get; set; }
        public string cachedBungieGlobalDisplayName { get; set; }
        public int? cachedBungieGlobalDisplayNameCode { get; set; }
    }
}
