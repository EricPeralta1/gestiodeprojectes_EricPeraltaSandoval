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
    public partial class edituser : Form
    {
        private string jsonfilepath;
        private user editedUser;
        List<user> userlist;


        public edituser(user selectedUser, string jsonPath)
        {
            InitializeComponent();

            editedUser = selectedUser;

            jsonfilepath = jsonPath;

            nomEditBox.Text = editedUser.name;
            apellidoEditBox.Text = editedUser.surname;
            emailEditBox.Text = editedUser.email;
        }

        private void aplicarBoton_Click(object sender, EventArgs e)
        {
            editedUser.name = nomEditBox.Text;
            editedUser.surname = apellidoEditBox.Text;
            editedUser.email = emailEditBox.Text;

            JArray jarrayusers = JArray.Parse(File.ReadAllText(jsonfilepath, Encoding.Default));
            userlist = jarrayusers.ToObject<List<user>>();
            user usertoedit = userlist.First((u => u.userId == editedUser.userId));

            usertoedit.name = editedUser.name;
            usertoedit.surname = editedUser.surname;
            usertoedit.password = editedUser.password;

            File.WriteAllText(jsonfilepath, JArray.FromObject(userlist).ToString());

            MessageBox.Show("El usuario ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkpasswordform checkPasswordForm = new checkpasswordform(editedUser);

            checkPasswordForm.ShowDialog();

            nomEditBox.Text = editedUser.name;
            apellidoEditBox.Text = editedUser.surname;
            emailEditBox.Text = editedUser.email;
        }
    }
}
