using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneActivityPhase {
        /// <summary>
        /// Indicates if the phase has been completed.
        /// </summary>
        public bool complete { get; set; }
        /// <summary>
        /// In DestinyActivityDefinition, if the activity has phases, there will be a set of phases defined in the "insertionPoints" property. 
        /// </summary>
        /// <remarks>This is the hash that maps to that phase.</remarks>
        public int phaseHash { get; set; }
    }
}
