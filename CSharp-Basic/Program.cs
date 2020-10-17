using System;

namespace CSharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            //char myCChar = (char)myInt;

            long myLong = 1000000000000000;

            float myFloat = 1.2F;
            double myDouble = 1.234;
            int myCInt = (int)myDouble;
            char myChar = 'd';
            bool myBool = true;
            string myString = "Hellow World";
            Console.WriteLine(myInt);
            Console.WriteLine(myLong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);
            Console.WriteLine(myString);
            Console.WriteLine(myCInt);
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToString(myBool));
            /*Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hellow " + name + " You are " + age + " Years Old!");*/
            int num1 = 2;
            int num2 = 10;
            int addNum = num1 + num2;
            Console.WriteLine(addNum);
            int subNum = num2 - num1;
            Console.WriteLine(subNum);
            int mulNum = num1 * num2;
            Console.WriteLine(mulNum);
            int divNum = num2 / num1;
            Console.WriteLine(divNum);
            int molNum = num2 % num1;
            Console.WriteLine(molNum);
            int x=1;
            x++;
            Console.WriteLine(x);
            int x1 = 1;
            x1 += 5;
            Console.WriteLine(x1);
            int x2 = 5;
            x2--;
            Console.WriteLine(x2);
            int x3 = 5;
            x3 -= 3;
            Console.WriteLine(x3);
            int x4 = 4;
            x4 *= 5;
            Console.WriteLine(x4);
            int x5 = 5;
            x5 /= 3;
            Console.WriteLine(Convert.ToDecimal(x5));
            int x6 = 5;
            x6 %= 3;
            Console.WriteLine(x6);
            Console.WriteLine(Math.Max(1, 5));
            Console.WriteLine(Math.ScaleB(3, 8));

            







            
        }
    }
}
