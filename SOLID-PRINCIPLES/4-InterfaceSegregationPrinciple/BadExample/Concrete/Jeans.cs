using SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadExample.Concrete
{
    public class Jeans : IProduct
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }
}
