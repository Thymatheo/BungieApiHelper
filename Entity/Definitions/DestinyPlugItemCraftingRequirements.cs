using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Definition {
    public class DestinyPlugItemCraftingRequirements {
        public IEnumerable<DestinyPlugItemCraftingUnlockRequirement> unlockRequirements { get; set; }
        public int? requiredLevel { get; set; }
        public IEnumerable<int> materialRequirementHashes { get; set; }
    }
}
