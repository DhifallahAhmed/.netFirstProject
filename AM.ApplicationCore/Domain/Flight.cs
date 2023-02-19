using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public Flight()
        {
        }

        public Flight(DateTime effectiveArrival, string departure, string destination, int estimatedDuration, DateTime flightDate, int flightId, Plane plane, ICollection<Passenger> passengers)
        {
            EffectiveArrival = effectiveArrival;
            Departure = departure;
            Destination = destination;
            EstimatedDuration = estimatedDuration;
            FlightDate = flightDate;
            FlightId = flightId;
            Plane = plane;
            this.Passengers = Passengers;
        }

        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public override string ToString()

        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration},Plane{Plane},Passengers{Passengers}";
        }
    }
}
