using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasaviMedicals
{
    public class OrderDetails
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal MRP { get; set; }
        public int Discount { get; set; }
        public decimal Total {
            get
            {
                return MRP * Quantity - MRP * Quantity * Discount / 100;
            }
        }
    }
}
