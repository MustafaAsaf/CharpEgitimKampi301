using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.DataAccessLayer.Abstract;
using CharpEgitimKampi301.DataAccessLayer.Repositories;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfOrderDal:GenericRepository<Order>, IOrderDal //GenericRepository'den miras al. Sadece Order sınıfı için miras al. Aynı zamanda IOrderDal'dan da miras al.
    {

    }
}
