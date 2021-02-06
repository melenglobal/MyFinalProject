using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T: class,IEntity,new() //Generic constraint ,class olmalı,yenilenebilir olmalı
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Delegate
        T Get(Expression<Func<T, bool>> filter); 

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // List<T> GetAllByCategory(int categoryId); bu koda artık ihtiyacımız yok.
    }
}
