using System;
using System.IO;
using System.Windows.Forms;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class inicialscreen : Form
    {
        /// <summary>
        ///Incializa el form.
        /// </summary>
        public inicialscreen()
        {
            InitializeComponent();
        }



        /// <summary>
        ///Al seleccionar el button(crearJson), inicializa 2 nuevos JSON en la carpeta JSONs del programa. 
        ///Estos JSON estarán vacios, con los "[]" para permitir que el usuario introduzca la información en userScreen y projectScreen.
        ///Pueden ser guardados aparte en jsonScreen.
        ///Al acabar, redirige al form(userScreen) y oculta el actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///Incializa el form(userimportjson), i oculta el actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            userimportjson userimportjson = new userimportjson();
            
            userimportjson.Show();
            this.Hide();
        }
    }
}
