using BungieApiHelper.Entity.Destiny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Artifacts {
    public class DestinyArtifactProfileScoped {
        public int artifactHash { get; set; }
        public DestinyProgression pointProgression { get; set; }
        public int pointsAcquired { get; set; }
        public object powerBonusProgression { get; set; }
        public DestinyProgression powerBonus { get; set; }
    }
}
