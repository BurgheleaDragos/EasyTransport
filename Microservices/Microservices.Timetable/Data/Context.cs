using System.Data.Entity;
using Microservices.Timetable.Data.Entities;
using Microservices.Timetable.Data.Mapping;

namespace Microservices.Timetable.Data
{
    public class Context : DbContext
    {
        public Context() : base("Microservices.TimeTable")
        {
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PlaceMappingConfiguration());
            modelBuilder.Configurations.Add(new TimeTableMappingConfiguration());
        }
    }
}