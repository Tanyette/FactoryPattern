using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {

        public Motorcycle() 
        {
            Console.WriteLine("Building a new Motorcycle!\n");
        }
        

        public void Drive() 
        {
            Console.WriteLine("I'm Driving my motorcycle!\n");
        }

    }
}
