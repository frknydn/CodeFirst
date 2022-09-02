using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Mapping
{
    public class MeetingReportMapping :  EntityTypeConfiguration<MeetingReport>
    {
        public MeetingReportMapping()
        {
            this.HasKey(mr => mr.ID);
            this.Property(mr => mr.ID).IsRequired();
        }
    }
}
