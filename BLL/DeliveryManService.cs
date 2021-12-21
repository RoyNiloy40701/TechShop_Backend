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
    public class DeliveryManService
    {
        public static List<DeliveryManModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DeliveryMan, DeliveryManModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DeliveryManModel>>(DataAccessFactory.DeliveryManDataAccess().GetAll());
            return data;
        }
        public static List<DeliveryManModel> GetEmp(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DeliveryMan, DeliveryManModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DeliveryManModel>>(DataAccessFactory.DeliveryManDataAccess().GetEmp(id));
            return data;
        }
        public static DeliveryManModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DeliveryMan, DeliveryManModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<DeliveryManModel>(DataAccessFactory.DeliveryManDataAccess().Get(id));
            return data;
        }



        public static void Delete(int id)
        {
            DataAccessFactory.DeliveryManDataAccess().Delete(id);
        }

        public static void Add(DeliveryManModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DeliveryManModel, DeliveryMan>())).Map<DeliveryMan>(e);
            DataAccessFactory.DeliveryManDataAccess().Add(data);
        }
        public static void Edit(DeliveryManModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<DeliveryManModel, DeliveryMan>())).Map<DeliveryMan>(e);
            DataAccessFactory.DeliveryManDataAccess().Edit(data);
        }
    }
}
