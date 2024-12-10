using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

            string email = emailEditBox.Text;
            JArray jarrayusers = JArray.Parse(File.ReadAllText(jsonfilepath, Encoding.UTF8));
            userlist = jarrayusers.ToObject<List<user>>();

            if (string.IsNullOrEmpty(nomEditBox.Text) || string.IsNullOrEmpty(apellidoEditBox.Text) || string.IsNullOrEmpty(emailEditBox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de crear un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nomEditBox.Text.Any(char.IsDigit) || apellidoEditBox.Text.Any(char.IsDigit))
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

            } else {
                editedUser.name = nomEditBox.Text;
                editedUser.surname = apellidoEditBox.Text;
                editedUser.email = emailEditBox.Text;


                user usertoedit = userlist.First((u => u.userId == editedUser.userId));

                usertoedit.name = editedUser.name;
                usertoedit.surname = editedUser.surname;
                usertoedit.password = editedUser.password;

                File.WriteAllText(jsonfilepath, JArray.FromObject(userlist).ToString());

                MessageBox.Show("El usuario ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
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
