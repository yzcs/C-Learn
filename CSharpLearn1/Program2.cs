using System;
namespace CSharpLearn1
{
    class Program2
    {
        public static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1989, 180);


            Car Opel = new Car("Astra", "White", 2005, 200);
            

            Console.WriteLine(Ford.model+" "+Ford.color+" "+Ford.year+" "+Ford.maxSpeed);
            Console.WriteLine(Opel.year +" " +Opel.color+" "+Opel.year +" "+Opel.maxSpeed);
            Ford.fullThrottle();
        }
        
        

    }
}
