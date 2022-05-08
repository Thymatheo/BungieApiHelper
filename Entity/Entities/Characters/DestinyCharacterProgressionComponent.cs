using BungieApiHelper.Entity.Artifacts;
using BungieApiHelper.Entity.Definition.Checklists;
using BungieApiHelper.Entity.Destiny;
using BungieApiHelper.Entity.Entities.Items;
using BungieApiHelper.Entity.Milestones;
using BungieApiHelper.Entity.Progression;
using BungieApiHelper.Entity.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Entities.Characters {
    public class DestinyCharacterProgressionComponent {
        /// <summary>
        /// A Dictionary of all known progressions for the Character, keyed by the Progression's hash.
        /// </summary>
        /// <remarks>
        /// Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.
        /// </remarks>
        public Dictionary<int, DestinyProgression> progressions { get; set; }
        /// <summary>
        /// A dictionary of all known Factions, keyed by the Faction's hash. It contains data about this character's status with the faction.
        /// </summary>
        public Dictionary<int, DestinyFactionProgression> factions { get; set; }
        /// <summary>
        /// Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone's status.
        /// </summary>
        public Dictionary<int, DestinyMilestone> milestones { get; set; }
        /// <summary>
        /// If the user has any active quests, the quests' statuses will be returned here.
        /// </summary>
        /// <remarks>
        /// Note that quests have been largely supplanted by Milestones, but that doesn't mean that they won't make a comeback independent of milestones at some point.
        /// <para>
        /// (Fun fact: quests came back as I feared they would, but we never looped back to populate this... I'm going to put that in the backlog.)
        /// </para>
        /// </remarks>
        public IEnumerable<DestinyQuestStatus> quests { get; set; }
        /// <summary>
        /// Sometimes, you have items in your inventory that don't have instances, but still have Objective information. This provides you that objective information for uninstanced items.
        /// </summary>
        /// <remarks>
        /// This dictionary is keyed by the item's hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.
        /// </remarks>
        public Dictionary<int, IEnumerable<int>> uninstancedItemObjectives { get; set; }
        /// <summary>
        /// Sometimes, you have items in your inventory that don't have instances, but still have perks (for example: Trials passage cards). This gives you the perk information for uninstanced items.
        /// </summary>
        /// <remarks>
        /// This dictionary is keyed by item hash, which you can use to look up the corresponding item definition. The value is the list of perks states for the item.
        /// </remarks>
        public Dictionary<int, DestinyItemPerksComponent> uninstancedItemPerks { get; set; }
        /// <summary>
        /// The set of checklists that can be examined for this specific character, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)
        /// </summary>
        /// <remarks>
        /// For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.
        /// </remarks>
        public Dictionary<int, DestinyChecklistDefinition> checklists { get; set; }
        /// <summary>
        /// Data related to your progress on the current season's artifact that can vary per character.
        /// </summary>
        public DestinyArtifactProfileScoped seasonalArtifact { get; set; }
    }
}
