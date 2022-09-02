using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class MeetingMapping : EntityTypeConfiguration<Meeting>
    {
        public MeetingMapping()
        {
            //Bire Çok Bağlantı Meeting Platform

            this.HasRequired(m => m.MeetingPlatform)
                .WithMany(mp => mp.Meetings)
                .HasForeignKey(m => m.MeetingPlatformId);

            //Bire Çok Bağlantı Meeting Subject

            this.HasRequired(m => m.MeetingSubject)
                .WithMany(ms => ms.Meetings)
                .HasForeignKey(m => m.MeetingSubjectID);

            //Bire bir Bağlantı Meeting Report ile

            this.HasOptional(x => x.MeetingReport)
                .WithRequired(x => x.Meeting).WillCascadeOnDelete(false);


            //Çoka Çok Bağlantı Person

            this.HasMany(x => x.People) //Meeting 
                .WithMany(p => p.Meetings)
                .Map(x =>
               {
                   x.MapLeftKey("PeopleRefId"); //Ara tabloda oluşacak olan ID isimleri
                   x.MapRightKey("MeetingRefId");
                   x.ToTable("MeetingPeople");
               });

        }
    }
}
