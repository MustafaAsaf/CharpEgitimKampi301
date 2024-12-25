using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class //sen dışarıdan bir T değeri alıcaksın bu T değeride bir class olucak. Yani sadece sınıflarla çalışıyor olacaksın.
    {
        void Insert(T entity); //Sen t türünde bir entity parametresi alıcaksın.
        void Update(T entity); //Sen t türünde bir entity parametresi alıcaksın.
        void Delete(int id); //Silme işlemi için dışarıdan bir id değeri alacak.
        List<T> GetAll(); //Bütün verileri getirecek olan metot.
        T GetById(int id); //Dışarıdan gelen id ye göre veriyi getirecek metot.
    }
}
