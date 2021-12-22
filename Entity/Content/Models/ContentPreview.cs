namespace BungieApiHelper.Entity.Content.Models
{
    public class ContentPreview
    {
        public string name { get; set; }
        public string path { get; set; }
        public bool itemInSet { get; set; }
        public string setTag { get; set; }
        public int setNesting { get; set; }
        public int useSetId { get; set; }
    }
}