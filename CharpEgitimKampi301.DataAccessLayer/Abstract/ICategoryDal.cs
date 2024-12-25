using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.DataAccessLayer.Abstract
{
    //Ben burada Category sınıfım için Dal(data access layer) yani ekleme silme güncelleme işlemlerini yapabilirim.
    public interface ICategoryDal:IGenericDal<Category>
    {

    }
}
