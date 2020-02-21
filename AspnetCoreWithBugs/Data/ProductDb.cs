using AspnetCoreWithBugs.Models;
using Microsoft.EntityFrameworkCore;
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

        public static async Task<Product> Edit(Product p, ProductContext context)
        {
            await context.AddAsync(p);
            context.Entry(p).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return p;
        }

        public static async Task Delete(int id, ProductContext context) 
        {
            var product = await context.Product.FindAsync(id);
            context.Product.Remove(product);
            await context.SaveChangesAsync();
        }

        public static async Task<List<Product>> ShowAll(ProductContext context)
        {
            return await context.Product.ToListAsync();           
        }

    }
}
