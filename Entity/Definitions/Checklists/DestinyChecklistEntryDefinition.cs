using BungieApiHelper.Entity.Definition.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Definition.Checklists {
    public class DestinyChecklistEntryDefinition {
        /// <summary>
        /// The identifier for this Checklist entry. Guaranteed unique only within this Checklist Definition, and not globally/for all checklists.
        /// </summary>
        public string hash { get; set; }
        /// <summary>
        /// Even if no other associations exist, we will give you *something* for display properties. In cases where we have no associated entities, it may be as simple as a numerical identifier.
        /// </summary>
        public DestinyDisplayPropertiesDefinition displayProperties { get; set; }
        public int destinationHash { get; set; }
        public int locationHash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note that a Bubble's hash doesn't uniquely identify a "top level" entity in Destiny.
        /// <para>
        /// Only the combination of location and bubble can uniquely identify a place in the world of Destiny: so if bubbleHash is populated, locationHash must too be populated for it to have any meaning.
        /// </para>
        /// <para>
        /// You can use this property if it is populated to look up the DestinyLocationDefinition's associated .locationReleases[].activityBubbleName property.
        /// </para>
        /// </remarks>
        public int bubbleHash { get; set; }
        public int activityHash { get; set; }
        public int itemHash { get; set; }
        public int vendorHash { get; set; }
        public int vendorInteractionIndex { get; set; }
        /// <summary>
        /// The scope at which this specific entry can be computed.
        /// </summary>
        public int scope { get; set; }

    }
}
