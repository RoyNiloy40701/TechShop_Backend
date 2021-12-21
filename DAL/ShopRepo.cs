using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopRepo : IRepository<Shop, int>
    {
        Entities db;
        public ShopRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(Shop e)
        {
            db.Shops.Add(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var emp = db.Shops.FirstOrDefault(e => e.ShopId == id);
            db.Shops.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(Shop e)
        {
            var emp = db.Shops.FirstOrDefault(em => em.ShopId == e.ShopId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Shop Get(int id)
        {
            return db.Shops.FirstOrDefault(e => e.ShopId == id);
        }

        public List<Shop> GetAll()
        {
            return db.Shops.ToList();
        }
        public List<Shop> GetEmp(int id)
        {
            return db.Shops.ToList();
        }
        public List<Shop> GetCus(int id)
        {
            return db.Shops.ToList();
        }
    }
}
