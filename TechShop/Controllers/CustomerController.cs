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
    public class CustomerController : ApiController
    {
        [Route("api/Customer/All")]
        [HttpGet]
        public List<CustomerModel> GetAll()
        {
            return CustomerService.GetAll();
        }


        [Route("api/Customer/get/{id}")]
        [HttpGet]
        public CustomerModel Get(int id)
        {
            return CustomerService.Get(id);
        }


        [Route("api/Customer/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CustomerService.GetNames();
        }


        [Route("api/Customer/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            CustomerService.Delete(id);
        }


        [Route("api/Customer/add")]
        [HttpPost]

        public void Add(CustomerModel e)
        {
            CustomerService.Add(e);
        }

        [Route("api/Customer/edit")]
        [HttpPost]

        public void Edit(CustomerModel e)
        {
            CustomerService.Edit(e);
        }
    }
}
