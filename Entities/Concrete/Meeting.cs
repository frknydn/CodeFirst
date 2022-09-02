using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Meeting : IBaseEntity, IMeeting
    {
        public int ID { get; set; }
        public string MeetingName { get; set; }
        public int MeetingPlatformId { get; set; }
        public MeetingPlatform MeetingPlatform { get; set; }
        public int MeetingReportID { get; set; }
        public MeetingReport MeetingReport { get; set; }
        public int MeetingSubjectID { get; set; }
        public MeetingSubject MeetingSubject { get; set; }
        public ICollection<Person> People { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}
