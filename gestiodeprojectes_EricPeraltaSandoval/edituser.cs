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


        /// <summary>
        /// Incluyen la ruta del JSON de usuarios, el usuario a editar (editedUser) y la lista de Usuarios(userList)
        /// </summary>
        private string jsonfilepath;
        private user editedUser;
        List<user> userlist;


        /// <summary>
        /// Al inicializar la aplicacíón, guarda el usuario a Editar en el user(editedUser).
        /// Guarda la ruta del JSON de usuarios en el string(jsonFilePath)
        /// Inserta los valores actuales del user(editedUser) en las boxes respectivas.
        /// </summary>
        /// <param name="selectedUser"></param>
        /// <param name="jsonPath"></param>
        public edituser(user selectedUser, string jsonPath)
        {
            InitializeComponent();

            editedUser = selectedUser;

            jsonfilepath = jsonPath;

            nomEditBox.Text = editedUser.name;
            apellidoEditBox.Text = editedUser.surname;
            emailEditBox.Text = editedUser.email;
        }



        /// <summary>
        /// Al hacer clic el button(aplicarBoton), se guardan los nuevos valores de las boxes respectivas (nomEditBox, apellidoEditBox, emailEditBox).
        /// En caso de haber cambiado la contraseña en el respectivo form, tambien se guarda.
        /// Actualiza la lista de usuarios y el JSON.
        /// Al finalizar, cierra el form y vuelve al anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// <summary>
        /// Al hacer el button(cancelarBoton), cierra el form actual, cancelando todo tipo de cambio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// l hacer clic el boton(contraseñaBoton), inicializa el form checkPasswordForm, donde se hara la comprovación de administrador.
        /// Al finalizar, vuelve a mostrar los valores de editedUser, en caso de que no hayamos acabado de actualizar algun valor.
        /// Oculta el form actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            checkpasswordform checkPasswordForm = new checkpasswordform(editedUser);

            checkPasswordForm.ShowDialog();
            this.Hide();

            nomEditBox.Text = editedUser.name;
            apellidoEditBox.Text = editedUser.surname;
            emailEditBox.Text = editedUser.email;
        }
    }
}
