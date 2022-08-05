using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.MODEL.Master
{
    public class MeetingModel : BaseModel
    {
        public string MeetingName { get; set; }
        public string MeetingDate { get; set; }
        public string MeetingTime { get; set; }
        public string MeetingLink { get; set; }
        public string Stream { get; set; }
        public string Semester { get; set; }
        public string MeetingId { get; set; }
        public bool IsAttended { get; set; }
    }
}
