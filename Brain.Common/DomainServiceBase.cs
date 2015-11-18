using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain.Commons
{
    public abstract class DomainServiceBase<TEntity>
    {
        protected IRepository<TEntity> repository;
        public DomainServiceBase(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }
        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }
        public virtual void Save(TEntity entity)
        {
            repository.Save(entity);

        }
        public void Delete(int id)
        {
            repository.Delete(id);
        }
        public int GetCount()
        {
            return repository.GetCount();
        }

        public abstract string GenerateCode();
        public abstract TEntity New();
        
    }
}
