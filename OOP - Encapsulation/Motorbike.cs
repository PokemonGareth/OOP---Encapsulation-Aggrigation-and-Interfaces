using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Encapsulation
{
    internal class Motorbike : Vehicle
    {
        //-----INHERITING-----
        //inheriting is the process of connecting two classes together.
        public Motorbike(string registration, string colour, string make, string model, Driver driver) : base(registration, colour, make, model, 2, driver)
         {
         }
    }
}
