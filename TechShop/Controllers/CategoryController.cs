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
    public class CategoryController : ApiController
    {
      
            [Route("api/Category/All")]
            [HttpGet]
            public List<CategoryModel> GetAll()
            {
                return CategoryService.GetAll();
            }

            [Route("api/Category/Names")]
            [HttpGet]
            public List<string> GetNames()
            {
                return CategoryService.GetNames();
            }

            [Route("api/Category/delete/{id}")]
            [HttpPost]
            public void Delete(int id)
            {
                CategoryService.Delete(id);
            }


            [Route("api/Category/add")]
            [HttpPut]

            public void Add(CategoryModel e)
            {
                CategoryService.Add(e);
            }

            [Route("api/Category/edit")]
            [HttpPost]

            public void Edit(CategoryModel e)
            {
                CategoryService.Edit(e);
            }
        }
 }

