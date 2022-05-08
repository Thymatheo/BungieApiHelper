using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Definition.Common {
    public class DestinyDisplayPropertiesDefinition {
        public string description { get; set; }
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Note that "icon" is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition's icon was a big picture of a book.
        /// <para>
        /// But usually, it will be a small square image that you can use as... well, an icon.
        /// </para>
        /// <para>
        /// They are currently represented as 96px x 96px images.
        /// </para>
        /// </remarks>
        public string icon { get; set; }
        public IEnumerable<DestinyIconSequenceDefinition> iconSequences { get; set; }
        /// <summary>
        /// If this item has a high-res icon (at least for now, many things won't), then the path to that icon will be here.
        /// </summary>
        public string highResIcon { get; set; }
        public bool hasIcon { get; set; }
    }
}
