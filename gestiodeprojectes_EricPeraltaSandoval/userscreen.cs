using Newtonsoft.Json.Linq;
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
    public partial class userscreen : Form
    {
        //Lista de usuarios del JSON
        List<user> userlist;
        //Ruta del JSON de proyectos
        string rutaProjects;

        //Al inicializar el form, implementa la ruta automáticamente, creando la lista de usuarios (userlist)
        //y actualiza el tablón (dataGridUsers) para mostrar la información del JSON
        public userscreen(string userJsonPath, string projectJsonPath)
        {
            InitializeComponent();

            textBoxRuta.Text = userJsonPath;
            rutaProjects = projectJsonPath;

            JArray jarrayusers = JArray.Parse(File.ReadAllText(textBoxRuta.Text, Encoding.Default));
            userlist = jarrayusers.ToObject<List<user>>();

            dataGridUsers.DataSource = null;
            dataGridUsers.DataSource = userlist;

            if (dataGridUsers.Columns.Contains("password"))
            {
                dataGridUsers.Columns["password"].Visible = false;
            }

            userSelectBox.DataSource = null;
            userSelectBox.DataSource = userlist;
            userSelectBox.DisplayMember = "Name";

        }

        //Incluye la lógica para mostrar los forms asignados en el ToolStrip (projectScreen y jsonScreen) y ocultar el actual. Al
        //darle a salir, se finaliza el programa.
        private void gestionDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectscreen projectscreen = new projectscreen(textBoxRuta.Text, rutaProjects); 

            projectscreen.Show();
            this.Hide();
        }

        private void gestiónDelJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonscreen jsonscreen = new jsonscreen(textBoxRuta.Text, rutaProjects);

            jsonscreen.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Lógica que permite añadir un Usuario al JSON de Usuarios
        //Utiliza 4 paràmetros, nombre(string), apellido(string), contraseña(string), email(string)
        //UserId se genera automàticamente leyendo la longitud de la lista.
        //Incluye condiciones para verificar que los campos sean correctos, no esten vacios y haya un JSON vinculado.
        //Al finalizar, actualiza el JSON y el tablón y los usuarios a escoger en (userSelectBox)
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxRuta.Text))
            {
                MessageBox.Show("Selecciona un JSON de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(nameuserbox.Text) || string.IsNullOrWhiteSpace(surnameuserbox.Text) || string.IsNullOrWhiteSpace(emailuserbox.Text) || string.IsNullOrWhiteSpace(passworduserbox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de crear un usuario.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nameuserbox.Text.Any(char.IsDigit) || surnameuserbox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ni el nombre ni el apellido pueden contener numeros.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = emailuserbox.Text;
            if (!email.Contains("@") || email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show("El correo electrónico debe tener un formato válido (con texto antes y después de '@').","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            user user = new user();

            user.name  = nameuserbox.Text;
            user.surname = surnameuserbox.Text;
            user.email = emailuserbox.Text;
            user.password = passworduserbox.Text;
            Console.WriteLine(userlist.Count);
            if (userlist.Count == 0)
            {
                user.userId = 1;
            }
            else
            {
                int lasttaskId = userlist.Last().userId;
                user.userId = lasttaskId + 1;
            }


            userlist.Add(user);
           
            File.WriteAllText(textBoxRuta.Text, JArray.FromObject(userlist).ToString());

            dataGridUsers.DataSource = null;
            dataGridUsers.DataSource = userlist;

            if (dataGridUsers.Columns.Contains("password"))
            {
                dataGridUsers.Columns["password"].Visible = false;
            }
                
            nameuserbox.Clear();
            surnameuserbox.Clear();
            emailuserbox.Clear();
            passworduserbox.Clear();

            userSelectBox.DataSource = null;
            userSelectBox.DataSource = userlist;
            userSelectBox.DisplayMember = "Name";

            MessageBox.Show("El usuario se ha creado. La información se ha actualizado", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        //Permite cambiar el JSON de usuarios para modificar y trabajar con otro diferente.
        //Al realizar la acción, cambia el tablón y los usuarios a escoger en (userSelectBox)
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK)) { 
                textBoxRuta.Text = openFileDialog.FileName;
                JArray jarrayusers = JArray.Parse(File.ReadAllText(textBoxRuta.Text, Encoding.Default));
                userlist = jarrayusers.ToObject<List<user>>();

                dataGridUsers.DataSource = null;
                dataGridUsers.DataSource = userlist;

                if (dataGridUsers.Columns.Contains("password"))
                {
                    dataGridUsers.Columns["password"].Visible = false;
                }

                userSelectBox.DataSource = null;
                userSelectBox.DataSource = userlist;
                userSelectBox.DisplayMember = "Name";


            }
        }

        //Permite editar un usuario del JSON
        //Verifica que el comboBox(userSelectBox) no esté vacio.
        //Recoge al usuario esogido, y lo envia al form de edición como user(selectedUser)
        //Al terminar la edición. actualiza al objeto en la lista UserList, actualiza el JSON y el tablón y comboBox.
        private void EDITAR_Click(object sender, EventArgs e)
        {
            if (userSelectBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user selectedUser = (user)userSelectBox.SelectedItem;

            edituser edituser = new edituser(selectedUser, textBoxRuta.Text);
            edituser.ShowDialog();

            if (!string.IsNullOrEmpty(textBoxRuta.Text))
            {
                userlist = JArray.Parse(File.ReadAllText(textBoxRuta.Text)).ToObject<List<user>>();
                dataGridUsers.DataSource = null;
                dataGridUsers.DataSource = userlist;

                if (dataGridUsers.Columns.Contains("password"))
                {
                    dataGridUsers.Columns["password"].Visible = false;
                }

                userSelectBox.DataSource = null;
                userSelectBox.DataSource = userlist;
                userSelectBox.DisplayMember = "Name";
            }

        }

        //Permite borrar usuarios.
        //Verifica que el comboBox(userSelectBox) tenga un usuario
        //Elimina al usuario de la lista, y actualiza los indices de userId del resto para que estén en orden.
        //Al terminar, actualiza el tablón y el comboBox.
        private void button3_Click(object sender, EventArgs e)
        {
            if (userSelectBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userIndex = userlist.IndexOf((user)userSelectBox.SelectedItem);
            userlist.RemoveAt(userIndex);

            for (int i = 0; i < userlist.Count; i++)
            {
                userlist[i].userId = i + 1; 
            }

            File.WriteAllText(textBoxRuta.Text, JArray.FromObject(userlist).ToString());

            dataGridUsers.DataSource = null;
            dataGridUsers.DataSource = userlist;

            if (dataGridUsers.Columns.Contains("password"))
            {
                dataGridUsers.Columns["password"].Visible = false;
            }

            userSelectBox.DataSource = null;
            userSelectBox.DataSource = userlist;
            userSelectBox.DisplayMember = "Name";

            MessageBox.Show("Usuario eliminado.", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
