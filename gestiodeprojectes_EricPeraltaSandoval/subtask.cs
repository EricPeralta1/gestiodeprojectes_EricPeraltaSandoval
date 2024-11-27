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

        public string startDate { get; set; }
        public string endDate { get; set; }

        public String status { get; set; }

        public String description { get; set; }

        public subtask() {
        }

        public subtask(int subtaskId, string name, string subtaskUser, string startDate, string endDate, String status, String description)
        {
            this.subtaskId = subtaskId;
            this.name = name;
            this.subtaskUser = subtaskUser;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.description = description;
        }
    }
}
