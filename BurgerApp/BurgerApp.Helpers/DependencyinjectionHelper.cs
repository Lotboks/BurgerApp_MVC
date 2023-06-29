﻿

namespace BurgerApp.Helpers
{
    using BurgerApp.DataAccess.DataContext;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyinjectionHelper
    {

        public static void InjectDbContext(this IServiceCollection services)
        {
            services.AddDbContext<BurgerAppDbContext>(options =>
            options.UseSqlServer(@"Data Source=(localdb)\Local;Database=BurgerAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
        }

    }
}
