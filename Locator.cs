using BungieApiHelper.Controller;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace BungieApiHelper {
    public static class Locator {
        public static BungieApiHelperConfig Config { get; set; }
        public static IServiceProvider Provider { get; private set; }
        public static IServiceCollection AddServiceRequierment(this IServiceCollection services, BungieApiHelperConfig config) {
            Config = config;
            services.AddMvcCore().AddApplicationPart(typeof(AppController).GetTypeInfo().Assembly);
            Provider = services
                .AddHttpContextAccessor()
                .BuildServiceProvider();
            return services;
        }
        public static IApplicationBuilder AddAppRequierement(this IApplicationBuilder app) => app;
    }
}
