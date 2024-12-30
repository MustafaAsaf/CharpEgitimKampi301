using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.DataAccessLayer.Abstract;
using CharpEgitimKampi301.DataAccessLayer.Context;

namespace CharpEgitimKampi301.DataAccessLayer.Repositories
{
    /// <summary>
    /// GenericRepository, katmanlı mimaride veri erişim işlemlerini (CRUD) tüm modeller için genelleştirerek kod tekrarını azaltır ve standartlaştırır. Farklı tablolar için aynı temel işlemleri sağlarken, gerektiğinde genişletilebilir. Bu sayede daha modüler, kolay yönetilebilir ve temiz bir veri erişim katmanı sunar.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T> : IGenericDal<T> where T : class //Dşarıdan bir T değeri al IGenericDal'dan miras al ve T değeri mutlaka class olmalı.
    {
        private KampContext context = new KampContext();
        private readonly DbSet<T> _object;

        public GenericRepository() //GenericRepository adında bir sınıf çağrıldığı zaman _object'te bir nesne örneği oluştur. 
        {
            _object = context.Set<T>();
        }

        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
