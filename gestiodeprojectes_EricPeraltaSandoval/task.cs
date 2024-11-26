using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public class task
    {
        public int taskId {  get; set; }

        public string name { get; set; }

        public string taskUser { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public String status { get; set; }

        public String description { get; set; }

        public task() { 

        }

        public task(int taskId, string name, string taskUser, DateTime startDate, DateTime endDate, String status, String description) { 
            this.taskId = taskId;
            this.name = name;  
            this.taskUser = taskUser;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.description = description;
        }
    }
}
