using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public class project
    {
        public int projectId { get; set; }

        public String name { get; set; }

        public String description { get; set; }

        public project() { 
        
        }

        public project (int projectId, string name, string description)
        {
            this.projectId = projectId;
            this.name = name;
            this.description = description;
        }
    }
}
