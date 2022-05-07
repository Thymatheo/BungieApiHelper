using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Entities.Profiles {
    public class DestinyProfileComponent {
        /// <summary>
        /// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
        /// </summary>
        public UserInfoCard userInfo { get; set; }
        /// <summary>
        /// The last time the user played with any character on this Profile.
        /// </summary>
        public DateTime dateLastPlayed { get; set; }
        /// <summary>
        /// If you want to know what expansions they own, this will contain that data.

        /// </summary>
        public int versionsOwned { get; set; }
        /// <summary>
        /// A list of the character IDs, for further querying on your part.
        /// </summary>
        public IEnumerable<int> characterIds { get; set; }
        /// <summary>
        /// A list of seasons that this profile owns. Unlike versionsOwned, these stay with the profile across Platforms, and thus will be valid.
        /// </summary>
        public IEnumerable<int> seasonHashes { get; set; }
        /// <summary>
        /// If populated, this is a reference to the season that is currently active.
        /// </summary>
        public int currentSeasonHash { get; set; }
        /// <summary>
        /// If populated, this is the reward power cap for the current season.
        /// </summary>
        public int currentSeasonRewardPowerCap { get; set; }
    }
}
