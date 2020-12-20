
using SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class Jeans : IProduct, IPants
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }
}
