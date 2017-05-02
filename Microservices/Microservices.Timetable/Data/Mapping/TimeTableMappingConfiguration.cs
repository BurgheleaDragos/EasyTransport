using System.Data.Entity.ModelConfiguration;
using Microservices.Timetable.Data.Entities;

namespace Microservices.Timetable.Data.Mapping
{
    public class TimeTableMappingConfiguration : EntityTypeConfiguration<TimeTable>
    {
        public TimeTableMappingConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.TravelPrice).IsRequired();
            Property(t => t.ArrivalTime).IsRequired();
            Property(t => t.DepartureTime).IsRequired();
            Property(t => t.Details).IsOptional().HasMaxLength(1024);
        }
    }
}