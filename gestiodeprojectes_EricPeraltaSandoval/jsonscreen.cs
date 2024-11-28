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
    public partial class jsonscreen : Form
    {
        string rutaUsers;
        string rutaProjects;

        public jsonscreen(string jsonUsersPath, string jsonProjectsPath)
        {
            InitializeComponent();

            rutaUsers = jsonUsersPath;
            rutaProjects = jsonProjectsPath;   
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userscreen userscreen = new userscreen(rutaUsers, rutaProjects);

            userscreen.ShowDialog();
            this.Hide();
        }

        private void gestionDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectscreen projectscreen = new projectscreen(rutaUsers, rutaProjects);

            projectscreen.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarUsersJson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaUsers))
            {
                MessageBox.Show("Inserta un nuevo nombre para el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "Ficheros JSON (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = nomUsersJsonBox.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
           
                    string pathSavedFolder = saveFileDialog.FileName;
                    string jsonContent = File.ReadAllText(rutaUsers);

                    File.WriteAllText(pathSavedFolder, jsonContent);

                    MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
            }
        }

        private void GuardarProjectsJson_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rutaProjects)) {
                MessageBox.Show("Inserta un nuevo nombre para el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "Ficheros JSON (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = nomProjectsJsonBox.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string pathSavedFolder = saveFileDialog.FileName;
                string jsonContent = File.ReadAllText(rutaProjects);

                File.WriteAllText(pathSavedFolder, jsonContent);

                MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
