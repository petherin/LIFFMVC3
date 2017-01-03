using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class ImagePathConfiguration : EntityTypeConfiguration<ImagePath>
    {
        public ImagePathConfiguration() 
        {
            ToTable("ImagePaths");
            Property(i => i.Path).IsRequired().HasMaxLength(255);
        }
    }
}
