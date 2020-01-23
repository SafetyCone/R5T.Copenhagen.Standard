using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Canterbury.Standard;
using R5T.Copenhagen.Default;


namespace R5T.Copenhagen.Standard
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCDrivePathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<ICDrivePathProvider, CDrivePathProvider>()
                .AddCDriveNameConvention()
                ;

            return services;
        }
    }
}
