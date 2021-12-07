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
    public class ProductService
    {
        public static List<ProductModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(DataAccessFactory.ProductDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {

            var data = DataAccessFactory.ProductDataAccess().GetAll().Select(emp => emp.PName).ToList();
            return data;

        }

        public static void Delete(int id)
        {
            DataAccessFactory.ProductDataAccess().Delete(id);
        }

        public static void Add(ProductModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>())).Map<Product>(e);
            DataAccessFactory.ProductDataAccess().Add(data);
        }
        public static void Edit(ProductModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>())).Map<Product>(e);
            DataAccessFactory.ProductDataAccess().Edit(data);
        }
    }
}
