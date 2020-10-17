using System;

namespace CSharpLearn1
{
    class Car
    {
        public string color;
        public string model;
        public int year;
        public int maxSpeed;
        public Car(string modelName, string modelColor, int modelYear, int modelMSpeed)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
            maxSpeed = modelMSpeed;
        }
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        
        
       /*static void Main(string[] args)
        {
            Car myObj = new Car();
            //Car myObj2 = new Car();
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj.maxSpeed);
        }*/
    }


}
