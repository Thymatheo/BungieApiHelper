using BungieApiHelper.Entity.HistoricalStats.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneActivity : DefaultDestinyMilestoneActivity {
        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. 
        /// </summary>
        /// <remarks>
        /// Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.
        /// <para>
        /// Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones.
        /// </para>
        /// <para>
        /// Use only the active ones to match what's really live.
        /// </para>
        /// </remarks>
        public IEnumerable<int> modifierHashes { get; set; }
        /// <summary>
        /// If you want more than just name/location/etc... you're going to have to dig into and show the variants of the conceptual activity.
        /// </summary>
        /// <remarks>
        /// These will differ in seemingly arbitrary ways, like difficulty level and modifiers applied.
        /// <para>
        /// Show it in whatever way tickles your fancy.
        /// </para>
        /// </remarks>
        public IEnumerable<int> variants { get; set; }
    }
}
