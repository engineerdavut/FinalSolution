using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductID=1,CategoryID=1,ProductName="flashbellek",UnitsInStock=15,UnitPrice=15},
                new Product{ProductID=2,CategoryID=1,ProductName="mause",UnitsInStock=500,UnitPrice=78},
                new Product{ProductID=3,CategoryID=2,ProductName="fincan",UnitsInStock=1500,UnitPrice=50},
                new Product{ProductID=4,CategoryID=2,ProductName="tabak",UnitsInStock=150,UnitPrice=10},
                new Product{ProductID=5,CategoryID=2,ProductName="caydanlik",UnitsInStock=85,UnitPrice=60}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ siz Hali
            /*
            Product productToDelete = null;
            foreach (var p in _products)
            {
                if (product.ProductID == p.ProductID)
                {
                    productToDelete = p;
                }
            }
            _products.Remove(productToDelete);

            */
            // => lambda isareti her p icin anlamina gelir. First veya FirstOfDefault metotları da olur. Dongu var.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductID = product.ProductID;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
