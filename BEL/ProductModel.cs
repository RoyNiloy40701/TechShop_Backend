using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProductModel
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public int PBasicPrice { get; set; }
        public int PCategoryId { get; set; }
        public int PStock { get; set; }
        public int PDiscount { get; set; }
        public string PDescription { get; set; }
        public byte[] PPicture { get; set; }
     
        public string Review { get; set; }
        public int PShopId { get; set; }
        public Nullable<int> MId { get; set; }
        public Nullable<int> PSoldQuantity { get; set; }

        public Nullable<int> Rating { get; set; }
    }
}
