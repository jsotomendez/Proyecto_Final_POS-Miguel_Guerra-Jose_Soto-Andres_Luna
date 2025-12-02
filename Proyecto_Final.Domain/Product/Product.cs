using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Domain.Product
{
    public class Product{
        public Guid ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public double ProductValue { get; set; }
    }
}
