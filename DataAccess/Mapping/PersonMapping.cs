using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class PersonMapping : EntityTypeConfiguration<Person>
    {
        public PersonMapping()
        {
            this.HasKey(x => x.Id); // Person sınıfının içerisindeki ID ' yi PrimaryKey olarak ata

            this.Property(x => x.Name).IsRequired().HasColumnType("nvarchar").HasMaxLength(25);

            this.Property(x => x.Surname).HasColumnType("nvarchar").HasColumnName("Soyad").HasMaxLength(50);

            this.Property(x => x.TcNo).HasMaxLength(11).HasColumnType("char");
        }
    }
}
