using Pos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infras.Data.EFRepositories
{
    public class EmployeeEFRepository : EFRepositoryBase<Employee>, IEmployeeRepository
    {
        //ctor
        public EmployeeEFRepository(PosContext posContext): base(posContext)
        {

        }
        public EmployeeEFRepository() : this(new PosContext())
        {

        }
        public IEnumerable<Employee> GetByHomeCountry(string homeCountry)
        {
            return data.Where(p => p.Address.Country == homeCountry).ToList();
        }

        protected override DbSet<Employee> GetEFSet()
        {
            return ctx.Employees;
        }
    }
}
