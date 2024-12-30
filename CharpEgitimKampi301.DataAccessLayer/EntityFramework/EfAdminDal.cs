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
    public class EfAdminDal:GenericRepository<Admin>, IAdminDal //GenericRepository'den miras al. Sadece Admin sınıfı için miras al. Aynı zamanda IAdminDal'dan da miras al.
    {

    }
}
