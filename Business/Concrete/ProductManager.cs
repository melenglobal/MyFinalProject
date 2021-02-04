using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // Business codes..// bir business class başka sınıfları newlemez.. injection..
        // injection
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {   
            // iş kodları ?
            // Yetkili mi ?
            return _productDal.GetAll();
        }
    }
}
