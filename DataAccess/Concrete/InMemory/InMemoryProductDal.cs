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

        List<Product> _products; //metodların dışında tanımlanan field, _x _y vs şeklinde olusturulur.
        public InMemoryProductDal() //ctor - constructor
        {
            _products = new List<Product> 
            {   //Oracle,Sql server,Postgres,MongoDB den geliyormus gibi...
                new Product { ProductId=1, CategoryId =1,ProductName ="Bardak", UnitPrice =15, UnitsInStock =200 },
                new Product { ProductId=2, CategoryId =1,ProductName ="Kamera", UnitPrice =15000, UnitsInStock =5 },
                new Product { ProductId=3, CategoryId =2,ProductName ="Telefon", UnitPrice =9500, UnitsInStock =50 },
                new Product { ProductId=4, CategoryId =2,ProductName ="Klavye", UnitPrice =250, UnitsInStock =30 },
                new Product { ProductId=5, CategoryId =2,ProductName ="Fare", UnitPrice =150, UnitsInStock =30 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //LINQ - Language Integrated Query
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); // lambda expression p=>
           

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();

            //Where içindeki şartlara uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
