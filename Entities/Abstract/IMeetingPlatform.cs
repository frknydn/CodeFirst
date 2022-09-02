using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IMeetingPlatform
    {
        int ID  { get; set; }
        List<Meeting> Meetings { get; set; }
        //Meeting ile MeetingPlatform arasında 1'e çok bağlantı işlemi gerçekleştireceğiz.
    }
}
