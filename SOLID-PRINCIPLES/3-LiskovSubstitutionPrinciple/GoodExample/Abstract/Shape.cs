using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._3_LiskovSubstitutionPrinciple.GoodExample.Abstract
{
    public abstract class Shape
    {
        // In order not to contradict this principle and not to deviate from the purpose of the ancestral classes, common properties will be stored here.

        public int Id { get; set; }
        public int Edge { get; set; }
    }
}
