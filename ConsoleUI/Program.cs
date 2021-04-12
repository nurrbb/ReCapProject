using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager product = new ProductManager(new EfProductDal());
            BrandManager brand = new BrandManager(new EfBrandDal());
            


        }
    }
}
