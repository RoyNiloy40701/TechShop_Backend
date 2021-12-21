using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CustomerModel
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CPassword { get; set; }
        public string CEmail { get; set; }
        public string CAddress { get; set; }
        public string CPhone { get; set; }
        public byte[] CPicture { get; set; }
        public Nullable<int> VouId { get; set; }
    }
}
