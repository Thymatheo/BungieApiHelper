using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneRewardEntry {
        /// <summary>
        /// The identifier for the reward entry in question.
        /// </summary>
        /// <remarks>
        /// It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone's DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data.
        /// </remarks>
        public int rewardEntryHash { get; set; }
        /// <summary>
        /// If TRUE, the player has earned this reward.
        /// </summary>
        public bool earned { get; set; }
        /// <summary>
        /// If TRUE, the player has redeemed/picked up/obtained this reward. 
        /// </summary>
        /// <remarks>
        /// Feel free to alias this to "gotTheShinyBauble" in your own codebase.
        /// </remarks>
        public bool redeemed { get; set; }

    }
}
