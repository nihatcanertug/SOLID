using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.BadExample.Interfaces
{
   // Let's say we are tasked with modeling a newly-opened clothing store that sells jeans. At the moment, that's all they will sell.Now we, being smart programmers, think that we should model this so that if the store wants to sell different products in the future, we can model them appropriately.So, we create an interface for the products.
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }
}
