namespace BungieApiHelper.Entity.Config {
    public class ImagePyramidEntry {
        /// <summary>
        /// The name of the subfolder where these images are located.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The factor by which the original image size has been reduced.
        /// </summary>
        public float factor { get; set; }
    }
}
