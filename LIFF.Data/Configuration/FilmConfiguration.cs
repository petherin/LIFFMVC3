using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class FilmConfiguration : EntityTypeConfiguration<Film>
    {
        public FilmConfiguration() 
        {
            ToTable("Films");
            Property(f => f.Description).IsRequired().HasMaxLength(4000);
            Property(f => f.Title).IsRequired().HasMaxLength(255);
        }
    }
}
