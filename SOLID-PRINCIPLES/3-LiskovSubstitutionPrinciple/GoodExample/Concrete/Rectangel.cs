using SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodExample.Concrete
{
    public class Rectangel:Shape
    {
        public int Width { get; set; }
        public double RectangleArea() { return Width * Edge; }

    }
}
