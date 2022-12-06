using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Encapsulation
{
    internal class Driver
    {
        //-----AGGRIGATION-----
        //Aggrigation is a "Has a" relationship. e.g. "a car has a driver"
        public string Name { get; set; }// auto generates properties. includes the get, set and creates a 
        public int Age { get; set; }
        public string LicenseNumber { get; set; }
        public string Address { get; set; }
        public Driver(string name, int age, string licensenumber, string address)
        {
            Name = name;
            Age = age;
            LicenseNumber = licensenumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"License: { LicenseNumber }\nName: { Name }\nAge: { Age }\nAddress: { Address }\n";
        }
    }
}
