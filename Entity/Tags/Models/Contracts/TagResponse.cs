using BungieApiHelper.Entity.Ignores;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.Tags.Models.Contracts
{
    public class TagResponse
    {
        public string tagText { get; set; }
        public IgnoreResponse ignoreStatus { get; set; }
    }
}
