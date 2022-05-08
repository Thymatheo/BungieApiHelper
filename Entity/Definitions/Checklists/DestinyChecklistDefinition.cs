using BungieApiHelper.Entity.Definition.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Definition.Checklists {
    public class DestinyChecklistDefinition : DestinyDefinition {
        public DestinyDisplayPropertiesDefinition displayProperties { get; set; }
        /// <summary>
        /// A localized string prompting you to view the checklist.
        /// </summary>
        public string viewActionString { get; set; }
        /// <summary>
        /// Indicates whether you will find this checklist on the Profile or Character components.
        /// </summary>
        public int scope { get; set; }
        /// <summary>
        /// The individual checklist items. Gotta catch 'em all.
        /// </summary>
        public IEnumerable<DestinyChecklistEntryDefinition> entries { get; set; }
    }
}
