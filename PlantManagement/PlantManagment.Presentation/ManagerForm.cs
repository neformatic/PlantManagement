using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PlantManagment.BusinessLogic.Services;
using System.Linq;
using PlantManagment.BusinessLogic.Interface;

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
