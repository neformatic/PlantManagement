using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class ProjectsForm : Form
    {
        private IProjectService _projectService;

        public ProjectsForm(IProjectService projectService)
        {
            _projectService = projectService;
            InitializeComponent();
        }

        private void _addNewProjectButton_Click(object sender, EventArgs e)
        {
            string project = _addProjectTextBox.Text; 
            _projectService.AddNewProject(project);
            MessageBox.Show("Проект успешно добавлен.");
            Close();
        }
    }
}
