using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class checkpasswordform : Form
    {

        //Incluye el usuario a editar.
        user editeduser;

        //Inicializa el form y guarda del usuario a editar en user(editedUser)
        public checkpasswordform(user edituser)
        {
             editeduser = edituser;
            InitializeComponent();
        }

        //Comprueba que el usuario sea un admin mediante una contraseña.
        //La contraseña debe ser "admin1234", pues la que permite el acceso de administrador. 
        //Si se pone de forma correcta, se inicializará el form de cambio de contraseña, y se cerrará el actual.
        //En caso contrario, mostrará un mensaje de error y se cerrará el form actual, volviendo al menú anterior.
        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordCheckBox.Text == "admin1234")
            {
                changepasswordform changePasswordForm = new changepasswordform(editeduser);

                changePasswordForm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("La contraseña no es correcta. Volviendo al menú..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
