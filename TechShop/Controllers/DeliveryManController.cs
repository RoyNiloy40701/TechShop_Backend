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
    public class DeliveryManController : ApiController
    {
        [Route("api/DeliveryMan/All")]
        [HttpGet]
        public List<DeliveryManModel> GetAll()
        {
            return DeliveryManService.GetAll();
        }

        [Route("api/Order/get/{id}")]
          [HttpGet]
          public OrderModel Get(int id)
          {
              return OrderService.Get(id);
          }


        [Route("api/DeliveryMan/get/emp/{id}")]
        [HttpGet]
        public List<DeliveryManModel> GetEmp(int id)
        {
            return DeliveryManService.GetEmp(id);
        }

        [Route("api/DeliveryMan/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            DeliveryManService.Delete(id);
        }

        [Route("api/DeliveryMan/add")]
        [HttpPost]

        public void Add(DeliveryManModel e)
        {
            DeliveryManService.Add(e);
        }

        [Route("api/DeliveryMan/edit")]
        [HttpPost]

        public void Edit(DeliveryManModel e)
        {
            DeliveryManService.Edit(e);
        }
    }
}
