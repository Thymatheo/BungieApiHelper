using BungieApiHelper.Entity.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneChallengeActivity {
        public int activityHash { get; set; }
        public IEnumerable<DestinyChallengeStatus> challenges { get; set; }
        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common.
        /// <para>
        /// Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. 
        /// <para>
        /// Use only the active ones to match what's really live.
        /// </para>
        /// </remarks>
        public IEnumerable<int> modifierHashes { get; set; }
        /// <summary>
        /// The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).
        /// </summary>
        /// <remarks>
        /// As a concrete example of this data, the hashes you get for Raids will correspond to the currently active "Challenge Mode".
        /// <para>
        /// We don't have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the "option" that is enabled/disabled) and the value (whether it's enabled or disabled presently)
        /// </para>
        /// <para>
        /// On our side, we don't necessarily even know what these are used for (the game designers know, but we don't), and we have no human readable data for them. In order to use them, you will have to do some experimentation.
        /// </para>
        /// </remarks>
        public Dictionary<int, bool> booleanActivityOptions { get; set; }
        /// <summary>
        /// If returned, this is the index into the DestinyActivityDefinition's "loadouts" property, indicating the currently active loadout requirements.
        /// </summary>
        public int loadoutRequirementIndex { get; set; }
        /// <summary>
        /// If the Activity has discrete "phases" that we can track, that info will be here
        /// <para> 
        /// Otherwise, this value will be NULL.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
        /// </remarks>
        public IEnumerable<DestinyMilestoneActivityPhase> phases { get; set; }
    }
}
