using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IMeetingReport
    {
        // NOT : Meetin ile MeetingReport arasında 1 'e 1 bağlantı olacaktır.
        int ID { get; set; }

        //Meeting ile 1 bağlantı kısmı 
        int MeetingID { get; set; } 
        Meeting Meeting { get; set; }
       
    }
}
