using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class TimeSlotConfiguration : EntityTypeConfiguration<TimeSlot>
    {
        public TimeSlotConfiguration() 
        {
            ToTable("TimeSlots");
            Property(t => t.EndTime).IsRequired();
            Property(t => t.StartTime).IsRequired();
        }
    }
}
