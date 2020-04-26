using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasaviMedicals
{
    public class Orders
    {
        public int InvoiceId { get; set; }
        public DateTime ODate { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
