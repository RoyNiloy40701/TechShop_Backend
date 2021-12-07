﻿using BEL;
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
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
       
        [Route("api/Employee/All")]
        [HttpGet]
        public List<EmployeeModel>GetAll()
        {
            return EmployeeService.GetAll();
        }

        [Route("api/Employee/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return EmployeeService.GetNames();
        }

        [Route("api/Employee/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            EmployeeService.Delete(id);
        }


        [Route("api/Employee/add")]
        [HttpPut]

        public void Add(EmployeeModel e)
        {
            EmployeeService.Add(e);
        }

        [Route("api/Employee/edit")]
        [HttpPost]

        public void Edit(EmployeeModel e)
        {
            EmployeeService.Edit(e);
        }
    }
}