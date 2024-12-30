using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T :class //Service dışarıdan bir T değeri alıcak ve bu T değeri bir class olucak.
    {
        void TInsert(T entity); //Sen t türünde bir entity parametresi alıcaksın.
        void TUpdate(T entity); //Sen t türünde bir entity parametresi alıcaksın.
        void TDelete(T entity); //Silme işlemi için dışarıdan bir id değeri alacak.
        List<T> TGetAll(); //Bütün verileri getirecek olan metot.
        T TGetById(int id); //Dışarıdan gelen id ye göre veriyi getirecek metot.
    }
}
