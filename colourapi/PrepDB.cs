using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColourAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ColourAPI
{
    public class PrepDB
    {
        public static void PrepPolulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ColourContext>());
            }

        }

        private static void SeedData(ColourContext context)
        {
            System.Console.WriteLine("Applying");

            context.Database.Migrate();

            if (!context.ColourItems.Any())
            {
                System.Console.WriteLine("Adding seed");
                context.ColourItems.AddRange(
                    new Colour() {Id=1, ColourName = "Red" },
                    new Colour() {Id=3, ColourName = "Blue" },

                    new Colour() { Id = 2,ColourName = "Green" });
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Allready done seeding");
            }

        }
    }
}
