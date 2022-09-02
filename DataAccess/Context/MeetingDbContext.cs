using DataAccess.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext() : base("Server=DESKTOP-7628CQK;Database=Kd12EtutMeeting;Uid=sa;Pwd=11411141;")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MeetingDbContext>());

            // CreateDatabaseIfNotExists --> SQL serverda daha önce veri tabanı oluşturulmadıysa bu DBContext'i çalıştır.
            // DropCreateDatabaseAlways --> SQL serverda daha önceden database varsa dahi database her zaman siler ve yeniden oluşturur.

            // DropCreateDatabaseIfModelChanges --> SQL serverda veritabanı veri tabanı modellerde değişiklik olduysa veritabanını siler ve yeniden oluşturur.
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<MeetingPlatform> MeetingPlatforms { get; set; }
        public DbSet<MeetingSubject> MeetingSubjects { get; set; }
        public DbSet<MeetingReport> MeetingReports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Sen yaptığın ayarlamaları mobelbuilder nesnesinin özelliği olan configurationlara ekleme yaparak veri tabanına gönderirsin.
            modelBuilder.Configurations.Add(new MeetingMapping());
            modelBuilder.Configurations.Add(new PersonMapping());
            modelBuilder.Configurations.Add(new MeetingPlatformMapping());
            modelBuilder.Configurations.Add(new MeetingSubjectMapping());
            modelBuilder.Configurations.Add(new MeetingReportMapping());
        }

    }
}
