using Demo04.Abstraction;
using Demo04.Mapping;
using Demo04.Operator_Overloading;
using Demo04.Partial;
using Demo04.Sealed;
using Demo04.Static;

namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            //Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 20 };
            //Console.WriteLine(rectangle.Perimeter());
            //Console.WriteLine(rectangle.GetArea());
            #endregion

            #region Operator Overloading +, -
            //Complex complex1 = new Complex() { Real = 2, Imag = 5};
            //Complex complex2 = new Complex() { Real = 3, Imag = 7 };
            //Complex complex3 = complex1 + complex2;

            //Console.WriteLine(complex1);
            //Console.WriteLine(complex2);
            //Console.WriteLine(complex3);

            #endregion

            #region Operator Overloading ++, --

            //Complex complex1 = new Complex() { Real = 2, Imag = 5 };

            //Console.WriteLine(complex1++);
            //Console.WriteLine(--complex1);

            #endregion

            #region Operator Overloading >, <
            //Complex complex1 = new Complex() { Real = 7, Imag = 3 };
            //Complex complex2 = new Complex() { Real = 5, Imag = 3 };

            //if (complex1 > complex2)
            //{
            //    Console.WriteLine("complex1 is greater than complex2");
            //}

            //else if(complex1 < complex2) 
            //{
            //    Console.WriteLine("complex1 is  smaller than complex2");
            //}

            //else
            //{
            //    Console.WriteLine("complex1 = complex2");
            //}
            #endregion

            #region Operator Overloading [Casting]
            //Complex complex = new Complex()
            //{ 
            //    Real = 2,
            //    Imag = 3
            //};

            //int num = complex;

            //Console.WriteLine((string)complex);
            //Console.WriteLine(num);
            #endregion

            #region Manual Mapping
            //User user = new User(); //From database

            ////Manaual Mapping
            //UserDto userDto1 = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    PhoneNumber = user.PhoneNumber
            //};
            #endregion

            #region Static
            //Console.WriteLine(Utilities.cmToInch(254));
            //Console.WriteLine(Utilities.PI);
            #endregion

            #region Sealed
            //Sealed : C# Keyword [Class - Method - Property]
            #endregion

            #region Partial
            Employee e = new Employee();
            #endregion
        }
    }
}
