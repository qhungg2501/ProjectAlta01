using DataLib.Dbcontext;
using Microsoft.EntityFrameworkCore;

namespace AltaProject01
{
    public static class DataConnect
    {
        public static IServiceCollection ServicesCollection (this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DataContext> (options => options.UseSqlServer(configuration.GetConnectionString("AltaProject"),
               x => x.MigrationsAssembly(typeof(DataContext).Assembly.FullName)),ServiceLifetime.Transient);
            
            return service;
        } 

    }
}
