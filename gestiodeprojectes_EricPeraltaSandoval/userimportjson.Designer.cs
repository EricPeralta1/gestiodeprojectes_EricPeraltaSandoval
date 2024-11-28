namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class userimportjson
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rutaUsuariosBox = new System.Windows.Forms.TextBox();
            this.jsonUsersButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rutaProyectosBox = new System.Windows.Forms.TextBox();
            this.jsonProjectsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(557, 153);
            this.button1.TabIndex = 0;
            this.button1.Text = "GESTIÓ D\'USUARIS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(557, 153);
            this.button2.TabIndex = 1;
            this.button2.Text = "GESTIÓ DE PROJECTES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(557, 153);
            this.button3.TabIndex = 2;
            this.button3.Text = "GESTIÓ DEL JSON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RUTA DEL JSON DE USUARIOS";
            // 
            // rutaUsuariosBox
            // 
            this.rutaUsuariosBox.Enabled = false;
            this.rutaUsuariosBox.Location = new System.Drawing.Point(289, 65);
            this.rutaUsuariosBox.Name = "rutaUsuariosBox";
            this.rutaUsuariosBox.Size = new System.Drawing.Size(640, 20);
            this.rutaUsuariosBox.TabIndex = 4;
            // 
            // jsonUsersButton
            // 
            this.jsonUsersButton.Location = new System.Drawing.Point(964, 62);
            this.jsonUsersButton.Name = "jsonUsersButton";
            this.jsonUsersButton.Size = new System.Drawing.Size(75, 23);
            this.jsonUsersButton.TabIndex = 5;
            this.jsonUsersButton.Text = "...";
            this.jsonUsersButton.UseVisualStyleBackColor = true;
            this.jsonUsersButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RUTA DEL JSON DE PROYECTOS";
            // 
            // rutaProyectosBox
            // 
            this.rutaProyectosBox.Enabled = false;
            this.rutaProyectosBox.Location = new System.Drawing.Point(289, 122);
            this.rutaProyectosBox.Name = "rutaProyectosBox";
            this.rutaProyectosBox.Size = new System.Drawing.Size(640, 20);
            this.rutaProyectosBox.TabIndex = 7;
            // 
            // jsonProjectsButton
            // 
            this.jsonProjectsButton.Location = new System.Drawing.Point(964, 119);
            this.jsonProjectsButton.Name = "jsonProjectsButton";
            this.jsonProjectsButton.Size = new System.Drawing.Size(75, 23);
            this.jsonProjectsButton.TabIndex = 8;
            this.jsonProjectsButton.Text = "...";
            this.jsonProjectsButton.UseVisualStyleBackColor = true;
            this.jsonProjectsButton.Click += new System.EventHandler(this.jsonProjectsButton_Click);
            // 
            // userimportjson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 700);
            this.Controls.Add(this.jsonProjectsButton);
            this.Controls.Add(this.rutaProyectosBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jsonUsersButton);
            this.Controls.Add(this.rutaUsuariosBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "userimportjson";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rutaUsuariosBox;
        private System.Windows.Forms.Button jsonUsersButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rutaProyectosBox;
        private System.Windows.Forms.Button jsonProjectsButton;
    }
}