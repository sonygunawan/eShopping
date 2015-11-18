using Pos.Domain;
using Pos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pos.UI.WebApi.Pos.Controllers
{
    public class SaleController : ApiControllerBase<Sale>
    {
        public SaleController(SaleService service) : base(service)
        {
        }
    }
}