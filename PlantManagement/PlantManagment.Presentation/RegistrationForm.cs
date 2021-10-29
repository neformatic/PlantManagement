using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class RegistrationForm : Form
    {
        private IAccountServices _accountServices;
        private IUserInfoServices _userInfoServices;
        private IHeadOfDepartmentServices _headOfDepartmentServices;
        private IProjectService _projectService;
        private IEmployeeTaskServices _employeeTaskServices;
        private IEmployeeService _employeeService;

        public RegistrationForm(IUserInfoServices infoServices, IHeadOfDepartmentServices departmentServices, IProjectService projectService, IEmployeeTaskServices taskServices, IAccountServices accountServices)
        {
            _accountServices = accountServices;
            _userInfoServices = infoServices;
            _headOfDepartmentServices = departmentServices;
            _projectService = projectService;
            _employeeTaskServices = taskServices;
            InitializeComponent();
            ComboBoxAdd();
        }
        public void ComboBoxAdd()
        {
            var positionsList =_accountServices.GetPositionsList();
            foreach (var p in positionsList)
            {
                _jobSelectionComboBox.Items.Add(p.PositionName);
            }
        }

        public void UserRegistration()
        {
            string login = _loginTextBox.Text;
            string password = _passwordTextBox.Text;
            int accountStatusId = 3;
            _accountServices.UserRegistration(login, password, accountStatusId);
        }

        private void _acceptButton_Click(object sender, EventArgs e)
        {
            var checkAccount = new AccountServices();
            string emptyString = "";
            try
            {
                if (_loginTextBox.Text == emptyString || _passwordTextBox.Text == emptyString || _surNameTextBox.Text == emptyString || _firstNameTextBox.Text == emptyString || _middleNameTextBox.Text == emptyString)
                {
                    MessageBox.Show("Поля пустые!");
                }
                else
                {
                    var isUser = checkAccount.IsUser(_loginTextBox.Text, _passwordTextBox.Text);
                    if (!isUser)
                    {
                        _accountServices.AddUser(_loginTextBox.Text, _passwordTextBox.Text, _jobSelectionComboBox.Text, _surNameTextBox.Text, _firstNameTextBox.Text, _middleNameTextBox.Text);
                        MessageBox.Show("Регистрация прошла успешно. Теперь авторизируйтесь!");
                        AutorizationForm autorizationForm = new AutorizationForm(_userInfoServices, _headOfDepartmentServices, _projectService, _employeeTaskServices, _employeeService, _accountServices);
                        this.Hide();
                        autorizationForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Логин уже существует!");
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
