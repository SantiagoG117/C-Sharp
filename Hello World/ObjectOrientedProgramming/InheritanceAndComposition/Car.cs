using System;

namespace ObjectOrientedProgramming.InheritanceAndComposition
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
        
        
    }
}