using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAPI_V1.Models;

namespace ProductAPI_V1.Data
{
    public class ProductAPI_V1Context : DbContext
    {
        public ProductAPI_V1Context (DbContextOptions<ProductAPI_V1Context> options)
            : base(options)
        {
        }

        public DbSet<ProductAPI_V1.Models.Product> Product { get; set; } = default!;
        public DbSet<ProductAPI_V1.Models.Category> Category { get; set; } = default!;

    }
}
