namespace myApi.Helper;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public static class DbExtenstion
{
    public static void UpdateDatabase(this IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices
                   .GetRequiredService<IServiceScopeFactory>()
                   .CreateScope())
        {

            using (var context = serviceScope.ServiceProvider.GetService<DataContext>())
            {
                context?.Database.Migrate();
            }


        }


    }
}