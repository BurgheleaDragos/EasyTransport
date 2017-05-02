using System.Data.Entity.ModelConfiguration;
using Microservices.Timetable.Data.Entities;

namespace Microservices.Timetable.Data.Mapping
{
    public class PlaceMappingConfiguration : EntityTypeConfiguration<Place>
    {
        public PlaceMappingConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.City).IsRequired().HasMaxLength(32);
            Property(t => t.Name).IsRequired().HasMaxLength(64);
            Property(t => t.Address).IsRequired().HasMaxLength(128);
            Property(t => t.Details).IsOptional().HasMaxLength(1024);
        }
    }
}