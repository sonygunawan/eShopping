using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain.Commons
{
    public interface IRepository<TEntity>
    {

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        int GetCount();
        void Save(TEntity entity);

        void Delete(int id);
    }
}
