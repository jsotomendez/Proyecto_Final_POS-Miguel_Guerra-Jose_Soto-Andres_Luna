using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Domain.Order
{
    public class Order{
        public Guid OrderId { get; set; }
        public int Units { get; set; }
        public Double ProductValue { get; set; }
        public Double Total { get; set; }
    }
}
