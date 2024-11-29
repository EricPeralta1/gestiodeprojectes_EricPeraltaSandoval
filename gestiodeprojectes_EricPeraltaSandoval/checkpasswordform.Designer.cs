namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class checkpasswordform
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
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.passwordCheckBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkPasswordButton
            // 
            this.checkPasswordButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.checkPasswordButton.Location = new System.Drawing.Point(180, 213);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.checkPasswordButton.TabIndex = 2;
            this.checkPasswordButton.Text = "ACEPTAR";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.Location = new System.Drawing.Point(78, 167);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(299, 20);
            this.passwordCheckBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para cambiar la contraseña, introduce la contraseña de administrador.";
            // 
            // checkpasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.checkpasswordform;
            this.ClientSize = new System.Drawing.Size(459, 308);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "checkpasswordform";
            this.Text = "COMPROVANDO ADMINISTRADOR...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkPasswordButton;
        private System.Windows.Forms.TextBox passwordCheckBox;
        private System.Windows.Forms.Label label1;
    }
}