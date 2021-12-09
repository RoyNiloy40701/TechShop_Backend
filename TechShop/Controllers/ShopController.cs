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
    public class ShopController : ApiController
    {
        [Route("api/Shop/All")]
        [HttpGet]
        public List<ShopModel> GetAll()
        {
            return ShopService.GetAll();
        }

        [Route("api/Shop/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ShopService.GetNames();
        }

        [Route("api/Shop/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            ShopService.Delete(id);
        }

        [Route("api/Shop/add")]
        [HttpPut]

        public void Add(ShopModel e)
        {
            ShopService.Add(e);
        }

        [Route("api/Shop/edit")]
        [HttpPost]

        public void Edit(ShopModel e)
        {
            ShopService.Edit(e);
        }
    }
}
