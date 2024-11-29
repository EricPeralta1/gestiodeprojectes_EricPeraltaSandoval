namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class jsonscreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuardarUsersJson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomUsersJsonBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GuardarProjectsJson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nomProjectsJsonBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuardarUsersJson);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nomUsersJsonBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EDITAR JSON: USUARIOS";
            // 
            // GuardarUsersJson
            // 
            this.GuardarUsersJson.Location = new System.Drawing.Point(441, 58);
            this.GuardarUsersJson.Name = "GuardarUsersJson";
            this.GuardarUsersJson.Size = new System.Drawing.Size(147, 23);
            this.GuardarUsersJson.TabIndex = 6;
            this.GuardarUsersJson.Text = "Guardar cambios del JSON";
            this.GuardarUsersJson.UseVisualStyleBackColor = true;
            this.GuardarUsersJson.Click += new System.EventHandler(this.GuardarUsersJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce un nuevo nombre:";
            // 
            // nomUsersJsonBox
            // 
            this.nomUsersJsonBox.Location = new System.Drawing.Point(175, 55);
            this.nomUsersJsonBox.Name = "nomUsersJsonBox";
            this.nomUsersJsonBox.Size = new System.Drawing.Size(217, 20);
            this.nomUsersJsonBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GuardarProjectsJson);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nomProjectsJsonBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EDTIAR JSON: PROYECTOS";
            // 
            // GuardarProjectsJson
            // 
            this.GuardarProjectsJson.Location = new System.Drawing.Point(441, 73);
            this.GuardarProjectsJson.Name = "GuardarProjectsJson";
            this.GuardarProjectsJson.Size = new System.Drawing.Size(150, 23);
            this.GuardarProjectsJson.TabIndex = 8;
            this.GuardarProjectsJson.Text = "Guardar cambios del JSON";
            this.GuardarProjectsJson.UseVisualStyleBackColor = true;
            this.GuardarProjectsJson.Click += new System.EventHandler(this.GuardarProjectsJson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introduce un nuevo nombre:";
            // 
            // nomProjectsJsonBox
            // 
            this.nomProjectsJsonBox.Location = new System.Drawing.Point(175, 70);
            this.nomProjectsJsonBox.Name = "nomProjectsJsonBox";
            this.nomProjectsJsonBox.Size = new System.Drawing.Size(217, 20);
            this.nomProjectsJsonBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.gestionDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            this.oPCIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.oPCIONESToolStripMenuItem.Text = "MENÚ DE GESTIÓN";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestiónToolStripMenuItem.Text = "Gestión de usuarios";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
            // 
            // gestionDeToolStripMenuItem
            // 
            this.gestionDeToolStripMenuItem.Name = "gestionDeToolStripMenuItem";
            this.gestionDeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestionDeToolStripMenuItem.Text = "Gestión de proyectos";
            this.gestionDeToolStripMenuItem.Click += new System.EventHandler(this.gestionDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "VOLVER A LA PANTALLA DE INICIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jsonscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "jsonscreen";
            this.Text = "jsonscreen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomUsersJsonBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nomProjectsJsonBox;
        private System.Windows.Forms.Button GuardarUsersJson;
        private System.Windows.Forms.Button GuardarProjectsJson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}