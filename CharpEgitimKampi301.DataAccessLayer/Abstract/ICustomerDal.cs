using CharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.DataAccessLayer.Abstract
{
    //Burada Customer sınıfı için Dal(data access layer) yani ekleme silme güncelleme işlemlerini yapabi
    public interface ICustomerDal:IGenericDal<Customer>
    {
    }
}
