using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo : IRepository<Order, int>
    {
        Entities db;
        public OrderRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(Order e)
        {
            db.Orders.Add(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var emp = db.Orders.FirstOrDefault(e => e.OId == id);
            db.Orders.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(Order e)
        {
            var emp = db.Orders.FirstOrDefault(em => em.OId == e.OId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Order Get(int id)
        {
            return db.Orders.FirstOrDefault(e => e.EId == id);
        }
        public List<Order> GetEmp(int id )
        {
            return db.Orders.Where(e => e.EId == id && (e.OrderStatus.ToLower()!="pending")).ToList();
        }
        public List<Order>GetCus(int id)
        {
            return db.Orders.Where(e => e.CId == id).ToList();
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }


    }
}
