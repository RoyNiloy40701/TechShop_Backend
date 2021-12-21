using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class DeliveryManModel
    {
        public int Did { get; set; }
        public string DName { get; set; }
        public string DEmail { get; set; }
        public string DPassword { get; set; }
        public string DPhone { get; set; }
        public string DStatus { get; set; }
        public int DOrderid { get; set; }
        public int DSalay { get; set; }
        public string DSchedule { get; set; }
        public Nullable<int> EId { get; set; }
    }
}
