using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        public BrandManager(EfBrandDal efBrandDal)
        {
        }

        List<Brand> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
