using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Encapsulation
{
    internal class Vehicle
    {
        public string Registration { get; set; }// auto generates properties. includes the get, set and creates a 
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public Driver Driver { get; set; }
        public Vehicle(string registration, string colour, string make, string model, int NoOfWheels, Driver driver)//adding drivers on the end is called Aggrigation
        {
            Registration = registration;
            Colour = colour;
            Make = make;
            Model = model;
            NoOfWheels = NoOfWheels;
            Driver = driver;
            
        }

        public override string? ToString()
        {
            return $"Reg: { Registration }\nColour: { Colour }\nMake: { Make }\nModel: { Model }\nNumber of Wheels: { NoOfWheels }\nDriver: { Driver }\n-------------------------------------------------------";
        }
    }
}
