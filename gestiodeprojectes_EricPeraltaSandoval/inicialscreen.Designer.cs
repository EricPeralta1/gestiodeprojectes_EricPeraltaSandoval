﻿namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class inicialscreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicialscreen));
            this.createJSONButton = new System.Windows.Forms.Button();
            this.importJSONButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createJSONButton
            // 
            this.createJSONButton.Location = new System.Drawing.Point(237, 244);
            this.createJSONButton.Name = "createJSONButton";
            this.createJSONButton.Size = new System.Drawing.Size(664, 114);
            this.createJSONButton.TabIndex = 1;
            this.createJSONButton.Text = "CREAR JSON";
            this.createJSONButton.UseVisualStyleBackColor = true;
            this.createJSONButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // importJSONButton
            // 
            this.importJSONButton.Location = new System.Drawing.Point(269, 422);
            this.importJSONButton.Name = "importJSONButton";
            this.importJSONButton.Size = new System.Drawing.Size(664, 114);
            this.importJSONButton.TabIndex = 2;
            this.importJSONButton.Text = "IMPORTAR JSON";
            this.importJSONButton.UseVisualStyleBackColor = true;
            this.importJSONButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.createJSONButton);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1205, 666);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(44, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1122, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inicialscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 700);
            this.Controls.Add(this.importJSONButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "inicialscreen";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createJSONButton;
        private System.Windows.Forms.Button importJSONButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

