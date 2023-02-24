using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IServiceFlight
    {
        public List<DateTime> GetFlightDates (string destination);
        public void GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public double DurationAverage(string destination);

        public IEnumerable<Flight> OrderedDurationFlights();
        IEnumerable<Traveller> SeniorTravellers(Flight f);
        public IGrouping<string, IEnumerable<Flight>> DestinationGroupedFlights();
    }
}
