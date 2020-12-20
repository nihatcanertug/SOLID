
using SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodExample.Concrete
{
    //Each class now has only properties that they need.Now we are upholding the Interface Segregation Principle!
    public class BaseballCap : IProduct, IHat
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int HatSize { get; set; }
    }
}
