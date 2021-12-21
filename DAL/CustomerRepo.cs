using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo : IRepository<Customer, int>
    {
        Entities db;
        public CustomerRepo(Entities db)
        {
            this.db = db;
        }
        public void Add(Customer e)
        {
            db.Customers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = db.Customers.FirstOrDefault(e => e.CId == id);
            db.Customers.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(Customer e)
        {
            var emp = db.Customers.FirstOrDefault(em => em.CId == e.CId);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Customer Get(int id)
        {
            return db.Customers.FirstOrDefault(e => e.CId == id);
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public List<Customer> GetEmp(int id)
        {
          
            return db.Customers.Where(e => e.CId == id).ToList();
        }
        public List<Customer> GetCus(int id)
        {

            return db.Customers.Where(e => e.CId == id).ToList();
        }
    }
}
