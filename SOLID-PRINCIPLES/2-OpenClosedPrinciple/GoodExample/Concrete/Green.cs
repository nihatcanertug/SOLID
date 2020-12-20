using SOLID_PRINCIPLES._2_OpenClosedPrinciple.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._2_OpenClosedPrinciple.GoodExample.Concrete
{
    public class Green : GoodTea
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 8.00;
        }
    }
}
