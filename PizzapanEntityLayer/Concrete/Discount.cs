using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzapanEntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndingDate { get; set; }
        public int DiscountCount { get; set; }
    }
}
