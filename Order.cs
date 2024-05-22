using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L8
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Castomer { get; set; }
        public List<OrderProduct> Products {  get; set; }
    }
}
