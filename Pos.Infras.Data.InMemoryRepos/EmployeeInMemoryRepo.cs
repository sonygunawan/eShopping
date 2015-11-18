using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.InMemoryRepos
{
    public class EmployeeInMemoryRepo : IEmployeeRepository
    {

        public IEnumerable<Employee> GetByHomeCountry(string homeCountry)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            return Samples.Suyama;
        }

        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee> { Samples.Suyama, Samples.Nancy, };
        }

        public int GetCount()
        {
            return 10;
        }

        public void Save(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
