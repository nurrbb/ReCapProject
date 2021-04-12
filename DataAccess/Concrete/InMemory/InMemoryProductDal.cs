using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
              new Product{Id=1,CarName="Volvo V40",BrandId=1,ColourId=1,ModelYear="2015",DailyPrice=350,Description="Beyaz Volvo V40 2015 model"},
              new Product{Id=2,CarName="VW Jetta",BrandId=2,ColourId=1,ModelYear="2016",DailyPrice=250,Description="VW 2016 Model Beyaz Jetta"},
              new Product{Id=3,CarName="Mercedes Vito",BrandId=3,ColourId=2,ModelYear="2016",DailyPrice=400,Description="Siyah Mercedes Vito VIP araç "},
              new Product{Id=4,CarName="Mercedes C180",BrandId=3,ColourId=3,ModelYear="2017",DailyPrice=750,Description="Gümüş Mercedes C180"},
              new Product{Id=5,CarName="Hundai  i20",BrandId=4,ColourId=1,ModelYear="2019",DailyPrice=180,Description="Beyaz Hyunai i20 "},
              new Product{Id=6,CarName="Renault Clio",BrandId=5,ColourId=1,ModelYear="2017",DailyPrice=165,Description="Beyaz Renault Clio"},
              new Product{Id=7,CarName="VW Polo",BrandId=2,ColourId=1,ModelYear="2005",DailyPrice=150,Description="Beyaz VW Polo"}

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

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
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
            productToUpdate.CarName = product.CarName;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.ColourId = product.ColourId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }
    }
}
