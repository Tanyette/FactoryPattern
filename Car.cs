using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car!");
        }

      
        
           

        public void Drive()
        {
            Console.WriteLine($"I'm driving my car! ");
        }






    }
}
