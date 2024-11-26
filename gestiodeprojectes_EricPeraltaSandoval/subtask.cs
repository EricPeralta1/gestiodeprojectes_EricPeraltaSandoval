using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public class subtask
    {
        public int subtaskId { get; set; }

        public string name { get; set; }

        public string subtaskUser { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public String status { get; set; }

        public String description { get; set; }
    }
}
