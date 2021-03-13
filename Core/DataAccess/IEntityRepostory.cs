
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constrait sınırlandıracagiz. t yi. database dekileri istesin sadece
    //:class referance tip olmak zorunda
    // ıentity olmak zorunda.
    //ientity newlenwmiyor.
    public interface IEntityRepostory<T> where T:class,IEntity,new ()
    {
        //Expression yapısi gerekli.bu yapiyi ogren.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // List<Product> GetAllByCategory(int categoryId);
       ///T get expression delege yapisi lazim. Ustteki cozum icin kolay olur.
    }
}
