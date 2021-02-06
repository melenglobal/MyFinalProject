using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {   
        ICategoryDal _categoryDal; //Ctor injection

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; // Generate constructor
        }

        public List<Category> GetAll()
        {
            //Business Code
            return _categoryDal.GetAll();
       
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
