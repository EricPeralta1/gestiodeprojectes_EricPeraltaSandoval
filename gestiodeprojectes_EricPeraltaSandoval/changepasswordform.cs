﻿using System;
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
    public partial class changepasswordform : Form
    {
        //Incluye al usuario a editar
        private user newUser;

        //Guarda el usuario a editar en el user(newUser)
        public changepasswordform(user edituser)
        {
            InitializeComponent();
            newUser = edituser;

            string llaveEncriptar = "12345678";
            nuevaContraseñaBox.Text = DesencriptarContra(newUser.password, llaveEncriptar);
        }

        //Al hacer clic en el button(aceptarButton), guardará la contrseña nueva del textBox(nuevaContraseñaBox), y actualizará el user(newUser).
        //Verifica que el textBox(nuevaContraseñaBox) no esté vacio, no sea igual a la contraseña antigua y tenga 8 carácteres.
        //Al acabar, cierra el form actual.
        private void button1_Click(object sender, EventArgs e)
        {
            string llaveEncriptar = "12345678";
            string contraVieja = DesencriptarContra(newUser.password, llaveEncriptar);

            if (string.IsNullOrWhiteSpace(nuevaContraseñaBox.Text)) {
                MessageBox.Show("Por favor, ingresa una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (contraVieja ==  nuevaContraseñaBox.Text) {
                MessageBox.Show("Por favor, ingresa una contraseña nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            } else if (nuevaContraseñaBox.Text.Length < 8) {
                MessageBox.Show("La contraseña debe tener 8 carácteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newUser.password = EncriptarContra(nuevaContraseñaBox.Text, llaveEncriptar);


            MessageBox.Show("Contraseña actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        //Este método permite encriptar la contraseña.
        //Recibe el string(contraNoEncriptada) y el string(key), que es la llave con la que haremos la encriptación, y debe ser igual para desencriptar.
        //Cifra el texto que pasemos, y devuelve un string de Base64 con el texto cifrado.
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

        //Permite desencriptar la contraseña.
        //Recibe la contraseñaEncriptada del usuario, asi como la llave con la que se encriptó.
        //Devuelve un string con la contraseña original.
        private static string DesencriptarContra(string contraEncriptada, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Clave de 256 bits
                aes.IV = new byte[16]; // Vector de inicialización

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(contraEncriptada)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
