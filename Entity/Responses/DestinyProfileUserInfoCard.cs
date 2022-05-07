using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Components;
using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Responses {
    public class DestinyProfileUserInfoCard {
        public DateTime dateLastPlayed { get; set; }
        /// <summary>
        /// If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.
        /// </summary>
        public bool isOverridden { get; set; }
        /// <summary>
        /// If true, this account is hooked up as the "Primary" cross save account for one or more platforms.
        /// </summary>
        public bool isCrossSavePrimary { get; set; }
        /// <summary>
        /// This is the silver available on this Profile across any platforms on which they have purchased silver.
        /// </summary>
        /// <remarks>
        /// This is only available if you are requesting yourself.
        /// </remarks>
        public DestinyPlatformSilverComponent platformSilver { get; set; }
        /// <summary>
        /// If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.
        /// </summary>
        public BungieUnpairedGameVersions? unpairedGameVersions { get; set; }
        /// <summary>
        /// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
        /// </summary>
        public string? supplementalDisplayName { get; set; }
        /// <summary>
        /// URL the Icon if available.
        /// </summary>
        public string? iconPath { get; set; }
        /// <summary>
        /// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
        /// </summary>
        public int? crossSaveOverride { get; set; }
        /// <summary>
        /// The list of Membership Types indicating the platforms on which this Membership can be used.
        /// </summary>
        public IEnumerable<BungieMembershipType>? applicableMembershipTypes { get; set; }
        /// <summary>
        /// If True, this is a public user membership.
        /// </summary>
        public bool? isPublic { get; set; }
        /// <summary>
        /// Type of the membership. Not necessarily the native type.
        /// </summary>
        public BungieMembershipType? membershipType { get; set; }
        /// <summary>
        /// Membership ID as they user is known in the Accounts service
        /// </summary>
        public string membershipId { get; set; }
        /// <summary>
        /// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
        /// </summary>
        public string displayName { get; set; }
        /// <summary>
        /// The bungie global display name, if set.
        /// </summary>
        public string bungieGlobalDisplayName { get; set; }
        /// <summary>
        /// The bungie global display name code, if set.
        /// </summary>
        public int? bungieGlobalDisplayNameCode { get; set; }
    }
}
