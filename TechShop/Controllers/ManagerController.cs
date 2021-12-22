using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TechShop.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ManagerController : ApiController
    {
        [Route("api/Manager/All")]
        [HttpGet]
        public List<ManagerModel> GetAll()
        {
            return ManagerService.GetAll();
        }

        [Route("api/Manager/get/{id}")]
        [HttpGet]
        public ManagerModel Get(int id)
        {
            return ManagerService.Get(id);
        }


        [Route("api/Manager/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            ManagerService.Delete(id);
        }

        [Route("api/Manager/add")]
        [HttpPost]

        public void Add(ManagerModel e)
        {
            ManagerService.Add(e);
        }

        [Route("api/Manager/edit")]
        [HttpPost]

        public void Edit(ManagerModel e)
        {
            ManagerService.Edit(e);
        }

    }
}
