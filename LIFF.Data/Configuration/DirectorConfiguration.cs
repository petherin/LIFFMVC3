using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class DirectorConfiguration : EntityTypeConfiguration<Director>
    {
        public DirectorConfiguration() 
        {
            ToTable("Directors");
            Property(d => d.Name).IsRequired().HasMaxLength(255);
        }
    }
}
