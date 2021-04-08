using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> 
            {  
               new Product {Id=1,BrandId=1,ColourId=2,ModelYear=2015,DailyPrice=238.000,Description="GOLF 7 DSG DİZEL HİGHLİNE "},
               new Product {Id=2,BrandId=1,ColourId=1,ModelYear=2016,DailyPrice=342.750 ,Description="2016 TIGUAN 1.4TSI HIGHLINE HAYALET DSG CM "},
               new Product {Id=3,BrandId=2,ColourId=5,ModelYear=2019,DailyPrice=540.000 ,Description=" A4 45 TFSI quattro"},
               new Product {Id=4,BrandId=3,ColourId=6,ModelYear=2015,DailyPrice=690.000 ,Description="TESLA MODEL S P85D"},
               new Product {Id=5,BrandId=4,ColourId=1,ModelYear=2018,DailyPrice=332.900 ,Description="VOLVO V40 1.5 T3 INSCRIPTION GEARTRONIC"},
               new Product {Id=6,BrandId=4,ColourId=3,ModelYear=2011,DailyPrice=199.000 ,Description="316i Comfort Plus /Sunroof / Xenon / Deri / LPG"}

            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            foreach (var p in _products)
            {
                if (product.Id == p.Id)
                {
                    productToDelete = p;
                }
            }
            productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }
        public List<Product> GetAllByBrandId(int BrandId)
        {
            return _products.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<Product> GetAllByColorId(int ColorId)
        {
            return _products.Where(p => p.ColourId == ColorId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.ColourId = product.ColourId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }
    }
}
