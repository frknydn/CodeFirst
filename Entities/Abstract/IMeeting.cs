using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IMeeting
    {
        int ID { get; set; }
        string MeetingName { get; set; }    

        //Meeting Platform 1 Kısmı
        int MeetingPlatformId { get; set; }
        MeetingPlatform MeetingPlatform { get; set; }

        //Meeting Report 1 Kısmı
        int MeetingReportID { get; set; }   
        MeetingReport MeetingReport { get; set; }

        //Meeting Subjet 1 Kısmı
        int MeetingSubjectID { get; set; }
        MeetingSubject MeetingSubject { get; set; } 

        //Çok bağlantı kısmı
        ICollection<Person> People { get; set; }

    }
}
