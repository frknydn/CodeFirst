using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    public class MeetingSubject : IBaseEntity, IMeetingSubject
    {
        public int ID { get; set; }
        public List<Meeting> Meetings { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status status { get; set; }
    }
}
