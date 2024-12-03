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

        /// <summary>
        ///Incluye las rutas del JSON de usuarios y proyectos.
        /// </summary>
        string rutaUsers;
        string rutaProjects;


        /// <summary>
        ///Al inicializar, guarda las rutas de los JSON utilizados en rutaUsers i rutaProjects respectivamente.
        /// </summary>
        /// <param name="jsonUsersPath"></param>
        /// <param name="jsonProjectsPath"></param>
        public jsonscreen(string jsonUsersPath, string jsonProjectsPath)
        {
            InitializeComponent();

            rutaUsers = jsonUsersPath;
            rutaProjects = jsonProjectsPath;   
        }

        /// <summary> 
        ///Permite cambiar al form(userScreen), pasandoles las rutas de los JSONs.
        ///Oculta el form acutal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userscreen userscreen = new userscreen(rutaUsers, rutaProjects);

            userscreen.ShowDialog();
            this.Hide();
        }


        /// <summary>
        ///Permite cambiar al form(projectScreen) pasandoles las rutas de los JSONs.
        ///Oculta el form acutal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectscreen projectscreen = new projectscreen(rutaUsers, rutaProjects);

            projectscreen.Show();
            this.Hide();
        }

        /// <summary>
        /// Finaliza el proceso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Permite guardar el JSON de usuarios que utilizamos en un archivo JSON aparte.
        /// Esto es debido al uso del SaveFileDialog que permite guardar archivos.
        /// Le especificamos que queremos guardar un json, y el nombre de este será el incluido en el textBox(rutaUsers)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Permite guardar el JSON de proyectos que utilizamos en un JSON aparte.
        /// Esto es debido al uso del SaveFileDialog que permite guardar archivos.
        /// Le especificamos que queremos guardar un json, y el nombre de este será el incluido en el textBox(rutaProjects)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Al hacer clic en el button(returnButton), permite volver a la pantalla de inicio del programa.
        /// Cierra la ventana actual, inicializa el form(initialscreen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            inicialscreen inicialscreen = new inicialscreen();
            inicialscreen.Show();
            this.Close();
        }
    }
}
