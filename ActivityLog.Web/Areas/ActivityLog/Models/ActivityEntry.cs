using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityLog.Web.Areas.ActivityLog.Models
{
    public class ActivityEntryModel
    {
        public int Id { get; set; }
        public Guid Ref { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Data { get; set; }
    }
}
