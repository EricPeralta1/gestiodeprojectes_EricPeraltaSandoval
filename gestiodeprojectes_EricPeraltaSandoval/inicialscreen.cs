using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class inicialscreen : Form
    {
        public inicialscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            string jsonsFolderPath = Path.Combine(projectDirectory, "JSONs");


            string userJsonPath = Path.Combine(jsonsFolderPath, "newUsers.json");
            string projectJsonPath = Path.Combine(jsonsFolderPath, "newProjects.json");
            string initialBody = "[]";

            File.WriteAllText(userJsonPath, initialBody);
            File.WriteAllText(projectJsonPath, initialBody);

            userscreen userscreen = new userscreen(userJsonPath, projectJsonPath);

            userscreen.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userimportjson userimportjson = new userimportjson();
            
            userimportjson.Show();
            this.Hide();
        }
    }
}
