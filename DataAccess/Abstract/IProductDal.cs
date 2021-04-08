using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAllByBrandId(int BrandId);
        List<Product> GetAllByColorId(int ColorId);
       
    }
}
