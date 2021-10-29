using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class StartMenuForm : Form
    {
        private IAccountServices _accountServices;
        private IUserInfoServices _userInfoServices;
        private IHeadOfDepartmentServices _headOfDepartmentServices;
        private IProjectService _projectService;
        private IEmployeeTaskServices _employeeTask;
        private IEmployeeService _employeeService;

        public StartMenuForm()
        {
            _accountServices = new AccountServices();
            _employeeService = new EmployeeService();
            _userInfoServices = new UserInfoServices();
            _headOfDepartmentServices = new HeadOfDepartmentServices();
            _projectService = new ProjectService();
            _employeeTask = new EmployeeTaskServices();
            InitializeComponent();
        }

        private void _enterButton_Click(object sender, EventArgs e)
        {
            AutorizationForm autorization = new AutorizationForm(_userInfoServices, _headOfDepartmentServices, _projectService, _employeeTask, _employeeService, _accountServices);
            this.Hide();
            autorization.Show();
        }

        private void _registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(_userInfoServices, _headOfDepartmentServices, _projectService, _employeeTask, _accountServices);
            this.Hide();
            registration.Show();
        }
    }
}
