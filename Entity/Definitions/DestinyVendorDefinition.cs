using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Definitions {
    public class DestinyVendorDefinition {
        /// <summary>
        /// The hash identifier of the Vendor related to this Milestone. 
        /// </summary>
        /// <remarks>
        /// You can show useful things from this, such as thier Faction icon or whatever you might care about.
        /// </remarks>
        public int vendorHash { get; set; }
        /// <summary>
        /// If this vendor is featuring a specific item for this event, this will be the hash identifier of that item. I'm taking bets now on how long we go before this needs to be a list or some other, more complex representation instead and I deprecate this too.
        /// </summary>
        /// <remarks>
        /// I'm going to go with 5 months. Calling it now, 2017-09-14 at 9:46pm PST.
        /// </remarks>
        public int previewItemHash { get; set; }    
    }
}
