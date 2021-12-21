using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerService
    {
        public static List<CustomerModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer , CustomerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CustomerModel>>(DataAccessFactory.CustomerDataAccess().GetAll());
            return data;
        }
        public static List<CustomerModel> GetEmp(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CustomerModel>>(DataAccessFactory.CustomerDataAccess().GetEmp(id));
            return data;
        }
        public static List<String> GetNames()
        {

            var data = DataAccessFactory.CustomerDataAccess().GetAll().Select(emp => emp.CName).ToList();
            return data;

        }

        public static CustomerModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<CustomerModel>(DataAccessFactory.CustomerDataAccess().Get(id));
            return data;
        }



        public static void Delete(int id)
        {
            DataAccessFactory.CustomerDataAccess().Delete(id);
        }

        public static void Add(CustomerModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CustomerModel, Customer>())).Map<Customer>(e);
            DataAccessFactory.CustomerDataAccess().Add(data);
        }
        public static void Edit(CustomerModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CustomerModel, Customer>())).Map<Customer>(e);
            DataAccessFactory.CustomerDataAccess().Edit(data);
        }
    }
}
