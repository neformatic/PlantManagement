using PlantManagment.BusinessLogic.Interface;
using PlantManagment.Presentation.Models;
using System;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class EmployeeForm : Form
    {
        private IEmployeeTaskServices _employeeTask;
        private IUserInfoServices _userInfoServices;
        private int _userId;

        public EmployeeForm(IUserInfoServices infoServices, IEmployeeTaskServices taskServices, int id)
        {
            _userId = id;
            _userInfoServices = infoServices;
            _employeeTask = taskServices;
            InitializeComponent();
            ShowUsersInfo();
        }

        private void ShowUsersInfo()
        {
            _newTaskListBox.Items.Clear();
            _actualTasksListBox.Items.Clear();

            var userInfo = _userInfoServices.GetUserInfo(_userId);
            foreach (var item in userInfo)
            {
                TaskModel model = new TaskModel()
                {
                    Id = item.Id,
                    Project = item.Project,
                    Task = item.Task,
                    TaskStatus = item.TaskStatus
                };
                if (item.TaskStatus == 0)
                {
                    _newTaskListBox.Items.Add(model);
                }
                else if (item.TaskStatus == 1)
                {
                    _actualTasksListBox.Items.Add(model);
                }
            }
        }

        private void _acceptTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel task = _newTaskListBox.SelectedItem as TaskModel;
            _userInfoServices.ChangeStatus(task.Id, 1);
            ShowUsersInfo();
        }

        private void _readyTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel task = _actualTasksListBox.SelectedItem as TaskModel;
            _userInfoServices.ChangeStatus(task.Id, 2);
            ShowUsersInfo();
        }
    }
}
