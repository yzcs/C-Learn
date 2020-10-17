using System;

namespace CSharpLearn1
{
    class Car
    {
        public string color = "red";
        int maxSpeed;

        
        static void Main(string[] args)
        {
            Car myObj = new Car();
            //Car myObj2 = new Car();
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }


}
