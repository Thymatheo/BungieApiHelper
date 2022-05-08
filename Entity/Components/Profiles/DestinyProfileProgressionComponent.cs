using BungieApiHelper.Entity.Artifacts;
using BungieApiHelper.Entity.Definition.Checklists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Components.Profiles {
    public class DestinyProfileProgressionComponent {
        /// <summary>
        /// The set of checklists that can be examined on a profile-wide basis, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)
        /// </summary>
        /// <remarks>
        /// For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.
        /// </remarks>
        public Dictionary<int, Dictionary<int, int>> checklists { get; set; }
        /// <summary>
        /// Data related to your progress on the current season's artifact that is the same across characters.
        /// </summary>
        public DestinyArtifactProfileScoped seasonalArtifact { get; set; }
    }
}
