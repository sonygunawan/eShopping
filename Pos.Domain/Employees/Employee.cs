using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain
{
    public class Employee : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string FatherName { get; set; }
        public Employee()
        {
            BirthDate = DateTime.Now.AddYears(-25);
            Address = new Address();
        }
    }
}
