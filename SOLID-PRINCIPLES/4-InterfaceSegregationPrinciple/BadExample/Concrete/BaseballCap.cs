using SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadExample.Concrete
{
    //Just a week later, the owner of the store comes to us and tells us that they're now going to sell baseball caps. So, wanting to use the interface we already created, we implement BaseballCap:
    //But wait! Why does a baseball cap have an inseam or waist size? Those properties don't make sense for a baseball cap, but because they were defined in IProduct, BaseballCap must implement them.

   //So what's the solution? Refactor! But how?

   //Well, what properties do both BaseballCap and Jeans need? Those properties can become the new IProduct interface:
    public class BaseballCap : IProduct
    {
    public int ID { get; set; }
    public double Weight { get; set; }
    public int Stock { get; set; }
    public int Inseam { get; set; }
    public int WaistSize { get; set; }
    public int HatSize { get; set; }
}
}
