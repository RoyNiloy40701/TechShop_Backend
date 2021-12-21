using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliveryManRepo : IRepository<DeliveryMan, int>
    {

        Entities db;
        public DeliveryManRepo(Entities db)
        {
            this.db = db;
        }
       
        public void Add(DeliveryMan e)
        {
            db.DeliveryMen.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
             var emp = db.DeliveryMen.FirstOrDefault(e => e.Did == id);
            db.DeliveryMen.Remove(emp);
            db.SaveChanges();
        }

        public void Edit(DeliveryMan e)
        {
            var emp = db.DeliveryMen.FirstOrDefault(em => em.Did==e.Did);
            db.Entry(emp).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public DeliveryMan Get(int id)
        {
            return db.DeliveryMen.FirstOrDefault(e => e.EId == id);
        }

        public List<DeliveryMan> GetAll()
        {
            return db.DeliveryMen.ToList();
        }

        public List<DeliveryMan> GetEmp(int id)
        {
            return db.DeliveryMen.Where(e => e.EId == id).ToList();
        }
        public List<DeliveryMan> GetCus(int id)
        {
            return db.DeliveryMen.Where(e => e.EId == id).ToList();
        }
    }
}
