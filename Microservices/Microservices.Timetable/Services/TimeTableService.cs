using System.Collections.Generic;
using System.Linq;
using Microservices.Timetable.Data;
using Microservices.Timetable.Data.Entities;

namespace Microservices.Timetable.Services
{
    public class TimetableService
    {
        public List<TimeTable> GetTimeTables()
        {
            var context = new Context();
            var result = context.TimeTables.ToList();
            return result;
        }

        public TimeTable GetById(int id)
        {
            var context = new Context();
            var result = context.TimeTables.FirstOrDefault(t => t.Id == id);
            return result;
        }

        public List<TimeTable> GetByRoute(string origin, string destination)
        {
            return null;
        }

        public List<TimeTable> GetByTime(long departure, long arrival)
        {
            return null;
        }
    }
}