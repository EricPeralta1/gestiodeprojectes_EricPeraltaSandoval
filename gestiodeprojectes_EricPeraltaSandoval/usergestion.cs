using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class usergestion : Form
    {
        public usergestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userscreen userscreen = new userscreen(); 
            
            userscreen.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectscreen projectscreen = new projectscreen();
            projectscreen.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            jsonscreen jsonscreen = new jsonscreen();   
            jsonscreen.Show();
            this.Hide();

        }
    }
}
