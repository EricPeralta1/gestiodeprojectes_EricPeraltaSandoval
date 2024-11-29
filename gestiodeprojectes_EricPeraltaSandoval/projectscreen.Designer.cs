namespace gestiodeprojectes_EricPeraltaSandoval
{
    partial class projectscreen
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
            this.borrarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.elegirProyectoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.projectDescriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.projectNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaFinalTareaBox = new System.Windows.Forms.DateTimePicker();
            this.fechaInicioTareaBox = new System.Windows.Forms.DateTimePicker();
            this.tareaEstadoBox = new System.Windows.Forms.ComboBox();
            this.usuarioTareaBox = new System.Windows.Forms.ComboBox();
            this.crearTareaButton = new System.Windows.Forms.Button();
            this.descripcionTareaBox = new System.Windows.Forms.TextBox();
            this.nombreTareaBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selectTaskButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tasksListComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.endDateSubtareaBox = new System.Windows.Forms.DateTimePicker();
            this.startDateSubtareaBox = new System.Windows.Forms.DateTimePicker();
            this.estadoSubtareaBox = new System.Windows.Forms.ComboBox();
            this.crearSubtareaBox = new System.Windows.Forms.Button();
            this.subtareaUsuarioBox = new System.Windows.Forms.ComboBox();
            this.descripcionSubtareaBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.subtareaNombreBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tareaElegidaLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridProjects = new System.Windows.Forms.DataGridView();
            this.proyectoElegidoLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDelJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.subtaskGridView = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rutaUsuariosBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtaskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // borrarButton
            // 
            this.borrarButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.borrarButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarButton.Location = new System.Drawing.Point(359, 385);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(111, 23);
            this.borrarButton.TabIndex = 12;
            this.borrarButton.Text = "BORRAR";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(109, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Elige un proyecto:";
            // 
            // projectComboBox
            // 
            this.projectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(227, 344);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(329, 21);
            this.projectComboBox.TabIndex = 10;
            // 
            // elegirProyectoButton
            // 
            this.elegirProyectoButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.elegirProyectoButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegirProyectoButton.Location = new System.Drawing.Point(167, 385);
            this.elegirProyectoButton.Name = "elegirProyectoButton";
            this.elegirProyectoButton.Size = new System.Drawing.Size(111, 23);
            this.elegirProyectoButton.TabIndex = 9;
            this.elegirProyectoButton.Text = "SELECCIONAR";
            this.elegirProyectoButton.UseVisualStyleBackColor = true;
            this.elegirProyectoButton.Click += new System.EventHandler(this.elegirProyectoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "MOSTRAR TAREAS DEL PROYECTO | ELEGIR PROYECTO";
            // 
            // createProjectButton
            // 
            this.createProjectButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.createProjectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProjectButton.Location = new System.Drawing.Point(235, 267);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(134, 23);
            this.createProjectButton.TabIndex = 8;
            this.createProjectButton.Text = "CREAR";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // projectDescriptionBox
            // 
            this.projectDescriptionBox.Location = new System.Drawing.Point(268, 230);
            this.projectDescriptionBox.Name = "projectDescriptionBox";
            this.projectDescriptionBox.Size = new System.Drawing.Size(288, 20);
            this.projectDescriptionBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción del proyecto:";
            // 
            // projectNameBox
            // 
            this.projectNameBox.Location = new System.Drawing.Point(268, 193);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(288, 20);
            this.projectNameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREAR PROYECTO";
            // 
            // fechaFinalTareaBox
            // 
            this.fechaFinalTareaBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinalTareaBox.Location = new System.Drawing.Point(165, 599);
            this.fechaFinalTareaBox.Name = "fechaFinalTareaBox";
            this.fechaFinalTareaBox.Size = new System.Drawing.Size(200, 20);
            this.fechaFinalTareaBox.TabIndex = 22;
            this.fechaFinalTareaBox.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // fechaInicioTareaBox
            // 
            this.fechaInicioTareaBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicioTareaBox.Location = new System.Drawing.Point(164, 573);
            this.fechaInicioTareaBox.Name = "fechaInicioTareaBox";
            this.fechaInicioTareaBox.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioTareaBox.TabIndex = 21;
            this.fechaInicioTareaBox.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // tareaEstadoBox
            // 
            this.tareaEstadoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tareaEstadoBox.FormattingEnabled = true;
            this.tareaEstadoBox.Items.AddRange(new object[] {
            "Disponible",
            "En procés",
            "Acabado"});
            this.tareaEstadoBox.Location = new System.Drawing.Point(166, 546);
            this.tareaEstadoBox.Name = "tareaEstadoBox";
            this.tareaEstadoBox.Size = new System.Drawing.Size(198, 21);
            this.tareaEstadoBox.TabIndex = 20;
            // 
            // usuarioTareaBox
            // 
            this.usuarioTareaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usuarioTareaBox.FormattingEnabled = true;
            this.usuarioTareaBox.Location = new System.Drawing.Point(166, 518);
            this.usuarioTareaBox.Name = "usuarioTareaBox";
            this.usuarioTareaBox.Size = new System.Drawing.Size(198, 21);
            this.usuarioTareaBox.TabIndex = 13;
            // 
            // crearTareaButton
            // 
            this.crearTareaButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearTareaButton.Image = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.crearTareaButton.Location = new System.Drawing.Point(422, 542);
            this.crearTareaButton.Name = "crearTareaButton";
            this.crearTareaButton.Size = new System.Drawing.Size(124, 47);
            this.crearTareaButton.TabIndex = 5;
            this.crearTareaButton.Text = "CREAR";
            this.crearTareaButton.UseVisualStyleBackColor = true;
            this.crearTareaButton.Click += new System.EventHandler(this.crearTareaButton_Click);
            // 
            // descripcionTareaBox
            // 
            this.descripcionTareaBox.Location = new System.Drawing.Point(387, 501);
            this.descripcionTareaBox.Name = "descripcionTareaBox";
            this.descripcionTareaBox.Size = new System.Drawing.Size(199, 20);
            this.descripcionTareaBox.TabIndex = 19;
            // 
            // nombreTareaBox
            // 
            this.nombreTareaBox.Location = new System.Drawing.Point(166, 489);
            this.nombreTareaBox.Name = "nombreTareaBox";
            this.nombreTareaBox.Size = new System.Drawing.Size(199, 20);
            this.nombreTareaBox.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 484);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(121, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "Descripción de la tarea:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 602);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fecha de final:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fecha de inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Estado de la tarea:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Usuario asignado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre de la tarea:";
            // 
            // selectTaskButton
            // 
            this.selectTaskButton.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.selectTaskButton.Location = new System.Drawing.Point(250, 708);
            this.selectTaskButton.Name = "selectTaskButton";
            this.selectTaskButton.Size = new System.Drawing.Size(120, 23);
            this.selectTaskButton.TabIndex = 20;
            this.selectTaskButton.Text = "SELECCIONAR";
            this.selectTaskButton.UseVisualStyleBackColor = true;
            this.selectTaskButton.Click += new System.EventHandler(this.selectTaskButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(145, 682);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 14);
            this.label20.TabIndex = 11;
            this.label20.Text = "Elige una tarea";
            // 
            // tasksListComboBox
            // 
            this.tasksListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksListComboBox.FormattingEnabled = true;
            this.tasksListComboBox.Location = new System.Drawing.Point(244, 679);
            this.tasksListComboBox.Name = "tasksListComboBox";
            this.tasksListComboBox.Size = new System.Drawing.Size(261, 21);
            this.tasksListComboBox.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(217, 647);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(188, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "ELEGIR TAREA | MOSTRAR SUBTAREAS";
            // 
            // endDateSubtareaBox
            // 
            this.endDateSubtareaBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateSubtareaBox.Location = new System.Drawing.Point(163, 930);
            this.endDateSubtareaBox.Name = "endDateSubtareaBox";
            this.endDateSubtareaBox.Size = new System.Drawing.Size(200, 20);
            this.endDateSubtareaBox.TabIndex = 34;
            // 
            // startDateSubtareaBox
            // 
            this.startDateSubtareaBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateSubtareaBox.Location = new System.Drawing.Point(162, 894);
            this.startDateSubtareaBox.MinDate = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            this.startDateSubtareaBox.Name = "startDateSubtareaBox";
            this.startDateSubtareaBox.Size = new System.Drawing.Size(200, 20);
            this.startDateSubtareaBox.TabIndex = 33;
            this.startDateSubtareaBox.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // estadoSubtareaBox
            // 
            this.estadoSubtareaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoSubtareaBox.FormattingEnabled = true;
            this.estadoSubtareaBox.Items.AddRange(new object[] {
            "Disponible",
            "En procés",
            "Acabado"});
            this.estadoSubtareaBox.Location = new System.Drawing.Point(163, 862);
            this.estadoSubtareaBox.Name = "estadoSubtareaBox";
            this.estadoSubtareaBox.Size = new System.Drawing.Size(198, 21);
            this.estadoSubtareaBox.TabIndex = 22;
            // 
            // crearSubtareaBox
            // 
            this.crearSubtareaBox.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.buttonbackground;
            this.crearSubtareaBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearSubtareaBox.Location = new System.Drawing.Point(422, 850);
            this.crearSubtareaBox.Name = "crearSubtareaBox";
            this.crearSubtareaBox.Size = new System.Drawing.Size(124, 47);
            this.crearSubtareaBox.TabIndex = 20;
            this.crearSubtareaBox.Text = "CREAR";
            this.crearSubtareaBox.UseVisualStyleBackColor = true;
            this.crearSubtareaBox.Click += new System.EventHandler(this.crearSubtareaBox_Click);
            // 
            // subtareaUsuarioBox
            // 
            this.subtareaUsuarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtareaUsuarioBox.FormattingEnabled = true;
            this.subtareaUsuarioBox.Location = new System.Drawing.Point(163, 832);
            this.subtareaUsuarioBox.Name = "subtareaUsuarioBox";
            this.subtareaUsuarioBox.Size = new System.Drawing.Size(198, 21);
            this.subtareaUsuarioBox.TabIndex = 21;
            // 
            // descripcionSubtareaBox
            // 
            this.descripcionSubtareaBox.Location = new System.Drawing.Point(383, 815);
            this.descripcionSubtareaBox.Name = "descripcionSubtareaBox";
            this.descripcionSubtareaBox.Size = new System.Drawing.Size(199, 20);
            this.descripcionSubtareaBox.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(57, 805);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 14);
            this.label19.TabIndex = 22;
            this.label19.Text = "Nombre de la tarea:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(65, 834);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 14);
            this.label18.TabIndex = 23;
            this.label18.Text = "Usuario asignado:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(61, 866);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 14);
            this.label17.TabIndex = 24;
            this.label17.Text = "Estado de la tarea:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(75, 898);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 14);
            this.label16.TabIndex = 25;
            this.label16.Text = "Fecha de inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(80, 932);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 14);
            this.label15.TabIndex = 26;
            this.label15.Text = "Fecha de final:";
            // 
            // subtareaNombreBox
            // 
            this.subtareaNombreBox.Location = new System.Drawing.Point(163, 802);
            this.subtareaNombreBox.Name = "subtareaNombreBox";
            this.subtareaNombreBox.Size = new System.Drawing.Size(199, 20);
            this.subtareaNombreBox.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(384, 796);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(121, 14);
            this.label14.TabIndex = 27;
            this.label14.Text = "Descripción de la tarea:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tareaElegidaLabel
            // 
            this.tareaElegidaLabel.AutoSize = true;
            this.tareaElegidaLabel.BackColor = System.Drawing.Color.Transparent;
            this.tareaElegidaLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareaElegidaLabel.Location = new System.Drawing.Point(356, 768);
            this.tareaElegidaLabel.Name = "tareaElegidaLabel";
            this.tareaElegidaLabel.Size = new System.Drawing.Size(86, 14);
            this.tareaElegidaLabel.TabIndex = 4;
            this.tareaElegidaLabel.Text = "TAREAEJEMPLO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 768);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "CREANDO SUBTAREAS DE:";
            // 
            // dataGridProjects
            // 
            this.dataGridProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjects.Location = new System.Drawing.Point(701, 159);
            this.dataGridProjects.Name = "dataGridProjects";
            this.dataGridProjects.Size = new System.Drawing.Size(914, 249);
            this.dataGridProjects.TabIndex = 0;
            // 
            // proyectoElegidoLabel
            // 
            this.proyectoElegidoLabel.AutoSize = true;
            this.proyectoElegidoLabel.BackColor = System.Drawing.Color.Transparent;
            this.proyectoElegidoLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyectoElegidoLabel.Location = new System.Drawing.Point(337, 453);
            this.proyectoElegidoLabel.Name = "proyectoElegidoLabel";
            this.proyectoElegidoLabel.Size = new System.Drawing.Size(108, 14);
            this.proyectoElegidoLabel.TabIndex = 5;
            this.proyectoElegidoLabel.Text = "PROYECTOEJEMPLO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "AÑADIENDO TAREAS A :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.navigatorbarbackground;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1664, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.gestiónDelJSONToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.oPCIONESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            this.oPCIONESToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.oPCIONESToolStripMenuItem.Text = "MENÚ DE GESTIÓN";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gestiónToolStripMenuItem.Text = "Gestión de usuarios";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
            // 
            // gestiónDelJSONToolStripMenuItem
            // 
            this.gestiónDelJSONToolStripMenuItem.Name = "gestiónDelJSONToolStripMenuItem";
            this.gestiónDelJSONToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gestiónDelJSONToolStripMenuItem.Text = "Gestión del JSON";
            this.gestiónDelJSONToolStripMenuItem.Click += new System.EventHandler(this.gestiónDelJSONToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // taskGridView
            // 
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGridView.Location = new System.Drawing.Point(699, 455);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.Size = new System.Drawing.Size(914, 269);
            this.taskGridView.TabIndex = 6;
            // 
            // subtaskGridView
            // 
            this.subtaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subtaskGridView.Location = new System.Drawing.Point(701, 765);
            this.subtaskGridView.Name = "subtaskGridView";
            this.subtaskGridView.Size = new System.Drawing.Size(914, 185);
            this.subtaskGridView.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(235, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(213, 16);
            this.label24.TabIndex = 8;
            this.label24.Text = "RUTA DEL JSON DE PROYECTOS";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Location = new System.Drawing.Point(459, 43);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(863, 20);
            this.textBoxRuta.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1344, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1344, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rutaUsuariosBox
            // 
            this.rutaUsuariosBox.Enabled = false;
            this.rutaUsuariosBox.Location = new System.Drawing.Point(459, 83);
            this.rutaUsuariosBox.Name = "rutaUsuariosBox";
            this.rutaUsuariosBox.Size = new System.Drawing.Size(863, 20);
            this.rutaUsuariosBox.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(247, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(199, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "RUTA DEL JSON DE USUARIOS";
            // 
            // projectscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestiodeprojectes_EricPeraltaSandoval.Properties.Resources.projectscreenbackground;
            this.ClientSize = new System.Drawing.Size(1664, 977);
            this.Controls.Add(this.endDateSubtareaBox);
            this.Controls.Add(this.selectTaskButton);
            this.Controls.Add(this.startDateSubtareaBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.estadoSubtareaBox);
            this.Controls.Add(this.tasksListComboBox);
            this.Controls.Add(this.crearSubtareaBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.subtareaUsuarioBox);
            this.Controls.Add(this.tareaElegidaLabel);
            this.Controls.Add(this.descripcionSubtareaBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.fechaFinalTareaBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.fechaInicioTareaBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.proyectoElegidoLabel);
            this.Controls.Add(this.subtareaNombreBox);
            this.Controls.Add(this.tareaEstadoBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioTareaBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.crearTareaButton);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.descripcionTareaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreTareaBox);
            this.Controls.Add(this.elegirProyectoButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.projectDescriptionBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.projectNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rutaUsuariosBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.subtaskGridView);
            this.Controls.Add(this.taskGridView);
            this.Controls.Add(this.dataGridProjects);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "projectscreen";
            this.Text = "GESTIÓN DE PROJECTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtaskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.Button elegirProyectoButton;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.TextBox projectDescriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button crearSubtareaBox;
        private System.Windows.Forms.TextBox descripcionSubtareaBox;
        private System.Windows.Forms.TextBox subtareaNombreBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button crearTareaButton;
        private System.Windows.Forms.TextBox descripcionTareaBox;
        private System.Windows.Forms.TextBox nombreTareaBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDelJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.DataGridView subtaskGridView;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox tasksListComboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label tareaElegidaLabel;
        private System.Windows.Forms.Label proyectoElegidoLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button selectTaskButton;
        private System.Windows.Forms.ComboBox tareaEstadoBox;
        private System.Windows.Forms.ComboBox usuarioTareaBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rutaUsuariosBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox estadoSubtareaBox;
        private System.Windows.Forms.ComboBox subtareaUsuarioBox;
        private System.Windows.Forms.DateTimePicker startDateSubtareaBox;
        private System.Windows.Forms.DateTimePicker fechaFinalTareaBox;
        private System.Windows.Forms.DateTimePicker fechaInicioTareaBox;
        private System.Windows.Forms.DateTimePicker endDateSubtareaBox;
    }
}