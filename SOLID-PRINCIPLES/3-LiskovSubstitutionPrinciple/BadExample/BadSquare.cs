using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.BadExample
{
    public class BadSquare:BadRectangle
    {

        int _height;
        int _width;

        public override int Height { get =>_height; set => _height = value; }

        public override int Width { get => _width; set => _width = value; }
    }
}
