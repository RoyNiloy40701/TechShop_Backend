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
    public class OrderService
    {
        public static List<OrderModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderModel>>(DataAccessFactory.OrderDataAccess().GetAll());
            return data;
        }
        public static List<OrderModel> GetEmp(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderModel>>(DataAccessFactory.OrderDataAccess().GetEmp(id));
            return data;
        }
        public static List<OrderModel> GetCus(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderModel>>(DataAccessFactory.OrderDataAccess().GetCus(id));
            return data;
        }

        public static OrderModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderModel>(DataAccessFactory.OrderDataAccess().Get(id));
            return data;
        }

       

        public static void Delete(int id)
        {
            DataAccessFactory.OrderDataAccess().Delete(id);
        }

        public static void Add(OrderModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<OrderModel, Order>())).Map<Order>(e);
            DataAccessFactory.OrderDataAccess().Add(data);
        }
        public static void Edit(OrderModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<OrderModel, Order>())).Map<Order>(e);
            DataAccessFactory.OrderDataAccess().Edit(data);
        }
    }
}
