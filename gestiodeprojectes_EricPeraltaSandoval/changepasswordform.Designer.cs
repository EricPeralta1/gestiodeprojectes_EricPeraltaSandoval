namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class changepasswordform
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
            this.nuevaContraseñaBox = new System.Windows.Forms.TextBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nuevaContraseñaBox
            // 
            this.nuevaContraseñaBox.Location = new System.Drawing.Point(259, 145);
            this.nuevaContraseñaBox.Name = "nuevaContraseñaBox";
            this.nuevaContraseñaBox.Size = new System.Drawing.Size(150, 20);
            this.nuevaContraseñaBox.TabIndex = 0;
            // 
            // aceptarButton
            // 
            this.aceptarButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.aceptarButton.Location = new System.Drawing.Point(295, 202);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 1;
            this.aceptarButton.Text = "ACEPTAR";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(128, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce una nueva contraseña al usuario";
            // 
            // changepasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.changepasswordformbackground;
            this.ClientSize = new System.Drawing.Size(455, 302);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.nuevaContraseñaBox);
            this.Controls.Add(this.label1);
            this.Name = "changepasswordform";
            this.Text = "changepasswordform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nuevaContraseñaBox;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label label1;
    }
}