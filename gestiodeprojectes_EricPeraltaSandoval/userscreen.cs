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
        List<user> userlist;

        public userscreen()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gestionDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectscreen projectscreen = new projectscreen(); 

            projectscreen.Show();
        }

        private void gestiónDelJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonscreen jsonscreen = new jsonscreen();

            jsonscreen.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            int lastuserId = userlist.Last().userId;
            user.userId = lastuserId + 1;


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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (userSelectBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userIndex = userlist.IndexOf((user)userSelectBox.SelectedItem);
            userlist.RemoveAt(userIndex);

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
