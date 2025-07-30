using Assignemnt04.First_Project;
using Assignemnt04.Second_Project;

namespace Assignemnt04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Project01
            /* 1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
             *
             * 2. Define All Required Constructors to Produce this output:
             * Duration D1 =new  Duration (1,10,15);
             * D1.ToString();
             * Output: Hours: 1, Minutes :10, Seconds :15
             * Duration D1 =new Duration (3600);
             * D1.ToString();
             * Output: Hours: 1, Minutes :0, Seconds :0
             * Duration D2 =new Duration (7800);
             * D2.ToString();
             * Output: Hours: 2, Minutes :10, Seconds :0
             * Duration D3 =new Duration (666);
             * D3.ToString();
             * Output: Minutes :11, Seconds :6
             * 
             * 3. Implement All required Operators overloading to enable this Code:
             *    D3=D1+D2
             *    D3=D1 + 7800
             *    D3=666+D3
             *    D3= ++D1 (Increase One Minute)
             *    D3 = --D2 (Decrease One Minute)
             *    D1= D1 -D2
             *    If (D1>D2) */

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); //Hours: 1, Minutes: 10, Seconds: 15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); //Hours: 1, Minutes: 0, Seconds: 0

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); //Hours: 2, Minutes: 10, Seconds: 0

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString()); //Hours: 0, Minutes: 11, Seconds: 6

            Console.WriteLine("===========================================================================================");

            Console.WriteLine(D1+D2); //Hours: 2, Minutes: 0, Seconds: 15
            Console.WriteLine(D1+7800); //Hours: 3, Minutes: 10, Seconds: 15
            Console.WriteLine(666+D3); //Hours: 2, Minutes: 11, Seconds: 6

            Console.WriteLine("===========================================================================================");

            D3 = ++D1;
            Console.WriteLine(D1); //Hours: 1, Minutes: 1, Seconds: 15

            D3 = --D1;
            Console.WriteLine(D1);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            if (D1>D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }

            else
            {
                Console.WriteLine("D1 is not greater than D2");
            }

            #endregion

            #region Project02
             double num1, num2;

            do
            {
                Console.WriteLine("Enter the first number :");
            }
            while (!double.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Enter the first number :");
            }
            while (!double.TryParse(Console.ReadLine(), out num2));

            Console.WriteLine($"{num1} + {num2} = {Maths.Add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {Maths.Subtract(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {Maths.Multiply(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {Maths.Divide(num1, num2)}");

            #endregion
        }

    }
}
