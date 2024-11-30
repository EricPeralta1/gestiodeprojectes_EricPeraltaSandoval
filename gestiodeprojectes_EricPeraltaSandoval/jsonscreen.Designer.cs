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
            this.GuardarUsersJson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomUsersJsonBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GuardarProjectsJson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nomProjectsJsonBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardarUsersJson
            // 
            this.GuardarUsersJson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarUsersJson.Image = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.GuardarUsersJson.Location = new System.Drawing.Point(466, 87);
            this.GuardarUsersJson.Name = "GuardarUsersJson";
            this.GuardarUsersJson.Size = new System.Drawing.Size(147, 42);
            this.GuardarUsersJson.TabIndex = 6;
            this.GuardarUsersJson.Text = "GUARDAR CAMBIOS DEL JSON";
            this.GuardarUsersJson.UseVisualStyleBackColor = true;
            this.GuardarUsersJson.Click += new System.EventHandler(this.GuardarUsersJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce un nuevo nombre:";
            // 
            // nomUsersJsonBox
            // 
            this.nomUsersJsonBox.Location = new System.Drawing.Point(235, 99);
            this.nomUsersJsonBox.Name = "nomUsersJsonBox";
            this.nomUsersJsonBox.Size = new System.Drawing.Size(217, 20);
            this.nomUsersJsonBox.TabIndex = 1;
            // 
            // GuardarProjectsJson
            // 
            this.GuardarProjectsJson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarProjectsJson.Image = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.GuardarProjectsJson.Location = new System.Drawing.Point(481, 260);
            this.GuardarProjectsJson.Name = "GuardarProjectsJson";
            this.GuardarProjectsJson.Size = new System.Drawing.Size(132, 39);
            this.GuardarProjectsJson.TabIndex = 8;
            this.GuardarProjectsJson.Text = "GUARDAR CAMBIOS DEL JSON";
            this.GuardarProjectsJson.UseVisualStyleBackColor = true;
            this.GuardarProjectsJson.Click += new System.EventHandler(this.GuardarProjectsJson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introduce un nuevo nombre:";
            // 
            // nomProjectsJsonBox
            // 
            this.nomProjectsJsonBox.Location = new System.Drawing.Point(235, 269);
            this.nomProjectsJsonBox.Name = "nomProjectsJsonBox";
            this.nomProjectsJsonBox.Size = new System.Drawing.Size(217, 20);
            this.nomProjectsJsonBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.navigatorbarbackground;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.gestionDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.oPCIONESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Image = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.returnButton.Location = new System.Drawing.Point(241, 387);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(219, 23);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "VOLVER A LA PANTALLA DE INICIO";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // jsonscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.jsonscreenbackground;
            this.ClientSize = new System.Drawing.Size(698, 422);
            this.Controls.Add(this.GuardarUsersJson);
            this.Controls.Add(this.GuardarProjectsJson);
            this.Controls.Add(this.nomUsersJsonBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.nomProjectsJsonBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "jsonscreen";
            this.Text = "GESTIÓN DE JSON";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomUsersJsonBox;
        private System.Windows.Forms.TextBox nomProjectsJsonBox;
        private System.Windows.Forms.Button GuardarUsersJson;
        private System.Windows.Forms.Button GuardarProjectsJson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button returnButton;
    }
}