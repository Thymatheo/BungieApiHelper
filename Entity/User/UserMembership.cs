using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.User {
    public class UserMembership {
        /// <summary>
        /// Type of the membership. Not necessarily the native type.
        /// </summary>
        public int membershipType { get; set; }
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
        public int bungieGlobalDisplayNameCode { get; set; }
    }
}
