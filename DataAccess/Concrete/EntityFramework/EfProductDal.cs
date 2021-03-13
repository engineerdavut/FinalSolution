using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityFrameworkBase<Product, NorthwindContext>, IProductDal
    {
        //Nuget
        /*
        List<Product> _products;
        public EfProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductID=1,CategoryID=1,ProductName="ekmek",UnitsInStock=15,UnitPrice=15},
                new Product{ProductID=2,CategoryID=1,ProductName="araba",UnitsInStock=500,UnitPrice=78},
                new Product{ProductID=3,CategoryID=2,ProductName="saat",UnitsInStock=1500,UnitPrice=50},
                new Product{ProductID=4,CategoryID=2,ProductName="kanepe",UnitsInStock=150,UnitPrice=10},
                new Product{ProductID=5,CategoryID=2,ProductName="buzdolabi",UnitsInStock=85,UnitPrice=60}

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
        /*
        Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
        _products.Remove(productToDelete);
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return _products;
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
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

    */
        /*
        public void Add(Product entity)
        {   //using nesnesi garbage collectora hemen ugrar. isi bitince cope atilir bellek yorar.
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                //turned operatörü
                return filter == null ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        */
    }
}
