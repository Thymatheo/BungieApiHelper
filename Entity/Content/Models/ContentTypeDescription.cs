using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.Content.Models
{
    public class ContentTypeDescription
    {
        public string cType { get; set; }
        public string name { get; set; }
        public string contentDescription { get; set; }
        public string? previewImage { get; set; }
        public int priority { get; set; }
        public string? reminder { get; set; }
        public IEnumerable<ContentTypeProperty> properties { get; set; }
        public IEnumerable<TagMetadataDefinition> tagMetadata { get; set; }
        public Dictionary<string,TagMetadataItem> tagMetadataItems { get; set; }
        public IEnumerable<string> usageExamples { get; set; }
        public bool showInContentEditor { get; set; }
        public string? typeOf { get; set; }
        public string bindIdentifierToProperty { get; set; }
        public string? boundRegex { get; set; }
        public bool forceIdentifierBinding { get; set; }
        public bool allowComments { get; set; }
        public bool autoEnglishPropertyFallback { get; set; }
        public bool bulkUploadable { get; set; }
        public IEnumerable<ContentPreview?> previews { get; set; }
        public bool suppressCmsPath { get; set; }
        public IEnumerable<ContentTypePropertySection?> propertySections { get; set; }

    }
}
