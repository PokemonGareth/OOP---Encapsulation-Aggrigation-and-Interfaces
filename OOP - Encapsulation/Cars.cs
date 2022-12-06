using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is the old way of doin things, look a Vehicles for the more modern approach

namespace OOP___Encapsulation
{
    /*
    internal class Car
    {
        /*
        public string Registration; //Public fields - anyone 
        public string Colour;
        public string Make;
        public string Model;
        public int NoOfWheels;
        *
        private string Registration; //Private fields - can' be accessed to update.
        private string Colour;
        private string Make;
        private string Model;
        private int NoOfWheels;

        public Car(string registration, string colour, string make, string model, int noOfWheels)// Constructor
        {
            Registration = registration;
            Colour = colour;
            Make = make;
            Model = model;
            NoOfWheels = noOfWheels;
        }
        public void setRegistration(string registration)//used to update a private field (also known as a Setter/Mutator method)
        {
            if (registration.Length == 6)
            {
                this.Registration = registration;
            }
        }

        public string getRegistration()//used to get the private field ready for use. (also known as a Getter/Accessor method)
        {
            return this.Registration;
        }

        public void setColour(string colour)
        {
            this.Colour = colour;
        }

        public string getColour()
        {
            return this.Colour;
        }

        public void setMake(string make)
        {
            this.Make = make;
        }

        public string getMake()
        {
            return this.Make;
        }

        public void setModel(string model)
        {
            this.Model = model;
        }

        public string getModel()
        {
            return this.Model;
        }

        public void setWheels(int number)
        {
            if (number < 6 && number > 0)//adding some validation.
            {
                this.NoOfWheels = number;
            }
        }
        public int geWheelsl()
        {
            return this.NoOfWheels;
        }

        public void ToString(string details)
        {
            foreach (int d in details)
            {
                Console.WriteLine(d);
            }
        }
    }
    */


    //inheriting things from vehicles tab
    internal class Car : Vehicle
    {
        public Car(string registration, string colour, string make, string model, Driver driver) : base(registration, colour, make, model, 4, driver)
        {
        }
    }
}
