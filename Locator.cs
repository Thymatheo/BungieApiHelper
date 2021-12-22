using BungieApiHelper.Auth;
using BungieApiHelper.Auth.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BungieApiHelper
{
    public static class Locator
    {
        public static BungieApiHelperConfig Config { get; private set; }
        public static IServiceCollection AddServiceRequierment(this IServiceCollection services, BungieApiHelperConfig config)
        {
            Config = config;
            return services
                .AddScoped<IAuthHelper, AuthHelper>()
                .AddHttpContextAccessor();
        }
        public static IApplicationBuilder AddAppRequierement(this IApplicationBuilder app) => app;
    }
}
