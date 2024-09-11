using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class ProductRepository : IRepository<int, Product>
    {
        private List<Product> products = [];
        private static int PRODUCT_ID = 1;
        public Product Create(Product Data)
        {
            Data.Id = PRODUCT_ID++;
            products.Add(Data);
            return Data;

        }

        public void Delete(int Id)
        {
            var product = products.Find(o => o.Id == Id);
            if (product == null)
                throw new Exception("Product not found.");
            products.Remove(product);
        }

        public Product Read(int Id)
        {
            var product = products.Find(o => o.Id == Id);
            if (product == null)
                throw new Exception("Product not found.");
            return product;
        }

        public Product Update(int Id, Product data)
        {
            var product = products.Find(o => o.Id == Id);
            if (product == null)
                throw new Exception("Product not found.");
            product.Name = data.Name;
            product.Price = data.Price;
            return product;

        }
    }
}
