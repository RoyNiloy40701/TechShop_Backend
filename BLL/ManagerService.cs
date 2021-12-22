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
    public class ManagerService
    {
        public static List<ManagerModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ManagerModel>>(DataAccessFactory.ManagerDataAccess().GetAll());
            return data;
        }
        public static List<ManagerModel> GetEmp(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ManagerModel>>(DataAccessFactory.ManagerDataAccess().GetEmp(id));
            return data;
        }
        public static List<ManagerModel> GetCus(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ManagerModel>>(DataAccessFactory.ManagerDataAccess().GetCus(id));
            return data;
        }

        public static ManagerModel Get(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Manager, ManagerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ManagerModel>(DataAccessFactory.ManagerDataAccess().Get(id));
            return data;
        }



        public static void Delete(int id)
        {
            DataAccessFactory.ManagerDataAccess().Delete(id);
        }

        public static void Add(ManagerModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ManagerModel, Manager>())).Map<Manager>(e);
            DataAccessFactory.ManagerDataAccess().Add(data);
        }
        public static void Edit(ManagerModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ManagerModel, Manager>())).Map<Manager>(e);
            DataAccessFactory.ManagerDataAccess().Edit(data);
        }
    }
}
