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
    public class ProductController : ApiController
    {
        [Route("api/Product/All")]
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return ProductService.GetAll();
        }

        [Route("api/Product/get/{id}")]
        [HttpGet]
        public ProductModel Get(int id)
        {
            return ProductService.Get(id);
        }

        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ProductService.GetNames();
        }

        [Route("api/Product/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            ProductService.Delete(id);
        }

        [Route("api/Product/add")]
        [HttpPut]

        public void Add(ProductModel e)
        {
            ProductService.Add(e);
        }

        [Route("api/Product/edit")]
        [HttpPost]

        public void Edit(ProductModel e)
        {
            ProductService.Edit(e);
        }
    }
}
