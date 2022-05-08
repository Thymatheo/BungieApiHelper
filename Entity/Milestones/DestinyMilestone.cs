using BungieApiHelper.Entity.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestone {
        /// <summary>
        /// The unique identifier for the Milestone.
        /// </summary>
        /// <remarks>Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.</remarks>
        public int milestoneHash { get; set; }
        /// <summary>
        /// Indicates what quests are available for this Milestone. 
        /// </summary>
        /// <remarks>
        /// Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time.
        /// <para>
        /// All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. 
        /// </para>
        /// <para>
        /// It is possible for Milestones to not have any quests.
        /// </para>
        /// </remarks>
        public IEnumerable<DestinyMilestoneQuest> availableQuests { get; set; }
        /// <summary>
        /// The currently active Activities in this milestone, when the Milestone is driven by Challenges.
        /// </summary>
        /// <remarks>
        /// Not all Milestones have Challenges, but when they do this will indicate the Activities and Challenges under those Activities related to this Milestone.
        /// </remarks>
        public IEnumerable<DestinyMilestoneChallengeActivity> activities { get; set; }
        /// <summary>
        /// Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn't fit neatly into any of the common components such as Quests. 
        /// </summary>
        /// <remarks>
        /// A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket.
        /// <para>
        /// Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value.
        /// </para>
        /// <para>
        /// The value in the dictionary is the floating point number. The definition will tell you how to format this number.
        /// </para>
        /// </remarks>
        public Dictionary<string, float> values { get; set; }
        /// <summary>
        ///  milestone may have one or more active vendors that are "related" to it (that provide rewards, or that are the initiators of the Milestone).
        /// </summary>
        /// <remarks>
        /// I already regret this, even as I'm typing it. [I told you I'd regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards.
        /// <para>
        /// The player may not be able to interact with one or more of those vendors.
        /// </para>
        /// <para>
        /// This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.
        /// </para>
        /// <para>
        /// Before we even use it, it's already deprecated! How much of a bummer is that? We need more data.
        /// </para>
        /// </remarks>
        public int vendorHashes { get; set; }
        /// <summary>
        /// Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. 
        /// </summary>
        /// <remarks>
        /// This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.
        /// </remarks>
        public IEnumerable<DestinyVendorDefinition> vendors { get; set; }
        /// <summary>
        /// If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. 
        /// </summary>
        /// <remarks>
        /// (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone.
        /// <para>
        /// Think of these as "overview/checklist" rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren't under a specific Quest.
        /// </para>
        /// </remarks>
        public IEnumerable<DestinyMilestoneRewardCategory> rewards { get; set; }
        /// <summary>
        /// If known, this is the date when the event last began or refreshed.
        /// </summary>
        /// <remarks>
        /// It will only be populated for events with fixed and repeating start and end dates.
        /// </remarks>
        public DateTime startDate { get; set; }
        /// <summary>
        /// If known, this is the date when the event will next end or repeat. 
        /// </summary>
        /// <remarks>
        /// It will only be populated for events with fixed and repeating start and end dates.
        /// </remarks>
        public DateTime endDate { get; set; }
        /// <summary>
        /// Used for ordering milestones in a display to match how we order them in BNet. 
        /// </summary>
        /// <remarks>
        /// May pull from static data, or possibly in the future from dynamic information.
        /// </remarks>
        public int order { get; set; }
    }
}
