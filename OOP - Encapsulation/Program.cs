using System;

namespace OOP___Encapsulation
{
    public class Program {
        static void Main(string[] args)
        {
            //-----OLD WAY-----
            /*
            Car Car1 = new Car("ABC123", "Red", "Ford", "Fiesta", 4);
            Car1.setRegistration( "-1");
            Car1.setColour("Blue");
            Car1.setMake("Sazuki");
            Car1.setModel("Grand Vitara");
            Car1.setWheels(4);
            */

            //Console.WriteLine($"Reg: { Car1.getRegistration() }\nColour: { Car1.getColour() }\nMake: { Car1.getMake }");

            //-----NEW WAY----- (using vehicles)
            //Vehicle BMW = new Vehicle("123ABC", "Blue", "BMW", "V500", 4); //commented out as "Driver" was added later and made code stop working
            //Console.WriteLine(BMW.NoOfWheels);


            //-----INHERITING FROM CLASSES-----

            //Car cl = new Car("asd123", "red", "vw", "v1");

            //Console.WriteLine(cl.Registration);

            //Motorbike bk = new Motorbike("bike12", "grey", "Fast", "500");

            //Console.WriteLine(bk.ToString());


            //-----AGGRIGATION-----
            /*
            Driver dv1 = new Driver("John Doe", 20, "1975853", "1 Unknown rd");//creates a driver
            Car cr1 = new Car("john603", "Green", "Ford Fiesta", "Zetec", dv1);//this adds a driver to the car

            Console.WriteLine(cr1.ToString());

            Driver dv2 = new Driver("Jack Doe", 20, "1975854", "1 Unknown rd");
            Motorbike bk2 = new Motorbike("Jack603", "Red", "Firrari", "2000", dv2);
            */

            //-----POLYMORPHISM-----
            Driver dv3 = new Driver("July Doe", 50, "1709867", "1 Unknown rd");//new drivers
            Driver dv4 = new Driver("Joe Doe", 51, "1690756", "1 Unknown rd");

            Car cr3 = new Car("july603", "Yellow", "BMW", "500", dv3);//new cars
            Car cr4 = new Car("Joey603", "Blue", "BMW", "500", dv4);

            Motorbike mb3 = new Motorbike("July603", "Yellow", "Firrari", "2000", dv3);//new motorbikes
            Motorbike mb4 = new Motorbike("Joey603", "Blue", "Ford", "10", dv4);


            //creates bookings                                                     //YYYY, MM, DD, Hr, Min, Sec
            Booking b1 = new Booking(cr3, "MOT", new DateTime(2022, 12, 15, 12, 0, 0));//created a booking for car 3
            //Console.WriteLine(b1.ToString());
            Booking b2 = new Booking(cr4, "Repair", new DateTime(2022, 12, 15, 14, 30, 10));


            //adds to the garages
            Garage g1 = new Garage("Garethges Co", "1 Monument street");//creates new garage

            g1.Bookings.Add(b1);//adds bookings to garage
            g1.Bookings.Add(b2);

            foreach (var booking in g1.Bookings)
            {
                Console.WriteLine(booking.ToString());
                Console.WriteLine("------------------------------------------------------------------------\n");
            }
        }
    }
}