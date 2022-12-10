using System;
using System.Diagnostics;

namespace Operators.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;


            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);


            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num3 is {0}", num);
            Console.WriteLine("num3 is {0}", num++);
            Console.WriteLine("num3 is {0}", ++num);

            //decrement operators
            num--;
            Console.WriteLine("num3 is {0}", num);
            Console.WriteLine("num3 is {0}", num--);
            Console.WriteLine("num3 is {0}", --num);


            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            //module operator
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1 > num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);


            //conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            Console.Read();



        }
    }
}
