using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Static
{
    internal static class Utilities
    {
        //public static int X { get; set; }
        //public  static  int Y { get; set; }

        private static double pi;

        public static double cmToInch(double cm)
        {
            return cm / 2.54;
        }

        static Utilities()  //This constructor is called only at the first call of the class
        {
            pi = 3.14;
        }

        public static double PI
        { 
            get
            {
                return pi; 
            }
        }
    }
}
