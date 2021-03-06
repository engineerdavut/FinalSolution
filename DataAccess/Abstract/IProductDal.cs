using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepostory<Product>
    {
        /*
        List<Product> GetAll();

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
        */

        // DTO data transformation object.
        List<ProductDetailDto> GetProductDetails();

    }
}
