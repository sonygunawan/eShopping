using Brain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Pos.UI.WebApi.Pos.Controllers
{
    public class ApiControllerBase<TEntity> : ApiController
    {
        protected DomainServiceBase<TEntity> service;
        public ApiControllerBase(DomainServiceBase<TEntity> service)
        {
            this.service = service;
        }
        public IEnumerable<TEntity> Get()
        {
            return service.GetAll();
        }

        public TEntity Get(int Id)
        {
            return Id == 0 ? service.New() : service.GetById(Id);
        }

        public void Post(TEntity entity)
        {
            service.Save(entity);
        }
    }
}