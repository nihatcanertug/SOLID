using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._2_OpenClosedPrinciple.BadExample
{
    public enum TeaType
    {
        Green, Black, Herbal
    }
    public class BadTea
    {
        public double GetTotalPrice(double amount, TeaType teaType)
        {
            double totalPrice = 0;
            if (teaType == TeaType.Green)
            {
                totalPrice += amount * 8.00;

            }
            else if (teaType == TeaType.Black)
            {
                totalPrice += amount * 11.00;

            }
            else if (teaType == TeaType.Herbal)
            {
                totalPrice += amount * 14.00;
            }
            return totalPrice;
        }
    }
}
