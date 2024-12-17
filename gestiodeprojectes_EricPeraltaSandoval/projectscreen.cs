using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace gestiodeprojectes_EricPeraltaSandoval
{
    public partial class projectscreen : Form
    {

        /// <summary>
        ///Incluye las listas de proyectos, tareas, subtareas y usuarios, asi como el proyecto elegido y tarea elegido para su edición.
        /// </summary>
        List<project> projectList;
        List<task> taskList;
        List<subtask> subtaskList;
        List<user> userList;
        project selectedProject;
        task selectedTask;
        userscreen userscreen;
        jsonscreen jsonscreen;



        /// <summary>
        /// Al incializar,  automáticamente los JSONs según las rutas.
        /// Guarda los usuarios y los proyectos en las List(UserList) y List(projectList), respectivamente.
        ///Muestra en el dataGridView(dataGridProyects) los proyectos de projectList, en las comboBox de usuarios y proyectos
        ///cada instancia de userList y projectList.
        /// </summary>
        /// <param name="jsonUsersPath"></param>
        /// <param name="jsonProjectsPath"></param>
        public projectscreen(string jsonUsersPath, string jsonProjectsPath)
        {
            InitializeComponent();

            rutaUsuariosBox.Text = jsonUsersPath;
            textBoxRuta.Text = jsonProjectsPath;

            JArray jarrayusers = JArray.Parse(File.ReadAllText(rutaUsuariosBox.Text, Encoding.UTF8));
            JArray jarrayprojects = JArray.Parse(File.ReadAllText(textBoxRuta.Text, Encoding.UTF8));

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



        /// <summary>
        ///Permite cambiar al form(userScreen), y oculta el actual.
        ///Envia las rutas de los JSON de usuarios y proyectos para su automatización.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userscreen = new userscreen(rutaUsuariosBox.Text, textBoxRuta.Text);
            userscreen.Show();
            this.Hide();
        }


        /// <summary>
        ///Permite cambiar al form(jsonScreen), y oculta el actual.
        ///Envia las rutas de los JSON de usuarios y proyectos para su automatización.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestiónDelJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonscreen = new jsonscreen(rutaUsuariosBox.Text, textBoxRuta.Text);
            jsonscreen.Show();
            this.Hide();

        }

        /// <summary>
        ///Cierra el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        /// <summary>
        ///Permite cambiar el form de usuarios, mediante OpenFileDialog, pudiendo escoger el archivo JSON.
        ///Actualiza la información del dataGridView(dataGridProyects) y del comboBox(projectComboBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRuta.Text = openFileDialog.FileName;
                JArray jarrayprojects = JArray.Parse(File.ReadAllText(textBoxRuta.Text, Encoding.UTF8));
                projectList = jarrayprojects.ToObject<List<project>>();

                dataGridProjects.DataSource = null;
                dataGridProjects.DataSource = projectList;

                projectComboBox.DataSource = null;
                projectComboBox.DataSource = projectList;
                projectComboBox.DisplayMember = "Name";
            }
        }



        /// <summary>
        /// Permite crear un proyecto.
        ///Verifica que el JSON de proyectos esté vinculado, y que los campos no estén vacios.
        /// Crea el project(newProject), con los atributos de las textBox correspondientes (projectNameBox, projectDescriptionBox).
        ///Actualiza el JSON, el tablón de proyectos y el comboBox de proyectos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createProjectButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxRuta.Text))
            {
                MessageBox.Show("Selecciona un JSON de proyectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (string.IsNullOrEmpty(projectNameBox.Text) || string.IsNullOrEmpty(projectDescriptionBox.Text))
            {
                MessageBox.Show("Rellena los campos, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

                project project = new project();

                project.name = projectNameBox.Text;
                project.description = projectDescriptionBox.Text;
                if (projectList.Count == 0)
                {
                    project.projectId = 1;
                }
                else
                {
                    int lastprojectId = projectList.Last().projectId;
                    project.projectId = lastprojectId + 1;
                }

                projectList.Add(project);

                File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString(), Encoding.UTF8);

                string jsonContent = File.ReadAllText(textBoxRuta.Text, Encoding.UTF8);
                projectList = JArray.Parse(jsonContent).ToObject<List<project>>();

                dataGridProjects.DataSource = null;
                dataGridProjects.DataSource = projectList;

                projectNameBox.Clear();
                projectDescriptionBox.Clear();

                projectComboBox.DataSource = null;
                projectComboBox.DataSource = projectList;
                projectComboBox.DisplayMember = "Name";

                MessageBox.Show("El proyecto se ha creado y añadido satisfactoriamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        /// <summary>
        ///Permite borrar un proyecto.
        ///Verfica que haya un proyecto seleccionado en el comboBox(projectComboBox).
        ///Actualiza los indices de la lista de proyectos para que estén en ordenNumérico(1,2,3...). En caso de borrar un intermedio, se actualizan
        ///los indices para que no hayan vacios(evitando tener 1,2,4).
        ///Actualiza el JSON, el tablón de proyectos y el comboBox de proyectos.
        ///Requiere que se vuelva a elegir un proyecto nuevamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarButton_Click(object sender, EventArgs e)
        {
            if (projectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                DialogResult confirmErase = MessageBox.Show("Estás seguro de querer eliminarlo? ¡Se perderá para siempre!", "Confirmación", MessageBoxButtons.YesNo);

                if (confirmErase == DialogResult.Yes)
                {
                    int projectIndex = projectList.IndexOf((project)projectComboBox.SelectedItem);
                    projectList.RemoveAt(projectIndex);


                    for (int i = 0; i < projectList.Count; i++)
                    {
                        projectList[i].projectId = i + 1;
                    }

                    File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString(), Encoding.UTF8);

                    dataGridProjects.DataSource = null;
                    dataGridProjects.DataSource = projectList;
                    proyectoElegidoLabel.Text = "";

                    taskGridView.DataSource = null;
                    tareaElegidaLabel.Text = "";

                    subtaskGridView.DataSource = null;


                    projectComboBox.DataSource = null;
                    projectComboBox.DataSource = projectList;
                    projectComboBox.DisplayMember = "Name";

                    tasksListComboBox.DataSource = null;

                    subtaskList = null;
                    taskList = null;

                    MessageBox.Show("Proyecto eliminado. Recuerde volver a elegir un proyecto para añadir tareas.", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (confirmErase == DialogResult.No) {
                    MessageBox.Show("Eliminación cancelada.", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        /// <summary>
        ///Permite borrar una tarea.
        ///Verfica que haya una tarea seleccionada en el comboBox(taskListComboBox).
        ///Actualiza los indices de la lista de tareas para que estén en ordenNumérico (1,2,3...). En caso de borrar un intermedio, se actualizan
        ///los indices para que no hayan vacios (evitando tener 1,2,4).
        ///Actualiza el JSON, el tablón de tareas y el comboBox de tareas.
        ///Requiere que se vuelva a elegir una tarea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarTareaButton_Click(object sender, EventArgs e)
        {
            if (tasksListComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                DialogResult confirmErase = MessageBox.Show("Estás seguro de querer eliminarlo? ¡Se perderá para siempre!", "Confirmación", MessageBoxButtons.YesNo);

                if (confirmErase == DialogResult.Yes)
                {
                    int taskIndex = taskList.IndexOf(selectedTask);
                    taskList.RemoveAt(taskIndex);

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        taskList[i].taskId = i + 1;
                    }

                    selectedProject.tasks = taskList;


                    File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString(), Encoding.UTF8);

                    taskGridView.DataSource = null;
                    taskGridView.DataSource = taskList;

                    subtaskGridView.DataSource = null;
                    tareaElegidaLabel.Text = "";

                    subtaskList = null;

                    tasksListComboBox.DataSource = null;
                    tasksListComboBox.DataSource = taskList;
                    tasksListComboBox.DisplayMember = "Name";

                    MessageBox.Show("Tarea eliminada. Recuerda volver a elegir una tarea para añadir subtareas.", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (confirmErase == DialogResult.No) {
                    MessageBox.Show("Eliminación cancelada", "Operación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }


        /// <summary>
        ///Permite cargar las tareas de un proyecto.
        ///Verifica el comboBox(projectSelectedItem) tenga un proyecto elegido.
        ///Al realizar la acción, comprueba si tiene tareas. En caso contrario, se le dice al usuario.
        ///Actualiza el dataGridView(taskGridView) y el comboBox(taskListComboBox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void elegirProyectoButton_Click(object sender, EventArgs e)
        {
            if (projectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto para cargar las tareas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                selectedProject = (project)projectComboBox.SelectedItem;


                if (selectedProject.tasks == null || selectedProject.tasks.Count == 0)
                {
                    MessageBox.Show("El proyecto seleccionado no tiene tareas asociadas. Recuerde que puede añadir tareas cuando desee.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                taskList = selectedProject.tasks;



                    taskGridView.DataSource = null;
                    taskGridView.DataSource = selectedProject.tasks;

                    tasksListComboBox.DataSource = null;
                    tasksListComboBox.DataSource = taskList;
                    tasksListComboBox.DisplayMember = "Name";

                    subtaskGridView.DataSource = null;

                    proyectoElegidoLabel.Text = selectedProject.name;
                    tareaElegidaLabel.Text = "";

                    selectedTask = null;
                
            } 

        }


        /// <summary>
        ///Permite crear tareas.
        ///Verfica que haya un proyecto elegido, que los campos estén enteros y que la fecha final no sea anterior a la inicial.
        ///En caso de que el proyecto no tenga lista de tareas, crea una vacia, la vincula y añade la tarea nueva.
        ///Al finalizar, actualiza el tablón de tareasy el comboBox(taskListComboBox), que permite seleccionar una tarea.
        ///Indica el proyecto que está siendo modificado en el label()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearTareaButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = fechaInicioTareaBox.Value;
            DateTime endDate = fechaFinalTareaBox.Value;

            if (projectComboBox.SelectedItem == null || selectedProject == null)
            {
                MessageBox.Show("Por favor, selecciona un proyecto en el que agregar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(nombreTareaBox.Text) || string.IsNullOrEmpty(tareaEstadoBox.Text) || string.IsNullOrEmpty(fechaInicioTareaBox.Text) || string.IsNullOrEmpty(fechaFinalTareaBox.Text) || string.IsNullOrEmpty(descripcionTareaBox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos de la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (endDate < startDate)
            {
                MessageBox.Show("La fecha final debe ser posterior a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                task task = new task();

                task.name = nombreTareaBox.Text;
                task.taskUser = usuarioTareaBox.Text;
                task.status = tareaEstadoBox.Text;
                task.startDate = fechaInicioTareaBox.Text;
                task.endDate = fechaFinalTareaBox.Text;
                task.description = descripcionTareaBox.Text;
                if (taskList == null || taskList.Count == 0)
                {
                    task.taskId = 1;
                }
                else
                {
                    int lasttaskId = taskList.Last().taskId;
                    task.taskId = lasttaskId + 1;
                }

                if (selectedProject.tasks == null)
                {
                    selectedProject.tasks = new List<task> { task };
                }
                else
                {
                    selectedProject.tasks.Add(task);
                }

                File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString(), Encoding.UTF8);

                taskList = selectedProject.tasks;

                taskGridView.DataSource = null;
                taskGridView.DataSource = selectedProject.tasks;

                tasksListComboBox.DataSource = null;
                tasksListComboBox.DataSource = taskList;
                tasksListComboBox.DisplayMember = "Name";

                nombreTareaBox.Clear();
                descripcionTareaBox.Clear();

                proyectoElegidoLabel.Text = selectedProject.name;

                MessageBox.Show("La tarea ha sido añadida correctamente al proyecto.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Permite cambiar el JSON de usuarios, mediante OpenFileDialog, permitiendo la selección del archivo.
        /// Actualiza las comboBox de usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Ficheros JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                rutaUsuariosBox.Text = openFileDialog.FileName;
                JArray jarrayusers = JArray.Parse(File.ReadAllText(rutaUsuariosBox.Text, Encoding.UTF8));
                userList = jarrayusers.ToObject<List<user>>();

                usuarioTareaBox.DataSource = null;
                usuarioTareaBox.DataSource = userList;
                usuarioTareaBox.DisplayMember = "Name";

                subtareaUsuarioBox.DataSource = null;
                subtareaUsuarioBox.DataSource = userList;
                subtareaUsuarioBox.DisplayMember = "Name";
            }
        }



        /// <summary>
        ///Permite seleccionar una tarea y mostrar su lista de subtareas,
        ///Verifica que la comboBox(taskListComboBox) tenga una tarea.
        ///En caso de que la tarea elegida no tenga subtareas, se le comunica al usuario.
        ///Actualiza el dataGridView(subtaskGridView)
        ///Indica la tarea que está siendo modificada en el label(tareaElegidaLabel).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectTaskButton_Click(object sender, EventArgs e)
        {

            if (tasksListComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea para cargar las subtareas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                taskList = selectedProject.tasks;
                if (selectedProject.tasks == null || selectedProject.tasks.Count == 0)
                {
                    MessageBox.Show("El proyecto seleccionado no tiene subtareas asociadas. Puede crear subtareas cuando desee.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    taskGridView.DataSource = null;
                } 
                    selectedTask = (task)tasksListComboBox.SelectedItem;

                    subtaskList = selectedTask.subtasks;

                    subtaskGridView.DataSource = null;
                    subtaskGridView.DataSource = selectedTask.subtasks;

                    tareaElegidaLabel.Text = selectedTask.name;
                
            }
        }



        /// <summary>
        ///Permite crear subtareas.
        ///Verifica que el comboBox(taskListComboBox) tenga una tarea, que todos los campos estén completos y que la fecha de final no sea
        ///anterior a la inicial.
        ///Al finalizar, incluye la subtarea a la lista de subtareas de la tarea a modificar. En caso de que no tenga, se crea una nueva, se inicializa
        ///y se incluye la nueva subtarea.
        ///Actualiza el tablón de subtareas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearSubtareaBox_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDateSubtareaBox.Value;
            DateTime endDate = endDateSubtareaBox.Value;

            if (tasksListComboBox.SelectedItem == null || selectedTask == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea para empezar. Recuerda también tener un proyecto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(subtareaNombreBox.Text) || string.IsNullOrEmpty(estadoSubtareaBox.Text) || string.IsNullOrEmpty(startDateSubtareaBox.Text) || string.IsNullOrEmpty(endDateSubtareaBox.Text) || string.IsNullOrEmpty(descripcionSubtareaBox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos de la subtarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (endDate <= startDate)
            {
                MessageBox.Show("La fecha final debe ser posterior a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
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
                }
                else
                {
                    int lastSubtaskId = subtaskList.Last().subtaskId;
                    subtarea.subtaskId = lastSubtaskId + 1;
                }

                if (selectedTask.subtasks == null)
                {
                    selectedTask.subtasks = new List<subtask> { subtarea };
                }
                else
                {
                    selectedTask.subtasks.Add(subtarea);
                }

                File.WriteAllText(textBoxRuta.Text, JArray.FromObject(projectList).ToString(), Encoding.UTF8);

                subtaskGridView.DataSource = null;
                subtaskGridView.DataSource = selectedTask.subtasks;

                nombreTareaBox.Clear();
                descripcionSubtareaBox.Clear();

                MessageBox.Show("La subtarea ha sido añadida correctamente a la tarea del proyecto.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
