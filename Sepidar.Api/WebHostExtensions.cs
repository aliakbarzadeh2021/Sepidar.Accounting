using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sepidar.Logger.Context;
using Sepidar.Repository.Implementation;

namespace Sepidar.Api
{
    public static class WebHostExtensions
    {
        public static IWebHost Seed(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                var databaseContext = serviceProvider.GetRequiredService<DataContext>();
                var logContext = serviceProvider.GetRequiredService<LogContext>();

                databaseContext.Database.Migrate();
                logContext.Database.Migrate();
            }

            return host;
        }

    }
}
