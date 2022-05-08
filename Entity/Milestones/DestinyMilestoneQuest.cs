using BungieApiHelper.Entity.Challenges;
using BungieApiHelper.Entity.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneQuest {
        /// <summary>
        /// Quests are defined as Items in content.
        /// </summary>
        /// <remarks>
        /// As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest.
        /// <para>
        /// It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
        /// </para>
        /// </remarks>
        public int questItemHash { get; set; }
        /// <summary>
        /// The current status of the quest for the character making the request.
        /// </summary>
        public DestinyQuestStatus status { get; set; }
        /// <summary>
        /// *IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. 
        /// </summary>
        /// <remarks>Remember to associate this with the DestinyMilestoneDefinition's activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.</remarks>
        public DestinyMilestoneActivity activity { get; set; }
        /// <summary>
        /// The activities referred to by this quest can have many associated challenges.
        /// </summary>
        /// <remarks>
        /// They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found.
        /// <para>
        /// In retrospect, I probably should have put these under the specific Activity Variants, but it's too late to change it now.
        /// </para>
        /// <para>
        /// Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places.
        /// </para>
        /// <para>
        /// That may come as a later revision.
        /// </para>
        /// </remarks>
        public IEnumerable<DestinyChallengeStatus> challenges { get; set; }
    }
}
