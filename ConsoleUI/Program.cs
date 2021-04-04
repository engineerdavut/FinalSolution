using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            */
             ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }

        }

        private static void ProductTest()
        {
            ProductManager productManager1 = new ProductManager(new EfProductDal()
                , new CategoryManager(new EfCategoryDal()));
            var result = productManager1.GetProductDetails();
            if (result.success)
            {
                foreach (var product in result.Data)
                {

                    Console.WriteLine(product.ProductName + "     " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.message);
            }
            var result1 = productManager1.GetAll();
            if (result1.success)
            {
                foreach (var product in result1.Data)
                {

                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result1.message);
            }

            Console.WriteLine("-----------------------");
            foreach (var product in productManager1.GetAllByCategoryId(4).Data)
            {

                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("-----------------------");
            foreach (var product in productManager1.GetByUnitPrice(40, 90).Data)
            {

                Console.WriteLine(product.ProductName);
            }
            foreach (var product in productManager1.GetProductDetails().Data)
            {

                Console.WriteLine(product.ProductName+"     "+product.CategoryName);
            }

        }
    }
}
