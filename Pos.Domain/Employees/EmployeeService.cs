using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Pos.Domain
{
    public class EmployeeService : DomainServiceBase<Employee>
    {
        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {

        }
        public override string GenerateCode()
        {
            return "E" + (repository.GetCount() + 1);
        }

        public override Employee New()
        {
            return new Employee { Code = GenerateCode() };
        }

        public override void Save(Employee entity)
        {
            
                entity.Code = GenerateCode();
                repository.Save(entity);
            
        }
    }
}
