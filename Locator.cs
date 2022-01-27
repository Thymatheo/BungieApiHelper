using BungieApiHelper.Auth;
using BungieApiHelper.Auth.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BungieApiHelper
{
    public static class Locator
    {
        public static BungieApiHelperConfig Config { get; private set; }
        public static IServiceProvider Provider { get; private set; }
        public static IServiceCollection AddServiceRequierment(this IServiceCollection services, BungieApiHelperConfig config)
        {
            Config = config;
            Provider = services
                .AddHttpContextAccessor()
                .BuildServiceProvider();
            return services;
        }
        public static IApplicationBuilder AddAppRequierement(this IApplicationBuilder app) => app;
    }
}
