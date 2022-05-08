using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Quests {
    public class DestinyQuestStatus {
        /// <summary>
        /// The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition).
        /// </summary>
        /// <remarks>
        /// For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
        /// </remarks>
        public int questHash { get; set; }
        /// <summary>
        /// The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. 
        /// </summary>
        /// <remarks>
        ///  You can use this to get human readable data about the current step and what to do in that step.
        /// </remarks>
        public int stepHash { get; set; }
        /// <summary>
        /// A step can have multiple objectives.
        /// </summary>
        /// <remarks>
        /// This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.
        /// </remarks>
        public IEnumerable<DestinyObjectiveProgress> stepObjectives { get; set; }
        /// <summary>
        /// Whether or not the quest is tracked
        /// </summary>
        public bool tracked { get; set; }
        /// <summary>
        /// The current Quest Step will be an instanced item in the player's inventory.
        /// </summary>
        /// <remarks>
        /// If you care about that, this is the instance ID of that item.
        /// </remarks>
        public int itemInstanceId { get; set; }
        /// <summary>
        /// Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.
        /// </summary>
        public bool completed { get; set; }
        /// <summary>
        /// Whether or not you have redeemed rewards for this quest.
        /// </summary>
        public bool redeemed { get; set; }
        /// <summary>
        /// Whether or not you have started this quest.
        /// </summary>
        public bool started { get; set; }
        /// <summary>
        /// If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.
        /// </summary>
        public int? vendorHash { get; set; }
    }
}
