using BungieApiHelper.Entity.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Challenges {
    public class DestinyChallengeStatus {
        /// <summary>
        /// The progress - including completion status - of the active challenge.
        /// </summary>
        public DestinyObjectiveProgress objective { get; set; }
    }
}
