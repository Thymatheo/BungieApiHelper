namespace BungieApiHelper.Entity.Queries {
    public class PagedQuery {
        public int itemsPerPage { get; set; }
        public int currentPage { get; set; }
        public string requestContinuationToken { get; set; }
    }
}
