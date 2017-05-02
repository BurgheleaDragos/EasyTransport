using System;

namespace Microservices.Timetable.Data.Entities
{
    public class TimeTable
    {
        public int Id { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public double TravelPrice { get; set; }
        public string Details { get; set; }

        public virtual Place OriginPlace { get; set; }
        public virtual Place DestinationPlace { get; set; }
    }
}