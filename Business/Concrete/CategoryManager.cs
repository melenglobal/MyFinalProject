using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {   
        ICategoryDal _categoryDal; //Ctor injection

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; // Generate constructor
        }

       

        IDataResult<List<Category>> ICategoryService.GetAll()
        {   
            // iş kodları
            return  new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }


        IDataResult<Category> ICategoryService.GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
