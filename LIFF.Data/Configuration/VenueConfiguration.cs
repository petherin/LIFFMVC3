using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class VenueConfiguration : EntityTypeConfiguration<Venue>
    {
        public VenueConfiguration() 
        {
            ToTable("Venues");
            Property(v => v.Name).IsRequired().HasMaxLength(255);
        }
    }
}
