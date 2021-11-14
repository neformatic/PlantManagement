using PlantManagment.BusinessLogic.Interface;
using System;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class ManagerForm : Form
    {
        private IHeadOfDepartmentServices _headOfDepartmentServices;

        public ManagerForm(IHeadOfDepartmentServices departmentServices)
        {
            _headOfDepartmentServices = departmentServices;
            InitializeComponent();
            UpdateEmloyeesList();
        }

        private void UpdateEmloyeesList()
        {
            _employeeListBox.Items.Clear();
            var employees = _headOfDepartmentServices.ShowEmployeeList();
            foreach (var item in employees)
            {
                _employeeListBox.Items.Add($"{item.Id}) Фамилия: {item.LastName} Имя: {item.FirstName} Отчество: {item.MiddleName} Должность: {item.Position}");
            }
        }

        private void _deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(_idDeleteTextBox.Text);
            _headOfDepartmentServices.ShowDeleteEmployee(id);
            UpdateEmloyeesList();
        }
    }
}
