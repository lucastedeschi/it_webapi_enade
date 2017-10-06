using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iniciacao.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbContext Db = new IDbContext();

        public void Delete(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(long id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
