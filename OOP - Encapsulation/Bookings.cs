using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Encapsulation
{
    internal class Booking
    {
        public Guid Id { get; set; }
        public Vehicle Vehicle{ get; set; }
        public string Type { get; set; }
        public DateTime Timestamp { get; set; }

        public Booking(Vehicle vehicle, string type, DateTime timestamp)
        {
            Id = Guid.NewGuid();
            Vehicle = vehicle;
            Type = type;
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"Booking Id: { Id }\nType: { Type }\nDate and Time: { Timestamp }\n-----------------------\nVehicle: { Vehicle }";
        }
    }
}
