using BungieApiHelper.Entity.Unspecified.SingleComponentResponseOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Responses {
    public class DestinyCharacterResponse {
        /// <summary>
        /// The character-level non-equipped inventory items.
        /// </summary>
        /// <remarks>
        /// COMPONENT TYPE: CharacterInventories
        /// </remarks>
        public SingleComponentResponseOfDestinyInventoryComponent inventory { get; set; }
        /// <summary>
        /// Base information about the character in question.
        /// </summary>
        /// <remarks>
        /// COMPONENT TYPE: Characters
        /// </remarks>
        public SingleComponentResponseOfDestinyCharacterComponent character { get; set; }
        /// <summary>
        /// Character progression data, including Milestones.
        /// </summary>
        /// <remarks>
        /// COMPONENT TYPE: CharacterProgressions
        /// </remarks>
        public SingleComponentResponseOfDestinyCharacterProgressionComponent progressions { get; set; }
    }
}
