using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVStore.Models;

namespace TVStore
{
    public static class SampleData
    {
        public static void Initialize(TVContext context)
        {
            if (!context.TVs.Any())
            {
                context.TVs.AddRange(
                    new TV
                    {
                        Name = "Apple iTV",
                        Company = "Apple",
                        Price = 10000
                    },
                    new TV
                    {
                        Name = "Bravia 4HDD3",
                        Company = "Sony",
                        Price = 700
                    },
                    new TV
                    {
                        Name = "32-UHD",
                        Company = "Vivibright",
                        Price = 450
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
