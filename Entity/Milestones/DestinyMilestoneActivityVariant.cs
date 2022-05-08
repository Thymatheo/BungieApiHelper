using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Milestones {
    public class DestinyMilestoneActivityVariant : DefaultDestinyMilestoneActivity {
        /// <summary>
        /// An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL
        /// </summary>
        public DestinyMilestoneActivityCompletionStatus completionStatus { get; set; }
    }
}
