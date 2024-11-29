namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class userscreen
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailuserbox = new System.Windows.Forms.TextBox();
            this.passworduserbox = new System.Windows.Forms.TextBox();
            this.surnameuserbox = new System.Windows.Forms.TextBox();
            this.nameuserbox = new System.Windows.Forms.TextBox();
            this.userSelectBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.EDITAR = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDelJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(148, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(131, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(160, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(148, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre:";
            // 
            // emailuserbox
            // 
            this.emailuserbox.Location = new System.Drawing.Point(214, 287);
            this.emailuserbox.Name = "emailuserbox";
            this.emailuserbox.Size = new System.Drawing.Size(199, 20);
            this.emailuserbox.TabIndex = 3;
            // 
            // passworduserbox
            // 
            this.passworduserbox.Location = new System.Drawing.Point(214, 326);
            this.passworduserbox.Name = "passworduserbox";
            this.passworduserbox.PasswordChar = '*';
            this.passworduserbox.Size = new System.Drawing.Size(199, 20);
            this.passworduserbox.TabIndex = 2;
            // 
            // surnameuserbox
            // 
            this.surnameuserbox.Location = new System.Drawing.Point(214, 243);
            this.surnameuserbox.Name = "surnameuserbox";
            this.surnameuserbox.Size = new System.Drawing.Size(199, 20);
            this.surnameuserbox.TabIndex = 1;
            this.surnameuserbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameuserbox
            // 
            this.nameuserbox.Location = new System.Drawing.Point(214, 203);
            this.nameuserbox.Name = "nameuserbox";
            this.nameuserbox.Size = new System.Drawing.Size(199, 20);
            this.nameuserbox.TabIndex = 0;
            // 
            // userSelectBox
            // 
            this.userSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userSelectBox.FormattingEnabled = true;
            this.userSelectBox.Location = new System.Drawing.Point(921, 210);
            this.userSelectBox.Name = "userSelectBox";
            this.userSelectBox.Size = new System.Drawing.Size(226, 21);
            this.userSelectBox.TabIndex = 3;
            this.userSelectBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(802, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usuario elegido";
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.eliminarButton.Location = new System.Drawing.Point(830, 319);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(248, 38);
            this.eliminarButton.TabIndex = 4;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EDITAR
            // 
            this.EDITAR.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.EDITAR.Location = new System.Drawing.Point(830, 265);
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Size = new System.Drawing.Size(248, 35);
            this.EDITAR.TabIndex = 3;
            this.EDITAR.Text = "EDITAR";
            this.EDITAR.UseVisualStyleBackColor = true;
            this.EDITAR.Click += new System.EventHandler(this.EDITAR_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(38, 424);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(1187, 276);
            this.dataGridUsers.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.navigatorbarbackground;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.oPCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeToolStripMenuItem,
            this.gestiónDelJSONToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.oPCIONESToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            this.oPCIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.oPCIONESToolStripMenuItem.Text = "MENÚ DE GESTIÓN";
            // 
            // gestionDeToolStripMenuItem
            // 
            this.gestionDeToolStripMenuItem.Name = "gestionDeToolStripMenuItem";
            this.gestionDeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestionDeToolStripMenuItem.Text = "Gestión de proyectos";
            this.gestionDeToolStripMenuItem.Click += new System.EventHandler(this.gestionDeToolStripMenuItem_Click);
            // 
            // gestiónDelJSONToolStripMenuItem
            // 
            this.gestiónDelJSONToolStripMenuItem.Name = "gestiónDelJSONToolStripMenuItem";
            this.gestiónDelJSONToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestiónDelJSONToolStripMenuItem.Text = "Gestión del JSON";
            this.gestiónDelJSONToolStripMenuItem.Click += new System.EventHandler(this.gestiónDelJSONToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Location = new System.Drawing.Point(189, 61);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(865, 20);
            this.textBoxRuta.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1069, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(91, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "RUTA DEL JSON";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.button1.Location = new System.Drawing.Point(471, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "CREAR USUARIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.userscreenbackground;
            this.ClientSize = new System.Drawing.Size(1249, 730);
            this.Controls.Add(this.userSelectBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.EDITAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailuserbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passworduserbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.surnameuserbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nameuserbox);
            this.Name = "userscreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button EDITAR;
        private System.Windows.Forms.TextBox surnameuserbox;
        private System.Windows.Forms.TextBox nameuserbox;
        private System.Windows.Forms.TextBox emailuserbox;
        private System.Windows.Forms.TextBox passworduserbox;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox userSelectBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDelJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}