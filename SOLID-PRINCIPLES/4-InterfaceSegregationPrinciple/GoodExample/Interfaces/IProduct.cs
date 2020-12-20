using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._4_InterfaceSegregationPrinciple.GoodExample.Interfaces
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
    }
}
