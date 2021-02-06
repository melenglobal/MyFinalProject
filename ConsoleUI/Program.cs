using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {    //SOLİD O- Open Closed Principle
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal()); // Beni yenileyebilmen için, hangi veri yöntemi ile çalıştığını bana söyle zahmet olmaz ise.

            foreach (var product in productManager.GetByUnitPrice(75,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
