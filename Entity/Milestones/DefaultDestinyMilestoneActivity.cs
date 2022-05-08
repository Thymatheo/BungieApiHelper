using BungieApiHelper.Entity.HistoricalStats.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DefaultDestinyMilestoneActivity {
        /// <summary>
        /// The hash of an arbitrarily chosen variant of this activity.
        /// </summary>
        /// <remarks>
        /// We'll go ahead and call that the "canonical" activity, because if you're using this value you should only use it for properties that are common across the variants: things like the name of the activity, it's location, etc... 
        /// <para>
        /// Use this hash to look up the DestinyActivityDefinition of this activity for rendering data.
        /// </para>
        /// </remarks>
        public int activityHash { get; set; }
        /// <summary>
        /// The hash identifier of the most specific.
        /// <para>Activity Mode under which this activity is played. </para>
        /// </summary>
        /// <remarks>
        /// This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under.
        /// <para>
        /// If it's a playlist, this will be less specific: but hopefully useful in some way.
        /// </para>
        /// </remarks>
        public int activityModeHash { get; set; }
        /// <summary>
        /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
        /// </summary>
        public DestinyActivityModeType activityModeType { get; set; }
    }
}
