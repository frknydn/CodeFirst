using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class MeetingPlatformMapping : EntityTypeConfiguration<MeetingPlatform>
    {
        public MeetingPlatformMapping()
        {

            //Bire Çok Bağlantı İçin
            this.HasMany(mp => mp.Meetings)
                .WithRequired(m => m.MeetingPlatform)
                .HasForeignKey(m => m.MeetingPlatformId);
        }

    }
}
