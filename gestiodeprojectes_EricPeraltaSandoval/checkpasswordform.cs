using System;
using System.Windows.Forms;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class checkpasswordform : Form
    {

        /// <summary>
        /// Incluye el usuario a editar.
        /// </summary>
        user editeduser;

        /// <summary>
        /// Inicializa el form y guarda del usuario a editar en user(editedUser)
        /// </summary>
        /// <param name="edituser"></param>
        public checkpasswordform(user edituser)
        {
             editeduser = edituser;
            InitializeComponent();
        }


        /// <summary>
        /// Inicializa el form y guarda del usuario a editar en user(editedUser)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordCheckBox.Text == "admin1234")
            {
                using (changepasswordform changePasswordForm = new changepasswordform(editeduser))
                {
                    if (changePasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("La contraseña no es correcta. Volviendo al menú...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
