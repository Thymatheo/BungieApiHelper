namespace BungieApiHelper.Entity.GroupsV2 {
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible "modes".
    /// <para>
    /// If you are querying for a group, you can pass any of the properties below.
    /// </para>
    /// <para>
    /// If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be null or undefined in your request, not just empty string/default values): - groupMemberCountFilter - localeFilter - tagText
    /// </para>
    /// <para>
    /// If you pass these, you will get a useless InvalidParameters error.
    /// </para>
    /// </remarks>
    public class GroupQuery {
        public string name { get; set; }
        public int groupType { get; set; }
        public int creationDate { get; set; }
        public int sortBy { get; set; }
        public GroupMemberCountFilterEnum groupMemberCountFilter { get; set; }
        public string localeFilter { get; set; }
        public string tagText { get; set; }
        public int itemsPerPage { get; set; }
        public int currentPage { get; set; }
        public string requestContinuationToken { get; set; }
    }
}
