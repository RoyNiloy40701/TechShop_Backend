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
    public class ShopService
    {
        public static List<ShopModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Shop, ShopModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ShopModel>>(DataAccessFactory.ShopDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {

            var data = DataAccessFactory.ShopDataAccess().GetAll().Select(emp => emp.ShopName).ToList();
            return data;

        }

        public static void Delete(int id)
        {
            DataAccessFactory.ShopDataAccess().Delete(id);
        }

        public static void Add(ShopModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ShopModel, Shop>())).Map<Shop>(e);
            DataAccessFactory.ShopDataAccess().Add(data);
        }
        public static void Edit(ShopModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ShopModel, Shop>())).Map<Shop>(e);
            DataAccessFactory.ShopDataAccess().Edit(data);
        }
    }
}
