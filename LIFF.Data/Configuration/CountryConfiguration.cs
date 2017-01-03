using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration() 
        {
            ToTable("Countries");
            Property(c => c.Name).IsRequired().HasMaxLength(100);
        }
    }
}
