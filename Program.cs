using System;

namespace Monostate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monostate design pattern example");
            Console.WriteLine("Monostate is a creational design pattern that lets you ensure that a class has only one instance.");
            Console.WriteLine("Monostate pattern attempts to hide the fact that a class is only operating on a single instance of data by using static data members.");

            var person1 = new Monostate.Monostate
            {
                FirstName = "Stuart",
                LastName = "Shepherd",
                Age = 43
            };

            var person2 = new Monostate.Monostate();
            Console.WriteLine(person2);
        }
    }
}
