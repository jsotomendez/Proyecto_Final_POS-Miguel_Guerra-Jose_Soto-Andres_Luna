using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Domain.Client
{
    public class Client{
        public Guid? ClientId { get; set; }
        public string? Identification { get; set; }
        public string? Name { get; set; }
        public double? AvailableBalance { get; set; }
    }
}
