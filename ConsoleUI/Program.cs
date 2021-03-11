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
            ProductManager productManager1 = new ProductManager(new EfProductDal());
            foreach (var product in productManager1.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("-----------------------");
            foreach (var product in productManager1.GetAllByCategoryId(4))
            {

                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("-----------------------");
            foreach (var product in productManager1.GetByUnitPrice(40,90))
            {

                Console.WriteLine(product.ProductName);
            }

        }
    }
}
