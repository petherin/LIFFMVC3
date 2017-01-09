using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Configuration
{
    public class NewsItemConfiguration : EntityTypeConfiguration<NewsItem>
    {
        public NewsItemConfiguration() 
        {
            ToTable("NewsItems");
            Property(n => n.Headline).IsRequired().HasMaxLength(255);
            Property(n => n.DatePosted).IsRequired();
            Property(n => n.Description).IsRequired().HasMaxLength(512);
            Property(n => n.Body).IsRequired().HasMaxLength(4000);
        }
    }
}
