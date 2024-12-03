using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class userscreen : Form
    {

        /// <summary>
        /// Lista de usuarios del JSON y ruta de proyectos
        /// </summary>
        List<user> userlist;
        string rutaProjects;



        /// <summary>
        ///Al inicializar el form, implementa la ruta automáticamente, creando la lista de usuarios (userlist)
        ///y actualiza el tablón (dataGridUsers) para mostrar la información del JSON
        /// </summary>
        /// <param name="userJsonPath"></param>
        /// <param name="projectJsonPath"></param>
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



        /// <summary>
        ///Incluye la lógica para mostrar los forms asignados en el ToolStrip (projectScreen y jsonScreen) y ocultar el actual. Al
        ///darle a salir, se finaliza el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectscreen projectscreen = new projectscreen(textBoxRuta.Text, rutaProjects);

            projectscreen.Show();
            this.Hide();
        }

        /// <summary>
        ///Permite cambiar al form(jsonScreen), y oculta el actual.
        ///Envia las rutas de los JSON de usuarios y proyectos para su automatización.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestiónDelJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonscreen jsonscreen = new jsonscreen(textBoxRuta.Text, rutaProjects);

            jsonscreen.Show();
            this.Hide();
        }

        /// <summary>
        /// Cierra el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        /// <summary>
        ///Lógica que permite añadir un Usuario al JSON de Usuarios
        ///Utiliza 4 paràmetros, nombre(string), apellido(string), contraseña(string), email(string)
        ///UserId se genera automàticamente leyendo la longitud de la lista.
        ///Incluye condiciones para verificar que los campos sean correctos, no esten vacios, y el correo esté verificado.
        ///Al finalizar, actualiza el JSON y el tablón y los usuarios a escoger en (userSelectBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailuserbox.Text;

            if (string.IsNullOrEmpty(textBoxRuta.Text))
            {
                MessageBox.Show("Selecciona un JSON de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(nameuserbox.Text) || string.IsNullOrEmpty(surnameuserbox.Text) || string.IsNullOrEmpty(emailuserbox.Text) || string.IsNullOrEmpty(passworduserbox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de crear un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameuserbox.Text.Any(char.IsDigit) || surnameuserbox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ni el nombre ni el apellido pueden contener numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!email.Contains("@") || email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show("El correo electrónico debe tener un formato válido (con texto antes y después de '@').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userlist.Any(u => u.email == email))
            {
                MessageBox.Show("El correo electrónico ya esta registrado. Por favor, ponga el suyo propio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (passworduserbox.Text.Length < 8){
                MessageBox.Show("La contraseña debe tener 8 carácteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                user user = new user();

                user.name = nameuserbox.Text;
                user.surname = surnameuserbox.Text;
                user.email = emailuserbox.Text;
                string llaveEncriptar = "12345678";
                user.password = EncriptarContra(passworduserbox.Text, llaveEncriptar);

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

                string jsonContent = File.ReadAllText(textBoxRuta.Text);
                userlist = JArray.Parse(jsonContent).ToObject<List<user>>();

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
        }
                       


        /// <summary>
        ///Permite cambiar el JSON de usuarios para modificar y trabajar con otro diferente.
        ///Al realizar la acción, cambia el tablón y los usuarios a escoger en (userSelectBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        ///Permite editar un usuario del JSON
        ///Verifica que el comboBox(userSelectBox) no esté vacio.
        ///Recoge al usuario esogido, y lo envia al form de edición como user(selectedUser)
        ///Al terminar la edición. actualiza al objeto en la lista UserList, actualiza el JSON y el tablón y comboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EDITAR_Click(object sender, EventArgs e)
        {
            if (userSelectBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
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
        }


        /// <summary>
        ///Permite borrar usuarios.
        ///Verifica que el comboBox(userSelectBox) tenga un usuario
        ///Elimina al usuario de la lista, y actualiza los indices de userId del resto para que estén en orden.
        ///Al terminar, actualiza el tablón y el comboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (userSelectBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

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


        /// <summary>
        ///Este método permite encriptar la contraseña.
        ///Recibe el string(contraNoEncriptada) y el string(key), que es la llave con la que haremos la encriptación, y debe ser igual para desencriptar.
        ///Cifra el texto que pasemos, y devuelve un string de Base64 con el texto cifrado.
        /// </summary>
        /// <param name="contraNoEncriptada"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string EncriptarContra(string contraNoEncriptada, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); 
                aes.IV = new byte[16]; 
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(contraNoEncriptada);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }
    }
}
