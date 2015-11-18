using Pos.Domain;
using Pos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pos.UI.WebApi.Pos.Controllers
{
    public class EmployeeController : ApiControllerBase<Employee>
    {
        public EmployeeController(EmployeeService service) : base(service)
        {
            //service = new EmployeeService(new EmployeeEFRepo());
        }


    }
}