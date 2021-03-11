using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepostory<Category>
    {    

        /// Generic repostory design pattern 
        // List<T> yapammizin adı generic repostory tasarım deseni.
        // Icategorydal ile ıproduct dal yerine bir tane yazacagiz.
        /*
        List<Category> GetAll();

        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

        List<Category> GetAllByCategory(int productId);
        */
    }
}
