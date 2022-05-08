using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Application;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper {
    public class AppHelper : BasicHelper {
        public AppHelper() : base("App") { }
        public async Task<BasicResponse<ApiUsage>> GetApplicationApiUsage(int appId, DateTime? start, DateTime? end) {
            List<QueryParam> param = new();
            if (start.HasValue)
                param.Add(QueryParam.BuildSingleParam(start.Value, "start"));
            if (end.HasValue)
                param.Add(QueryParam.BuildSingleParam(end.Value, "end"));
            return await Get<ApiUsage>($"ApiUsage/{appId}/", queryParam: $"{(start.HasValue || end.HasValue ? $"?{BuildQueryParam(param)}" : "")}");
        }
        public async Task<BasicResponse<IEnumerable<Application>>> GetBungieApplication() =>
            await Get<IEnumerable<Application>>("FirstParty");
    }
}
