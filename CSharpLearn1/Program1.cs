using System;
using System.Collections.Generic;
using System.Net;
using System.Text;


namespace CSharpLearn1
{   
    class Person
    {
        private string name;
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
    }
    class Program1
    {
        public static void Main(string [] args)
        {
            Person myPerson = new Person();
            myPerson.Name = "Jane";
            Console.WriteLine(myPerson.Name);

        }
       
    }
}

