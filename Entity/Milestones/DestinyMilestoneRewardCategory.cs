using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneRewardCategory {
        /// <summary>
        /// Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.
        /// </summary>
        public int rewardCategoryHash { get; set; }
        /// <summary>
        /// The individual reward entries for this category, and their status.
        /// </summary>
        public IEnumerable<DestinyMilestoneRewardEntry> entries { get; set; }

    }
}
