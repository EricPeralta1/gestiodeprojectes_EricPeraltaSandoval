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
        user editeduser;
        public checkpasswordform(user edituser)
        {
             editeduser = edituser;
            InitializeComponent();
        }

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
