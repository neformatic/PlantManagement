using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Models;
using PlantManagment.BusinessLogic.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace PlantManagment.Presentation
{
    public partial class AutorizationForm : Form
    {
        private IUserInfoServices _userInfoServices;
        private IHeadOfDepartmentServices _headOfDepartmentServices;
        private IProjectService _projectService;
        private IEmployeeTaskServices _employeeTaskServices;
        private IEmployeeService _employeeService;
        private IAccountServices _accountServices;

        public AutorizationForm(IUserInfoServices infoServices, IHeadOfDepartmentServices departmentServices, IProjectService projectService, IEmployeeTaskServices taskServices, IEmployeeService employeeService, IAccountServices accountServices)
        {
            _accountServices = accountServices;
            _userInfoServices = infoServices;
            _headOfDepartmentServices = departmentServices;
            _projectService = projectService;
            _employeeTaskServices = taskServices;
            _employeeService = employeeService;
            InitializeComponent();
        }
        private void _autorizationAcceptButton_Click(object sender, EventArgs e)
        {
            
            var userLogin = _autorizationLoginTextBox.Text;
            var userPass = _autorizationPasswordTextBox.Text;
            var isUser = false;

            if (userLogin != string.Empty && userPass != string.Empty)
            {
                isUser = _accountServices.IsUser(userLogin, userPass);
            }

            if (isUser)
            {   
                var selectUserByLogin = _accountServices.GetUserBylogin(userLogin);               
                IsAccountStatus(selectUserByLogin);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void IsAccountStatus(AccountModel user)
        {
            var accountStatusId = user.AccountStatusId;
            var statusName = _accountServices.GetUserStatusByAccountStatusId(accountStatusId);
            int adminAccountStatusId = 1;
            int managerAccountStatusId = 2;

            if (accountStatusId == adminAccountStatusId)
            {
                MessageBox.Show($"Вход успешно выполнен. Вы вошли как {statusName}.");
                HeadOfDepartmentForm adminForm = new HeadOfDepartmentForm(_userInfoServices, _headOfDepartmentServices, _projectService);
                Hide();
                adminForm.Show();
            }
            else if (accountStatusId == managerAccountStatusId)
            {
                MessageBox.Show($"Вход успешно выполнен. Вы вошли как {statusName}.");
                ManagerForm HRManagerForm = new ManagerForm(_headOfDepartmentServices);
                Hide();
                HRManagerForm.Show();
            }
            else
            {
                MessageBox.Show($"Вход успешно выполнен. Вы вошли как {statusName}.");
                var userId = _employeeService.GetEmployeId(user.Id);
                EmployeeForm employeeForm = new EmployeeForm(_userInfoServices, _employeeTaskServices, userId);
                Hide();
                employeeForm.Show();
            }
        }
    }
}

