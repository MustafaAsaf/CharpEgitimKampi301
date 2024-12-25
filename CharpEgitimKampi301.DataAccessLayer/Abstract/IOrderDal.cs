using CharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.DataAccessLayer.Abstract
{
    //Burada Order sınıfı için Dal(data access layer) yani ekleme silme güncelleme işlemlerini yapabilirim.
    public interface IOrderDal :IGenericDal<Order>
    {
    }
}
