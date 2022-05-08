using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneActivityCompletionStatus {
        /// <summary>
        /// If the activity has been "completed", that information will be returned here.
        /// </summary>
        public bool completed { get; set; }
        /// <summary>
        /// If the Activity has discrete "phases" that we can track, that info will be here.
        /// </summary>
        /// <remarks>
        /// Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
        /// </remarks>
        public IEnumerable<DestinyMilestoneActivityPhase> phases { get; set; }
    }
}
