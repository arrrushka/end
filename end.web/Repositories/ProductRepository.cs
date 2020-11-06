using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Week8Project.Core.Entities;
using Week8Project.Core.Exceptions.Repositories;
using Week8Project.Infrastructure.Data;

namespace Week8Project.Infrastructure.Repositories
{
    public class ProductRepository : PriceListRepository<Product>, IProductRepository
    {
        private readonly DbSet<Product> _products;

        public ProductRepository(DataContext dbContext) : base(dbContext)
        {
            _products = dbContext.Products; // or dbContext.Set<Product>()
        }

        public async Task<Product> GetProductWithMinimumPrice()
        {
            var min = await _products.MinAsync(p => p.Price);
            return await _products.FirstOrDefaultAsync(p => p.Price == min);
        }

        public async Task<Product> GetProduct() => _products;

    }
}
