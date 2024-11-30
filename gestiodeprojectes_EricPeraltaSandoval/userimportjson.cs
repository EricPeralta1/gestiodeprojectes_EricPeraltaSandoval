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

        //Incluyen las rutas del JSON de usuarios y proyectos respectivamente.
        private string jsonUsersPath;
        private string jsonProjectsPath;

        //Inicializa el form.
        public userimportjson()
        {
            InitializeComponent();
        }

        //Comprueba que los 2 JSON han sido añadidos.
        //Inicializa el form(userScreen), pasandole ambas rutas para automatizar el proceso de añadir el JSON. Se pueden cambiar más adelante en
        //caso de querer trabajar con alguno distinto.
        //Oculta el form actual.
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

        //Comprueba que los 2 JSON han sido añadidos.
        //Inicializa el form(projectscreen), pasandole ambas rutas para automatizar el proceso de añadir el JSON. Se pueden cambiar más adelante en
        //caso de querer trabajar con alguno distinto.
        //Oculta el form actual.
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

        //Comprueba que los 2 JSON han sido añadidos.
        //Inicializa el form(jsonScreen), pasandole ambas rutas para automatizar el proceso de añadir el JSON. Se pueden cambiar más adelante en
        //caso de querer trabajar con alguno distinto.
        //Oculta el form actual.
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


        //Permite vincular el JSON de usuarios, detectando la ruta y guardandola como String. Podemos elegir el archivo gracias a OpenFileDialog.
        //Guarda en el string(jsonuserspath) el texto del textBox(rutaUsuariosBox), que incluye la ruta del archivo.
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

        //Permite vincular el JSON de proyectos, detectando la ruta y guardandola como String. Podemos elegir el archivo gracias a OpenFileDialog.
        //Guarda en el string(jsonProjectsPath) el texto del textBox(rutaProjectosBox), que incluye la ruta del archivo.
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
