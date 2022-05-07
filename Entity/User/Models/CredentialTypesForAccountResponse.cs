namespace BungieApiHelper.Entity.User.Models {
    public class CredentialTypesForAccountResponse {
        public byte credentialType { get; set; }
        public string credentialDisplayName { get; set; }
        public bool isPublic { get; set; }
        public string credentialAsString { get; set; }
    }
}
