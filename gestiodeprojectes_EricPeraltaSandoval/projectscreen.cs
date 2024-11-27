using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class projectscreen : Form
    {

        List<project> projectList;
        List<task> taskList;
        List<subtask> subtaskList;
        List<user> userList;

        public projectscreen()
        {
            InitializeComponent();
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userscreen userscreen = new userscreen();
            userscreen.Show();
        }

        private void gestiónDelJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonscreen jsonscreen = new jsonscreen();

            jsonscreen.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRuta.Text = openFileDialog.FileName;
                JArray jarrayprojects = JArray.Parse(File.ReadAllText(textBoxRuta.Text, Encoding.Default));
                projectList = jarrayprojects.ToObject<List<project>>();

                dataGridProjects.DataSource = null;
                dataGridProjects.DataSource = projectList;

                projectComboBox.DataSource = null;
                projectComboBox.DataSource = projectList;
                projectComboBox.DisplayMember = "Name";
            }
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxRuta.Text))
            {
                MessageBox.Show("Selecciona un JSON de proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(projectNameBox.Text) || string.IsNullOrEmpty(projectDescriptionBox.Text))
            {
                MessageBox.Show("Rellena los campos, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            project project = new project();

            project.name = projectNameBox.Text;
            project.description = projectDescriptionBox.Text;
            int lastprojectId = projectList.Last().projectId;
            project.projectId = lastprojectId + 1;

            projectList.Add(project);

            File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString());

            dataGridProjects.DataSource = null;
            dataGridProjects.DataSource = projectList;

            projectNameBox.Clear();
            projectDescriptionBox.Clear();

            projectComboBox.DataSource = null;
            projectComboBox.DataSource = projectList;
            projectComboBox.DisplayMember = "Name";

            MessageBox.Show("El proyecto se ha creado y añadido satisfactoriamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            if (projectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userIndex = projectList.IndexOf((project)projectComboBox.SelectedItem);
            projectList.RemoveAt(userIndex);

            File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString());

            dataGridProjects.DataSource = null;
            dataGridProjects.DataSource = projectList;

            projectComboBox.DataSource = null;
            projectComboBox.DataSource = projectList;
            projectComboBox.DisplayMember = "Name";

            MessageBox.Show("Proyecto eliminado.", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void elegirProyectoButton_Click(object sender, EventArgs e)
        {
            if (projectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto para cargar las tareas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            project selectedProject = (project)projectComboBox.SelectedItem;

            taskList = selectedProject.tasks;

            if (selectedProject.tasks == null || selectedProject.tasks.Count == 0)
            {
                MessageBox.Show("El proyecto seleccionado no tiene tareas asociadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                taskGridView.DataSource = null;
                return;
            }

            taskGridView.DataSource = null;
            taskGridView.DataSource = selectedProject.tasks;


            tasksListComboBox.DataSource = null;
            tasksListComboBox.DataSource = taskList;
            tasksListComboBox.DisplayMember = "Name";

            subtaskGridView.DataSource = null;

            proyectoElegidoLabel.Text = selectedProject.name;
        }

        private void crearTareaButton_Click(object sender, EventArgs e)
        {
            if (projectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto en el que agregar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombreTareaBox.Text) || string.IsNullOrEmpty(tareaEstadoBox.Text) || string.IsNullOrEmpty(fechaInicioTareaBox.Text) || string.IsNullOrEmpty(fechaFinalTareaBox.Text) || string.IsNullOrEmpty(descripcionTareaBox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos de la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            task task = new task();

            task.name = nombreTareaBox.Text;
            task.taskUser = nombreTareaBox.Text;
            task.status = tareaEstadoBox.Text;
            task.startDate = fechaInicioTareaBox.Text;
            task.endDate = fechaFinalTareaBox.Text;
            task.description = descripcionTareaBox.Text;
            if (taskList == null)
            {
                task.taskId = 1;
            }
            else {
                int lasttaskId = taskList.Last().taskId;
                task.taskId = lasttaskId + 1;
            }

            project selectedProject = (project)projectComboBox.SelectedItem;

            if (selectedProject.tasks == null) {
                selectedProject.tasks = new List<task> { task };
            } else {
                selectedProject.tasks.Add(task);
            }

            File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString());

            taskGridView.DataSource = null;
            taskGridView.DataSource = selectedProject.tasks;

            tasksListComboBox.DataSource = null;
            tasksListComboBox.DataSource = selectedProject.tasks;

            nombreTareaBox.Clear();
            tareaEstadoBox.Items.Clear();
            fechaInicioTareaBox.Clear();
            fechaFinalTareaBox.Clear();
            descripcionTareaBox.Clear();

            MessageBox.Show("La tarea ha sido añadida correctamente al proyecto.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                rutaUsuariosBox.Text = openFileDialog.FileName;
                JArray jarrayusers = JArray.Parse(File.ReadAllText(rutaUsuariosBox.Text, Encoding.Default));
                userList = jarrayusers.ToObject<List<user>>();

                usuarioTareaBox.DataSource = null;
                usuarioTareaBox.DataSource = userList;
                usuarioTareaBox.DisplayMember = "Name";

                subtareaUsuarioBox.DataSource = null;
                subtareaUsuarioBox.DataSource = userList;
                subtareaUsuarioBox.DisplayMember = "Name";
            }
        }

        private void selectTaskButton_Click(object sender, EventArgs e)
        {

            if (tasksListComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea para cargar las subtareas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            project selectedProject = (project)projectComboBox.SelectedItem;

            taskList = selectedProject.tasks;

            if (selectedProject.tasks == null || selectedProject.tasks.Count == 0)
            {
                MessageBox.Show("El proyecto seleccionado no tiene subtareas asociadas. Puede crear subtareas cuando desee.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                taskGridView.DataSource = null;
                return;
            }

            task selectedTask = (task)tasksListComboBox.SelectedItem;

            subtaskList = selectedTask.subtasks;

            subtaskGridView.DataSource = null;
            subtaskGridView.DataSource = selectedTask.subtasks;

            tareaElegidaLabel.Text = selectedTask.name;
        }

        private void crearSubtareaBox_Click(object sender, EventArgs e)
        {
            if (tasksListComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una subtarea para empezar. Recuerda también tener un proyecto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(subtareaNombreBox.Text) || string.IsNullOrEmpty(estadoSubtareaBox.Text) || string.IsNullOrEmpty(startDateSubtareaBox.Text) || string.IsNullOrEmpty(endDateSubtareaBox.Text) || string.IsNullOrEmpty(descripcionSubtareaBox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos de la subtarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            subtask subtarea = new subtask();
            subtarea.name = subtareaNombreBox.Text;
            subtarea.subtaskUser = subtareaUsuarioBox.Text;
            subtarea.status = estadoSubtareaBox.Text;
            subtarea.startDate = startDateSubtareaBox.Text;
            subtarea.endDate = endDateSubtareaBox.Text;
            subtarea.description = descripcionSubtareaBox.Text;

            if (subtaskList == null)
            {
                subtarea.subtaskId = 1;
            } else {
                int lastSubtaskId = subtaskList.Last().subtaskId;
                subtarea.subtaskId = lastSubtaskId + 1;
            }

            project selectedProject = (project)projectComboBox.SelectedItem;

            task selectedTask = (task)tasksListComboBox.SelectedItem;
            if (selectedTask.subtasks == null)
            {
                selectedTask.subtasks = new List<subtask> { subtarea };
            }
            else
            {
                selectedTask.subtasks.Add(subtarea);
            }

            File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString());

            subtaskGridView.DataSource = null;
            subtaskGridView.DataSource = selectedTask.subtasks;

            nombreTareaBox.Clear();
            estadoSubtareaBox.Items.Clear();
            startDateSubtareaBox.Clear();
            endDateSubtareaBox.Clear();
            descripcionSubtareaBox.Clear();

            MessageBox.Show("La subtarea ha sido añadida correctamente a la tarea del proyecto.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
