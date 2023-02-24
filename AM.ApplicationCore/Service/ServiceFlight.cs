using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public double DurationAverage(string destination)
        {
            return (from f in Flights
                    where f.Destination == destination
                    select f.EstimatedDuration).Average();
        }

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            //With foreach structure
            //foreach(Flight f in Flights)
            //    if (f.Destination.Equals(destination))
            //        ls.Add(f.FlightDate);
            //return ls;
            //LINQ language
            //var query = from f in Flights
            //            where
            //            f.Destination.Equals(destination)
            //            select f.FlightDate;
            //return query.ToList();

            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                    dates.Add(Flights[i].FlightDate);
            }
            return dates;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination.Equals(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))

                            Console.WriteLine(f);

                    }
                    break;
                case "EffectiveArrival":
                    foreach (Flight f in Flights)
                    {
                        if (f.EffectiveArrival == DateTime.Parse(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
            }

        }



        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var req = from f in Flights
                      where (f.FlightDate).CompareTo(startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7
                      select f;
            // var req = Flights.Where(f => DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7);
            return req.Count();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var req = from f in Flights
                      where f.Plane == plane
                      select new { f.FlightDate, f.Destination };
            //  var req = Flights.Where(f => f.Plane == plane).Select(p => new { f.FlightDate, f.Destination });
            foreach (var v in req)
                Console.WriteLine("Flight Date; " + v.FlightDate + " Flight destination: " + v.Destination);
        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            return Flights.OrderByDescending(f => f.EstimatedDuration);
        }
        public IEnumerable<Traveller> SeniorTravellers(Flight f)
        {

            var oldTravellers = from p in f.Passengers.OfType<Traveller>()
                                orderby p.BirthDate
                                select p;
            return oldTravellers.Take(3);
        }

        public IGrouping<string, IEnumerable<Flight>> DestinationGroupedFlights()
        {
          

            var req= Flights.GroupBy(f => f.Destination);

            foreach (var g in req)
            {
                Console.WriteLine("Destination: " + g.Key);
                foreach (var f in g)
                    Console.WriteLine("Décollage: " + f.FlightDate);

            }
            return (IGrouping<string, IEnumerable<Flight>>)req;
        }
        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;
    }
    
    
}
