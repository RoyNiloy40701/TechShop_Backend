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
    public class OrderController : ApiController
    {
        [Route("api/Order/All")]
        [HttpGet]
        public List<OrderModel> GetAll()
        {
            return OrderService.GetAll();
        }

         [Route("api/Order/get/{id}")]
          [HttpGet]
          public OrderModel Get(int id)
          {
              return OrderService.Get(id);
          }

        
        [Route("api/Order/get/Emp/{id}")]
        [HttpGet]
        public List<OrderModel> GetEmp(int id)
        {
            return OrderService.GetEmp(id);
        }

        [Route("api/Order/get/Cus/{id}")]
        [HttpGet]
        public List<OrderModel> GetCus(int id)
        {
            return OrderService.GetCus(id);
        }

        [Route("api/Order/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            OrderService.Delete(id);
        }

        [Route("api/Order/add")]
        [HttpPost]

        public void Add(OrderModel e)
        {
            OrderService.Add(e);
        }

        [Route("api/Order/edit")]
        [HttpPost]

        public void Edit(OrderModel e)
        {
            OrderService.Edit(e);
        }
    }
}
