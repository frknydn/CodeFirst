using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IPerson
    {
        int Id { get; set; }    
        string Name { get; set; }
        string Surname { get; set; }
        string TcNo { get; set; }
        ICollection<Meeting> Meetings { get; set; }
        //Metting ile Person arasıdan çoka çok bağlantı olacaktırr!!!!
    }
}
