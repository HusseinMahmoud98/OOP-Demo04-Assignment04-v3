using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Sealed
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public override int A { get => base.A; set => base.A = value; }
        public override sealed void MyFun()
        {
            base.MyFun();
        }
    }
}
