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
    public class EfCustomerDal:GenericRepository<Customer>, ICustomerDal//GenericRepository'den miras al. Sadece Customer sınıfı için miras al. Aynı zamanda ICustomerDal'dan da miras al
    {
    }
}
