using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType { Boing,AirBus}
    public class Plane
    {
        public Plane()
        {
        }

        public Plane(PlaneType planeType, DateTime manufactureDate, int capacity, int planeID, ICollection<Flight> flights)
        {
            PlaneType = planeType;
            ManufactureDate = manufactureDate;
            Capacity = capacity;
            PlaneID = planeID;
            Flights = flights;
        }

        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Capacity { get; set; }
        public int PlaneID { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"PlaneID: {PlaneID}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType},Flights{Flights}";
        }
    }
}
