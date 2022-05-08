using BungieApiHelper.Entity.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Entities.Items {
    public class DestinyItemPerksComponent {
        /// <summary>
        /// The list of perks to display in an item tooltip - and whether or not they have been activated.
        /// </summary>
        public IEnumerable<DestinyPerkReference> perks { get; set; }
    }
}
