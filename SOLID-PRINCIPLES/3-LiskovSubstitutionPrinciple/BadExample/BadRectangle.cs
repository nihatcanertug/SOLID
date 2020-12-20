using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.BadExample
{

    //this class is Parent class
    public class BadRectangle
    {
        // In our bad scenario, we marked the members of our BadRectangle class as virtual so we can override them in subclasses.
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
