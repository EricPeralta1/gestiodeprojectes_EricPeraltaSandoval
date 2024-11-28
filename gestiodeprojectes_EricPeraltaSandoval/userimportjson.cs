using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class userimportjson : Form
    {
        private string jsonUsersPath;
        private string jsonProjectsPath;

        public userimportjson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaProyectosBox.Text) || string.IsNullOrEmpty(rutaUsuariosBox.Text)){
                MessageBox.Show("Selecciona los 2 JSON para poder continuar, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userscreen userscreen = new userscreen(jsonUsersPath, jsonProjectsPath); 
            
            userscreen.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaProyectosBox.Text) || string.IsNullOrEmpty(rutaUsuariosBox.Text))
            {
                MessageBox.Show("Selecciona los 2 JSON para poder continuar, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            projectscreen projectscreen = new projectscreen(jsonUsersPath, jsonProjectsPath);
            projectscreen.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaProyectosBox.Text) || string.IsNullOrEmpty(rutaUsuariosBox.Text))
            {
                MessageBox.Show("Selecciona los 2 JSON para poder continuar, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            jsonscreen jsonscreen = new jsonscreen(jsonUsersPath, jsonProjectsPath);   
            jsonscreen.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                rutaUsuariosBox.Text = openFileDialog.FileName;
                jsonUsersPath = openFileDialog.FileName;
            }
        }

        private void jsonProjectsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                rutaProyectosBox.Text = openFileDialog.FileName;
                jsonProjectsPath = openFileDialog.FileName;
            }
        }
    }
}
