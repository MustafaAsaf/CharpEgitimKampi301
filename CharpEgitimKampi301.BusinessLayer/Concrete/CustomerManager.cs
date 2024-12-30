using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.BusinessLayer.Abstract;
using CharpEgitimKampi301.DataAccessLayer.Abstract;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return  _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName!="" && //İsim alanı boş ise
                entity.CustomerName.Length>=3 && //İsim alanı 3 karakterden büyük ise
                entity.CustomerCity!=null && //Şehir alanı null değil ise
                entity.CustomerSurname!="" && //Soyadı alanı boş ise
                entity.CustomerName.Length<=30) //İsim alanı 30 karakterden fazla değilse
            {
                _customerDal.Insert(entity); //yukardaki kuralları sağlıyorsa ekleme işlemi yap.
            }
            else
            {
                //hata mesajı ver.
            }
        }

        public void TUpdate(Customer entity)
        {
           _customerDal.Update(entity);
        }
    }
}
