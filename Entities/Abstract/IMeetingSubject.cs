using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IMeetingSubject 
    {
        int ID  { get; set; }


        //Meeting ile çok bağlantı kısmı
        List<Meeting> Meetings { get; set; }    
        
        //Meeting ile bire çok bağlantı olacak 
        //1 tane Toplantının 1 tane konusu olur ama 1 konu birden fazla toplantıda olabilir.
    }
}
