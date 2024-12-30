using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.DataAccessLayer.Abstract;
using CharpEgitimKampi301.DataAccessLayer.Context;
using CharpEgitimKampi301.DataAccessLayer.Repositories;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal //GenericRepository'den miras al. Sadece Product sınıfı için miras al. Aynı zamanda IProductDal'dan da miras al.
    {
        public List<Object> GetProductWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x =>new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStatus = x.ProductStatus,
                ProducPrice = x.ProducPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName

            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
