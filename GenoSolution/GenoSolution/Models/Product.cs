using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenoSolution.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public DateTime DeliveryOn { get; set; }
    }
}
