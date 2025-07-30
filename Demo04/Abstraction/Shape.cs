using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Abstraction
{
    //Abstract Class: Partial class [Not fully implemented class]
    //Concert Class : Fully implemented class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }
         
        public abstract double GetArea();
        public abstract double Perimeter();
         
    }
}
