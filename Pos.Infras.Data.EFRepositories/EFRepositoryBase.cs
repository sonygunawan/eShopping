using Brain.Commons;
using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.EFRepositories
{
    public abstract class EFRepositoryBase<TEntity> where TEntity : EntityBase, new()
    {
        protected PosContext ctx;
        protected DbSet<TEntity> data;
        public EFRepositoryBase(PosContext posContext)
        {
            this.ctx = posContext;
            data = GetEFSet();
        }
        public EFRepositoryBase() : this(new PosContext())
        {

        }

        protected abstract DbSet<TEntity> GetEFSet();
        
        public TEntity GetById(int id)
        {
            
            return data.Where(p => p.Id == id).Single();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return data.ToList();
        }

        public int GetCount()
        {
            return data.ToList().Count();
        }
        public void Save(TEntity entity)
        {
            if (entity.Id == 0)
            {
                data.Add(entity);
            }
            else
            {
                ctx.Entry(entity).State = EntityState.Modified;
            }
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = new TEntity() { Id = id };
            data.Attach(entity);
            data.Remove(entity);
            ctx.SaveChanges();
        }
    }
}
