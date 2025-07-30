using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Abstraction
{
    internal class Rectangle : Shape /* Implement and Inherit from shape */
    {
        public override double GetArea()
        {
            return Dim01 * Dim02;
        }

        public override double Perimeter()
        {
            return 2*(Dim01 + Dim02);
        }
    }
}
