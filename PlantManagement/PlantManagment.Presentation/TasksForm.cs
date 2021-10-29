using PlantManagment.BusinessLogic.Interface;
using PlantManagment.BusinessLogic.Services;
using PlantManagment.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantManagment.Presentation
{
    public partial class TasksForm : Form
    {
        private IUserInfoServices _userInfoServices;

        public TasksForm(IUserInfoServices infoServices)
        {     
            _userInfoServices = infoServices;
            InitializeComponent();
            ShowUsersInfo();
        }

        private void _closeTaskButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowUsersInfo()
        {    
            var userInfo = _userInfoServices.GetUserInfo();
            foreach (var u in userInfo)
            {
                _infoTextBox.Text += ($"ФИО: {u.LastName} {u.FirstName} {u.MiddleName} {Environment.NewLine} Отдел: {u.Department} {Environment.NewLine} Должность: {u.Position} {Environment.NewLine} Проект: {u.Project} {Environment.NewLine} Задача: {u.Task} {Environment.NewLine} {Environment.NewLine}");
            }
        }
    }
}
