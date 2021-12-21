using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo : IRepository<Category, int>
    {

        Entities db;
        public CategoryRepo(Entities db)
        {
            this.db = db;
        }

        public void Add(Category e)
        {
            db.Categories.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Categories.FirstOrDefault(e => e.CategoryId == id);
            db.Categories.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(Category e)
        {
            var emp = db.Categories.FirstOrDefault(em => em.CategoryId == e.CategoryId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Category Get(int id)
        {
            return db.Categories.FirstOrDefault(e => e.CategoryId == id);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
        public List<Category> GetEmp(int id)
        {
             return db.Categories.ToList();
        }
    }
}
