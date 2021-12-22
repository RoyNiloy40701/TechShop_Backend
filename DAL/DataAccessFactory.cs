using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Entities db;   
        
        static DataAccessFactory()
        {
            db = new Entities();
        }

        public static IRepository<Employee,int> EmployeeDataAccess(){

            return new EmployeeRepo(db);
        }

        public static IRepository<Product, int> ProductDataAccess()
        {

            return new ProductRepo(db);
        }

        public static IRepository<Category, int> CategoryDataAccess()
        {

            return new CategoryRepo(db);
        }
        public static IRepository<Shop, int> ShopDataAccess()
        {

            return new ShopRepo(db);
        }
        public static IRepository<Order, int> OrderDataAccess()
        {

            return new OrderRepo(db);
        }
    
        public static IRepository<DeliveryMan, int> DeliveryManDataAccess()
        {

            return new DeliveryManRepo(db);
        }
        public static IRepository<Customer, int> CustomerDataAccess()
        {

            return new CustomerRepo(db);
        }
        public static IRepository<Manager, int> ManagerDataAccess()
        {

            return new ManagerRepo(db);
        }

    }
}
