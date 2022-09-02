using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class MeetingSubjectMapping : EntityTypeConfiguration<MeetingSubject>
    {
        public MeetingSubjectMapping()
        {
            //Burası tabloya ailt özelliklerin belirlenmesi için yazılmıştır.
            this.HasKey(ms => ms.ID); //ID ' yi PK olarak ayarlar

            this.Property(ms => ms.ID).IsRequired(); // Burada PK'nın boş geçilemeyeceğini , ıdentity kolon olacağını vermek için kullanılır.Bunuda Property üzerinden yaparız

            this.Property(ms => ms.CreatedDate).HasColumnType("date");


            //Meeting ile bire çok bağlantı ayarı için
            this.HasMany(ms => ms.Meetings)
                .WithRequired(m => m.MeetingSubject)
                .HasForeignKey(m => m.MeetingSubjectID);
        }
    }
}
