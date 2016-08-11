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

        public void SaveProduct(Product product)
        {
            if (product.ProductId == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product productEntry = context.Products.Find(product.ProductId);
                if(productEntry != null)
                {
                    productEntry.Name = product.Name;
                    productEntry.Description = product.Description;
                    productEntry.Price = product.Price;
                    productEntry.Category = product.Category;
                }
            }
            context.SaveChanges();
        }
    }
}
