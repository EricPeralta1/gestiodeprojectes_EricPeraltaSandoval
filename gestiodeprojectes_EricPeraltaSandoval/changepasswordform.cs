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
    public partial class changepasswordform : Form
    {
        //Incluye al usuario a editar
        private user newUser;

        //Guarda el usuario a editar en el user(newUser)
        public changepasswordform(user edituser)
        {
            InitializeComponent();
            newUser = edituser;
        }

        //Al hacer clic en el button(aceptarButton), guardará la contrseña nueva del textBox(nuevaContraseñaBox), y actualizará el user(newUser).
        //Verifica que el textBox(nuevaContraseñaBox) no esté vacio, no sea igual a la contraseña antigua y tenga 8 carácteres.
        //Al acabar, cierra el form actual.
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nuevaContraseñaBox.Text)) {
                MessageBox.Show("Por favor, ingresa una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (newUser.password == nuevaContraseñaBox.Text) {
                MessageBox.Show("Por favor, ingresa una contraseña nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            } else if (nuevaContraseñaBox.Text.Length < 8) {
                MessageBox.Show("La contraseña debe tener 8 carácteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newUser.password = nuevaContraseñaBox.Text;

            MessageBox.Show("Contraseña actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
