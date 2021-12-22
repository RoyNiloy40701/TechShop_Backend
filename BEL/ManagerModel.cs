using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ManagerModel
    {
        public int MId { get; set; }
        public string MName { get; set; }
        public string MPassword { get; set; }
        public string MEmail { get; set; }
        public string MAddress { get; set; }
        public string MPhone { get; set; }
        public byte[] MPicture { get; set; }
        public int MBasicSalary { get; set; }
        public int MFastiveBonus { get; set; }
        public int MPerformBonus { get; set; }
    }
}
