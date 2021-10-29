using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class HeadOfDepartmentForm : Form
    {
        private IHeadOfDepartmentServices _headOfDepartmentServices;
        private IUserInfoServices _userInfoServices;
        private IProjectService _projectService;

        public HeadOfDepartmentForm(IUserInfoServices infoServices, IHeadOfDepartmentServices departmentServices, IProjectService projectService)
        {
            _userInfoServices = infoServices;
            _headOfDepartmentServices = departmentServices;
            _projectService = projectService;
            InitializeComponent();
            ShowDepartmentInfo();
        }

        private void ShowDepartmentInfo()
        {
            var department = _headOfDepartmentServices.ShowDepartmentInfo();
            foreach (var item in department)
            {
                _departmentComboBox.Items.Add(item.DepartmentName);
            }
        }
        private void InitializeForm()
        {
            string selectDepartment = _departmentComboBox.Text;
            var position = _headOfDepartmentServices.ShowPositionInfo();
            foreach (var item in position)
            {
                _positionComboBox.Items.Add(item.PositionName);
            }

            var userInfo = _headOfDepartmentServices.ShowUserInfo(selectDepartment);
            foreach (var item in userInfo)
            {
                _fullNameComboBox.Items.Add($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }

            var project = _headOfDepartmentServices.ShowProjectInfo();
            foreach (var item in project)
            {
                _projectComboBox.Items.Add(item.ProjectName);
            }
        }

        private void _departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _projectComboBox.Items.Clear();
            _fullNameComboBox.Items.Clear();
            _positionComboBox.Items.Clear();
            InitializeForm();
        }

        private void ShowEmployeeTaskList()
        {
            _userInfoServices.GetUserInfo();
        }

        private void _addNewProjectButton_Click(object sender, EventArgs e)
        {
            ProjectsForm projectForm = new ProjectsForm(_projectService);
            projectForm.Show();
        }

        private void _showEmployeeToDoListButton_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm(_userInfoServices);
            tasksForm.Show();
            _employeeTasksTextBox.Clear();
            ShowEmployeeTaskList();
        }

        private void _sendTaskButton_Click(object sender, EventArgs e)
        {
            var trimChar = _fullNameComboBox.Text.IndexOf(' ');
            string taskName = _employeeTasksTextBox.Text;
            string selectDepartment = _departmentComboBox.Text;
            var userInfo = _headOfDepartmentServices.ShowUserInfo(selectDepartment).Where(u => u.LastName == _fullNameComboBox.Text.Substring(0, trimChar)).FirstOrDefault();
            var project = _headOfDepartmentServices.ShowProjectInfo().Where(p => p.ProjectName == _projectComboBox.Text).FirstOrDefault();
            var id = userInfo.Id;
            var projectId = project.Id;
            _headOfDepartmentServices.AddEmployeeTask(taskName, projectId, id);
            MessageBox.Show("Задача добавлена.");
        }
    }
}
