using System.Collections.Generic;

namespace BungieApiHelper.Entity.Content.Models {
    public class ContentTypeProperty {
        public string name { get; set; }
        public string rootPropertyName { get; set; }
        public string readableName { get; set; }
        public string? value { get; set; }
        public string propertyDescription { get; set; }
        public bool localizable { get; set; }
        public bool fallback { get; set; }
        public bool enabled { get; set; }
        public int order { get; set; }
        public bool visible { get; set; }
        public bool isTitle { get; set; }
        public bool required { get; set; }
        public int maxLength { get; set; }
        public int maxByteLength { get; set; }
        public int maxFileSize { get; set; }
        public string? regexp { get; set; }
        public string? validateAs { get; set; }
        public string rssAttribute { get; set; }
        public string? visibleDependency { get; set; }
        public string? visibleOn { get; set; }
        public int datatype { get; set; }
        public Dictionary<string, string> attributes { get; set; }
        public IEnumerable<ContentTypeProperty> childProperties { get; set; }
        public string? contentTypeAllowed { get; set; }
        public string? bindToProperty { get; set; }
        public string? boundRegex { get; set; }
        public Dictionary<string, string> representationSelection { get; set; }
        public IEnumerable<ContentTypeDefaultValue> defaultValues { get; set; }
        public bool isExternalAllowed { get; set; }
        public string? propertySection { get; set; }
        public int weight { get; set; }
        public string? entitytype { get; set; }
        public bool? isCombo { get; set; }
        public bool? suppressProperty { get; set; }
        public IEnumerable<string> legalContentTypes { get; set; }
        public string? representationValidationString { get; set; }
        public int? minWidth { get; set; }
        public int? maxWidth { get; set; }
        public int? minHeight { get; set; }
        public int? maxHeight { get; set; }
        public bool? isVideo { get; set; }
        public bool? isImage { get; set; }
    }
}