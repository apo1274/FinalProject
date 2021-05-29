using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product prodcut);
        void Update(Product prodcut);
        void Delete(Product prodcut);

        List<Product> GetAllByCategory(int categoryId);

    }
}
