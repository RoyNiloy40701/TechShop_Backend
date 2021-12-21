using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int OId { get; set; }
        public int CId { get; set; }
        public string OrderStatus { get; set; }
        public string OrderDate { get; set; }
        public int OrderTotalCost { get; set; }
        public string OrderPayMethod { get; set; }
        public Nullable<int> EId { get; set; }
    }
}
