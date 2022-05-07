using System.Collections.Generic;

namespace BungieApiHelper.Entity.Config {
    public class DestinyManifest {
        public string version { get; set; }
        public string mobileAssetContentPath { get; set; }
        public IEnumerable<GearAssetDataBaseDefinition> mobileGearAssetDataBases { get; set; }
        public Dictionary<string, string> mobileWorldContentPaths { get; set; }
        /// <summary>
        /// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)
        /// </summary>
        public Dictionary<string, string> jsonWorldContentPaths { get; set; }
        /// <summary>
        /// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. 
        /// </summary>
        /// <remarks>
        /// WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.
        /// </remarks>
        public Dictionary<string, object> jsonWorldComponentContentPaths { get; set; }
        public string mobileClanBannerDatabasePath { get; set; }
        public Dictionary<string, object> mobileGearCDN { get; set; }
        /// <summary>
        /// Information about the "Image Pyramid" for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the "original/full size" Destiny images, with the same file name and extension as the original image itself.
        /// </summary>
        /// <remarks>
        /// This lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable.
        /// </remarks>
        public IEnumerable<ImagePyramidEntry> iconImagePyramidInfo { get; set; }
    }
}
