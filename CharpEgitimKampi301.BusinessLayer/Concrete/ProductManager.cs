using CharpEgitimKampi301.BusinessLayer.Abstract;
using CharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly EfProductDal _productDal;

        public ProductManager(EfProductDal productDal)
        {
            _productDal = productDal;
        }


        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<object> TGetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
        }

        public void TInsert(Product entity)
        {
             _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
