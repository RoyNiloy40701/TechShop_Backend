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
    public class CategoryService
    {
        public static List<CategoryModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CategoryModel>>(DataAccessFactory.CategoryDataAccess().GetAll());
            return data;
        }


        public static List<String> GetNames()
        {

            var data = DataAccessFactory.CategoryDataAccess().GetAll().Select(emp => emp.CategoryName).ToList();
            return data;

        }

        public static void Delete(int id)
        {
            DataAccessFactory.CategoryDataAccess().Delete(id);
        }

        public static void Add(CategoryModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>())).Map<Category>(e);
            DataAccessFactory.CategoryDataAccess().Add(data);
        }
        public static void Edit(CategoryModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>())).Map<Category>(e);
            DataAccessFactory.CategoryDataAccess().Edit(data);
        }
    }
}
