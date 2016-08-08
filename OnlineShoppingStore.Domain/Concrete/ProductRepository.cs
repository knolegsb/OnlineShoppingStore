using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineDbContext context = new OnlineDbContext();

        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
