using AspnetCoreWithBugs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreWithBugs.Data
{
    /// <summary>
    /// Database helper methods for Models.Product
    /// </summary>
    public static class ProductDb
    {
        public static async Task<Product> Create(Product p, ProductContext context)
        {
            await context.AddAsync(p);
            await context.SaveChangesAsync();

            return p;
        }
    }
}
