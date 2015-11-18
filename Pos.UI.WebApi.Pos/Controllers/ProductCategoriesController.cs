using Pos.Domain;
using Pos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pos.UI.WebApi.Pos.Controllers
{
    public class ProductCategoriesController : ApiControllerBase<ProductCategories>
    {
        public ProductCategoriesController(ProductCategoriesService service) 
            :base(service)
        {

        }
	}
}