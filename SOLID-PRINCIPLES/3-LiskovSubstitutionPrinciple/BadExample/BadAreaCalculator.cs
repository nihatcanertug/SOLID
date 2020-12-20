using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.BadExample
{
    // Here we are against the LSP principle when our BadSquare.cs class inherits from our BadRetangle class. Why? because this principle tells us that the lower classes should be movable in the upper classes.
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRectangle badRectangle)
        {
            return badRectangle.Height * badRectangle.Width;

        }

        public static double CalculateArea(BadSquare badSquare)
        {


            // We were in the opposite, why? Because it cannot be the length of the frame because it inherits unnecessary features from the wrong ancestor.
            return badSquare.Height * badSquare.Width;

        }


    }
}
