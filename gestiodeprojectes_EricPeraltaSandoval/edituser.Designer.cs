namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class edituser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cancelarBoton = new System.Windows.Forms.Button();
            this.aplicarBoton = new System.Windows.Forms.Button();
            this.emailEditBox = new System.Windows.Forms.TextBox();
            this.apellidoEditBox = new System.Windows.Forms.TextBox();
            this.nomEditBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(133, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "CAMBIAR CONTRASEÑA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelarBoton
            // 
            this.cancelarBoton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.cancelarBoton.Location = new System.Drawing.Point(338, 232);
            this.cancelarBoton.Name = "cancelarBoton";
            this.cancelarBoton.Size = new System.Drawing.Size(123, 23);
            this.cancelarBoton.TabIndex = 1;
            this.cancelarBoton.Text = "Cancelar cambios";
            this.cancelarBoton.UseVisualStyleBackColor = true;
            this.cancelarBoton.Click += new System.EventHandler(this.cancelarBoton_Click);
            // 
            // aplicarBoton
            // 
            this.aplicarBoton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground2;
            this.aplicarBoton.Location = new System.Drawing.Point(338, 175);
            this.aplicarBoton.Name = "aplicarBoton";
            this.aplicarBoton.Size = new System.Drawing.Size(123, 23);
            this.aplicarBoton.TabIndex = 0;
            this.aplicarBoton.Text = "Aplicar cambios";
            this.aplicarBoton.UseVisualStyleBackColor = true;
            this.aplicarBoton.Click += new System.EventHandler(this.aplicarBoton_Click);
            // 
            // emailEditBox
            // 
            this.emailEditBox.Location = new System.Drawing.Point(127, 241);
            this.emailEditBox.Name = "emailEditBox";
            this.emailEditBox.Size = new System.Drawing.Size(131, 20);
            this.emailEditBox.TabIndex = 8;
            // 
            // apellidoEditBox
            // 
            this.apellidoEditBox.Location = new System.Drawing.Point(127, 166);
            this.apellidoEditBox.Name = "apellidoEditBox";
            this.apellidoEditBox.Size = new System.Drawing.Size(131, 20);
            this.apellidoEditBox.TabIndex = 7;
            // 
            // nomEditBox
            // 
            this.nomEditBox.Location = new System.Drawing.Point(127, 98);
            this.nomEditBox.Name = "nomEditBox";
            this.nomEditBox.Size = new System.Drawing.Size(131, 20);
            this.nomEditBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDITAR USUARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // edituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.edituserbackground;
            this.ClientSize = new System.Drawing.Size(500, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailEditBox);
            this.Controls.Add(this.cancelarBoton);
            this.Controls.Add(this.apellidoEditBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomEditBox);
            this.Controls.Add(this.aplicarBoton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "edituser";
            this.Text = "EDICIÓN DE USUARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailEditBox;
        private System.Windows.Forms.TextBox apellidoEditBox;
        private System.Windows.Forms.TextBox nomEditBox;
        private System.Windows.Forms.Button aplicarBoton;
        private System.Windows.Forms.Button cancelarBoton;
        private System.Windows.Forms.Button button1;
    }
}