using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity
{
    public class QueryParam
    {
        public string Label { get; set; }
        public object Value { get; set; }
        public override string ToString() =>
            $"{Label}={Value}";
    }
}
