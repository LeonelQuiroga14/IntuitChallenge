using Intuit.Challenge.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Intuit.Challenge.DataAccess
{
    public static class ServiceExtension
    {
        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration Configuration)
        {

            //services.AddDbContextFactory<IntuitAppDbContext>(options =>
            //{
            //    options.UseSqlServer(Configuration.GetConnectionString("IntuitChallenge"),
            //        b =>
            //        {
            //            b.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);
            //            b.MigrationsAssembly(typeof(IntuitAppDbContext).Assembly.FullName);
            //        });

            //});
            services.AddDbContext<IntuitAppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("IntuitChallenge"),
                    b =>
                    {
                        b.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);
                        b.MigrationsAssembly(typeof(IntuitAppDbContext).Assembly.FullName);
                    });

            });


        }
    }

}
