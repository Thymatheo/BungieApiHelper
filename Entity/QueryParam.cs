using System;
using System.Collections.Generic;
using System.Linq;

namespace BungieApiHelper.Entity {
    public class QueryParam {
        public string Label { get; set; }
        public object Value { get; set; }
        public IEnumerable<object> Values { get; set; }
        public static QueryParam BuildSingleParam(object value, string label) =>
            new(value, label);
        public static QueryParam BuildMultipleParam(IEnumerable<object> value, string label) =>
            new(value, label);

        private QueryParam(object value, string label) {
            Value = value;
            Label = label;
            Values = null;
        }

        public QueryParam(IEnumerable<object> values, string label) {
            Values = values;
            Label = label;
            Value = null;
        }
        public override string ToString() {
            if (Values == null) return $"{Label}={Value}";
            else if (Value == null) return $"{string.Join("$", Values.Select(x => $"{Label}={x}"))}";
            else return string.Empty;
        }
    }
}
