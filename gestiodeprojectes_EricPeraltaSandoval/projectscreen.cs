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

        //Incluye las listas de proyectos, tareas, subtareas y usuarios.
        List<project> projectList;
        List<task> taskList;
        List<subtask> subtaskList;
        List<user> userList;

        //Al incializar, inicializa automáticamente los JSONs según las rutas.
        //Guarda los usuarios y los proyectos en las List(UserList) y List(projectList), respectivamente.
        //Muestra en el dataGridView(dataGridProyects) los proyectos de projectList, en las comboBox de usuarios y proyectos
        //cada instancia de userList y projectList.
        public projectscreen(string jsonUsersPath, string jsonProjectsPath)
        {
            InitializeComponent();

            rutaUsuariosBox.Text = jsonUsersPath;
            textBoxRuta.Text = jsonProjectsPath;

            JArray jarrayusers = JArray.Parse(File.ReadAllText(rutaUsuariosBox.Text, Encoding.Default));
            JArray jarrayprojects = JArray.Parse(File.ReadAllText(textBoxRuta.Text, Encoding.Default));

            userList = jarrayusers.ToObject<List<user>>();
            projectList = jarrayprojects.ToObject<List<project>>();


            usuarioTareaBox.DataSource = null;
            usuarioTareaBox.DataSource = userList;
            usuarioTareaBox.DisplayMember = "Name";

            subtareaUsuarioBox.DataSource = null;
            subtareaUsuarioBox.DataSource = userList;
            subtareaUsuarioBox.DisplayMember = "Name";

            dataGridProjects.DataSource = null;
            dataGridProjects.DataSource = projectList;

            projectComboBox.DataSource = null;
            projectComboBox.DataSource = projectList;
            projectComboBox.DisplayMember = "Name";

        }

        //Permite cambiar al form(userScreen), y oculta el actual.
        //Envia las rutas de los JSON de usuarios y proyectos para su automatización.
        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userscreen userscreen = new userscreen(rutaUsuariosBox.Text, textBoxRuta.Text);

            userscreen.Show();
            this.Hide();
        }

        //Permite cambiar al form(jsonScreen), y oculta el actual.
        //Envia las rutas de los JSON de usuarios y proyectos para su automatización.
        private void gestiónDelJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonscreen jsonscreen = new jsonscreen(rutaUsuariosBox.Text, textBoxRuta.Text);

            jsonscreen.Show();
            this.Hide();

        }

        //Cierra el programa.
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Permite cambiar el form de usuarios, mediante OpenFileDialog, pudiendo escoger el archivo JSON.
        //Actualiza la información del dataGridView(dataGridProyects) y del comboBox(projectComboBox)
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

        //Permite crear un proyecto.
        //Verifica que el JSON de proyectos esté vinculado, y que los campos no estén vacios.
        //Crea el project(newProject), con los atributos de las textBox correspondientes (projectNameBox, projectDescriptionBox).
        //Actualiza el JSON, el tablón de proyectos y el comboBox de proyectos.
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
            if (projectList.Count == 0)
            {
                project.projectId = 1;
            }
            else {
                int lastprojectId = projectList.Last().projectId;
                project.projectId = lastprojectId + 1;
            }
         
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

        //Permite borrar un proyecto.
        //Verfica que haya un proyecto seleccionado en el comboBox(projectComboBox).
        //Actualiza los indices de la lista de proyectos para que estén en ordenNumérico (1,2,3...). En caso de borrar un intermedio, se actualizan
        //los indices para que no hayan vacios (evitando tener 1,2,4).
        //Actualiza el JSON, el tablón de proyectos y el comboBox de proyectos.
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

        //Permite cargar las tareas de un proyecto.
        //Verifica el comboBox(projectSelectedItem) tenga un proyecto elegido.
        //Al realizar la acción, comprueba si tiene tareas. En caso contrario, se le dice al usuario.
        //Actualiza el dataGridView(taskGridView) y el comboBox(taskListComboBox)
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
                MessageBox.Show("El proyecto seleccionado no tiene tareas asociadas. Recuerde que puede añadir tareas cuando desee.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Permite crear tareas.
        //Verfica que haya un proyecto elegido, que los campos estén enteros y que la fecha final no sea anterior a la inicial.
        //En caso de que el proyecto no tenga lista de tareas, crea una vacia, la vincula y añade la tarea nueva.
        //Al finalizar, actualiza el tablón de tareasy el comboBox(taskListComboBox), que permite seleccionar una tarea.
        //Indica el proyecto que está siendo modificado en el label()
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

            DateTime startDate = fechaInicioTareaBox.Value;
            DateTime endDate = fechaFinalTareaBox.Value;

            if (endDate <= startDate)
            {
                MessageBox.Show("La fecha final debe ser posterior a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            descripcionTareaBox.Clear();
            
            proyectoElegidoLabel.Text = selectedProject.name;

            MessageBox.Show("La tarea ha sido añadida correctamente al proyecto.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Permite cambiar el JSON de usuarios, mediante OpenFileDialog, permitiendo la selección del archivo.
        //Actualiza las comboBox de usuarios.
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

        //Permite seleccionar una tarea y mostrar su lista de subtareas,
        //Verifica que la comboBox(taskListComboBox) tenga una tarea.
        //En caso de que la tarea elegida no tenga subtareas, se le comunica al usuario.
        //Actualiza el dataGridView(subtaskGridView)
        //Indica la tarea que está siendo modificada en el label(tareaElegidaLabel).
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

        //Permite crear subtareas.
        //Verifica que el comboBox(taskListComboBox) tenga una tarea, que todos los campos estén completos y que la fecha de final no sea
        //anterior a la inicial.
        //Al finalizar, incluye la subtarea a la lista de subtareas de la tarea a modificar. En caso de que no tenga, se crea una nueva, se inicializa
        //y se incluye la nueva subtarea.
        //Actualiza el tablón de subtareas.
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

            DateTime startDate = startDateSubtareaBox.Value;
            DateTime endDate = endDateSubtareaBox.Value;

            if (endDate <= startDate)
            {
                MessageBox.Show("La fecha final debe ser posterior a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            descripcionSubtareaBox.Clear();

            MessageBox.Show("La subtarea ha sido añadida correctamente a la tarea del proyecto.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
