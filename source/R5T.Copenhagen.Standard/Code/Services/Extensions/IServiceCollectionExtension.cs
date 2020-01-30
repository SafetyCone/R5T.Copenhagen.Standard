using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Canterbury.Standard;
using R5T.Copenhagen.Default;
using R5T.Dacia;


namespace R5T.Copenhagen.Standard
{
    public static class IServiceCollectionExtension
    {
        /// <summary>
        /// Adds the standard <see cref="ICDrivePathProvider"/> implementation.
        /// </summary>
        public static IServiceCollection AddCDrivePathProvider(this IServiceCollection services)
        {
            services.AddDefaultCDrivePathProvider(services.AddCDriveNameConventionAction());

            return services;
        }

        /// <summary>
        /// Adds the standard <see cref="ICDrivePathProvider"/> implementation.
        /// </summary>
        public static ServiceAction<ICDrivePathProvider> AddCDrivePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICDrivePathProvider>(() => services.AddCDrivePathProvider());
            return serviceAction;
        }
    }
}
