using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Application;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper {
    public class AppHelper : BasicHelper {
        public AppHelper() : base("App") { }
        public async Task<BasicResponse<ApiUsage>> GetApplicationApiUsage(int appId, DateTime? start, DateTime? end) {
            List<QueryParam> param = new List<QueryParam>();
            if (start.HasValue)
                param.Add(new QueryParam() { Label = "start", Value = start.Value });
            if (end.HasValue)
                param.Add(new QueryParam() { Label = "end", Value = end.Value });
            return await Get<ApiUsage>($"ApiUsage/{appId}/", queryParam: $"{(start.HasValue || end.HasValue ? $"?{BuildQueryParam(param)}" : "")}");
        }
        public async Task<BasicResponse<IEnumerable<Application>>> GetBungieApplication() =>
            await Get<IEnumerable<Application>>("FirstParty");
    }
}
