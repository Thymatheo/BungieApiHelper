using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Config;
using BungieApiHelper.Entity.Definition;
using BungieApiHelper.Entity.Destiny;
using BungieApiHelper.Entity.Responses;
using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper {
    public class Destiny2Helper : BasicHelper {
        public Destiny2Helper() : base("Destiny2") {
        }
        /// <summary>
        /// Returns the current version of the manifest as a json object.
        /// </summary>
        public async Task<BasicResponse<DestinyManifest>> Manifest() =>
            await Get<DestinyManifest>("Manifest");
        /// <summary>
        /// Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. 
        /// </summary>
        /// <remarks>
        /// Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don't use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.
        /// </remarks>
        /// <param name="entityType">The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.</param>
        /// <param name="hashIdentifier">The hash identifier for the specific Entity you want returned.</param>
        public async Task<BasicResponse<T>> Manifest<T>(string entityType, int hashIdentifier) where T : DestinyDefinition =>
            await Get<T>($"Manifest/{entityType}/{hashIdentifier}");
        /// <summary>
        /// Returns a list of Destiny memberships given a global Bungie Display Name. This method will hide overridden memberships due to cross save.
        /// </summary>
        /// <param name="membershipType">A valid non-BungieNet membership type, or All. Indicates which memberships to return. You probably want this set to All.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<IEnumerable<UserInfoCard>>> SearchDestinyPlayerByBungieName(BungieMembershipType membershipType, ExactSearchRequest content) =>
            await Post<IEnumerable<UserInfoCard>>($"SearchDestinyPlayerByBungieName/{membershipType}", content);
        /// <summary>
        /// Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information.
        /// </summary>
        /// <remarks>
        /// The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership.
        /// <para>
        /// It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. 
        /// </para>
        /// <para>
        /// Note that it will only return linked accounts whose linkages you are allowed to view.
        /// </para>
        /// </remarks>
        /// <param name="membershipType">The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don't pass us a PSN membership ID and the XBox membership type, it's not going to work!</param>
        /// <param name="membershipId">The type for the membership whose linked Destiny accounts you want returned.</param>
        /// <param name="getAllMemberships">(optional) if set to 'true', all memberships regardless of whether they're obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what.</param>
        public async Task<BasicResponse<DestinyLinkedProfilesResponse>> GetLinkedProfiles(BungieMembershipType membershipType, string membershipId, bool getAllMemberships = true) =>
            await Get<DestinyLinkedProfilesResponse>($"{membershipType}/Profile/{membershipId}/LinkedProfiles", queryParam: BuildQueryParam(new List<QueryParam>() { QueryParam.BuildSingleParam(getAllMemberships, "getAllMemberships") }));

        /// <summary>
        /// Returns Destiny Profile information for the supplied membership.
        /// </summary>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        public async Task<BasicResponse<DestinyProfileResponse>> GetProfile(BungieMembershipType membershipType, string destinyMembershipId, IEnumerable<DestinyComponentType> components) =>
             await Get<DestinyProfileResponse>($"{membershipType}/Profile/{destinyMembershipId}", queryParam: BuildQueryParam(new() { QueryParam.BuildMultipleParam(components.Select(x => ((int)x).ToString()), "components") }));

        /// <summary>
        /// Returns character information for the supplied character.
        /// </summary>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="characterId">ID of the character.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        public async Task<BasicResponse<DestinyCharacterResponse>> GetCharacter(BungieMembershipType membershipType, string destinyMembershipId, int characterId, IEnumerable<DestinyComponentType> components) =>
            await Get<DestinyCharacterResponse>($"{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}", queryParam: BuildQueryParam(new() { QueryParam.BuildMultipleParam(components.Select(x => ((int)x).ToString()), "components") }));
    }
}
