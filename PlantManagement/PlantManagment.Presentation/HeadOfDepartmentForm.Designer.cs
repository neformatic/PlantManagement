
namespace PlantManagment.Presentation
{
    partial class HeadOfDepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._departmentComboBox = new System.Windows.Forms.ComboBox();
            this._departmentLabel = new System.Windows.Forms.Label();
            this._positionLabel = new System.Windows.Forms.Label();
            this._positionComboBox = new System.Windows.Forms.ComboBox();
            this._fullNameLabel = new System.Windows.Forms.Label();
            this._fullNameComboBox = new System.Windows.Forms.ComboBox();
            this._projectLabel = new System.Windows.Forms.Label();
            this._projectComboBox = new System.Windows.Forms.ComboBox();
            this._menuHeadOfDepartmentLabel = new System.Windows.Forms.Label();
            this._employeeTasksTextBox = new System.Windows.Forms.TextBox();
            this._employeeTasksLabel = new System.Windows.Forms.Label();
            this._sendTaskButton = new System.Windows.Forms.Button();
            this._showEmployeeToDoListButton = new System.Windows.Forms.Button();
            this._addNewProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _departmentComboBox
            // 
            this._departmentComboBox.FormattingEnabled = true;
            this._departmentComboBox.Location = new System.Drawing.Point(350, 79);
            this._departmentComboBox.Margin = new System.Windows.Forms.Padding(4);
            this._departmentComboBox.Name = "_departmentComboBox";
            this._departmentComboBox.Size = new System.Drawing.Size(194, 23);
            this._departmentComboBox.TabIndex = 0;
            this._departmentComboBox.SelectedIndexChanged += new System.EventHandler(this._departmentComboBox_SelectedIndexChanged);
            // 
            // _departmentLabel
            // 
            this._departmentLabel.AutoSize = true;
            this._departmentLabel.Location = new System.Drawing.Point(350, 60);
            this._departmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._departmentLabel.Name = "_departmentLabel";
            this._departmentLabel.Size = new System.Drawing.Size(43, 15);
            this._departmentLabel.TabIndex = 1;
            this._departmentLabel.Text = "Отдел:";
            // 
            // _positionLabel
            // 
            this._positionLabel.AutoSize = true;
            this._positionLabel.Location = new System.Drawing.Point(350, 152);
            this._positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._positionLabel.Name = "_positionLabel";
            this._positionLabel.Size = new System.Drawing.Size(72, 15);
            this._positionLabel.TabIndex = 3;
            this._positionLabel.Text = "Должность:";
            // 
            // _positionComboBox
            // 
            this._positionComboBox.FormattingEnabled = true;
            this._positionComboBox.Location = new System.Drawing.Point(350, 171);
            this._positionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this._positionComboBox.Name = "_positionComboBox";
            this._positionComboBox.Size = new System.Drawing.Size(194, 23);
            this._positionComboBox.TabIndex = 2;
            // 
            // _fullNameLabel
            // 
            this._fullNameLabel.AutoSize = true;
            this._fullNameLabel.Location = new System.Drawing.Point(350, 106);
            this._fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._fullNameLabel.Name = "_fullNameLabel";
            this._fullNameLabel.Size = new System.Drawing.Size(37, 15);
            this._fullNameLabel.TabIndex = 5;
            this._fullNameLabel.Text = "ФИО:";
            // 
            // _fullNameComboBox
            // 
            this._fullNameComboBox.FormattingEnabled = true;
            this._fullNameComboBox.Location = new System.Drawing.Point(350, 125);
            this._fullNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this._fullNameComboBox.Name = "_fullNameComboBox";
            this._fullNameComboBox.Size = new System.Drawing.Size(194, 23);
            this._fullNameComboBox.TabIndex = 4;
            // 
            // _projectLabel
            // 
            this._projectLabel.AutoSize = true;
            this._projectLabel.Location = new System.Drawing.Point(350, 196);
            this._projectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._projectLabel.Name = "_projectLabel";
            this._projectLabel.Size = new System.Drawing.Size(50, 15);
            this._projectLabel.TabIndex = 7;
            this._projectLabel.Text = "Проект:";
            // 
            // _projectComboBox
            // 
            this._projectComboBox.FormattingEnabled = true;
            this._projectComboBox.Location = new System.Drawing.Point(350, 215);
            this._projectComboBox.Margin = new System.Windows.Forms.Padding(4);
            this._projectComboBox.Name = "_projectComboBox";
            this._projectComboBox.Size = new System.Drawing.Size(194, 23);
            this._projectComboBox.TabIndex = 6;
            // 
            // _menuHeadOfDepartmentLabel
            // 
            this._menuHeadOfDepartmentLabel.AutoSize = true;
            this._menuHeadOfDepartmentLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._menuHeadOfDepartmentLabel.Location = new System.Drawing.Point(232, 20);
            this._menuHeadOfDepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._menuHeadOfDepartmentLabel.Name = "_menuHeadOfDepartmentLabel";
            this._menuHeadOfDepartmentLabel.Size = new System.Drawing.Size(123, 15);
            this._menuHeadOfDepartmentLabel.TabIndex = 10;
            this._menuHeadOfDepartmentLabel.Text = "Меню руководителя ";
            this._menuHeadOfDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _employeeTasksTextBox
            // 
            this._employeeTasksTextBox.Location = new System.Drawing.Point(10, 79);
            this._employeeTasksTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._employeeTasksTextBox.Multiline = true;
            this._employeeTasksTextBox.Name = "_employeeTasksTextBox";
            this._employeeTasksTextBox.Size = new System.Drawing.Size(321, 146);
            this._employeeTasksTextBox.TabIndex = 11;
            // 
            // _employeeTasksLabel
            // 
            this._employeeTasksLabel.AutoSize = true;
            this._employeeTasksLabel.Location = new System.Drawing.Point(14, 60);
            this._employeeTasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._employeeTasksLabel.Name = "_employeeTasksLabel";
            this._employeeTasksLabel.Size = new System.Drawing.Size(83, 15);
            this._employeeTasksLabel.TabIndex = 12;
            this._employeeTasksLabel.Text = "Новая задача:";
            // 
            // _sendTaskButton
            // 
            this._sendTaskButton.Location = new System.Drawing.Point(405, 247);
            this._sendTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this._sendTaskButton.Name = "_sendTaskButton";
            this._sendTaskButton.Size = new System.Drawing.Size(88, 26);
            this._sendTaskButton.TabIndex = 13;
            this._sendTaskButton.Text = "Отправить";
            this._sendTaskButton.UseVisualStyleBackColor = true;
            this._sendTaskButton.Click += new System.EventHandler(this._sendTaskButton_Click);
            // 
            // _showEmployeeToDoListButton
            // 
            this._showEmployeeToDoListButton.Location = new System.Drawing.Point(10, 233);
            this._showEmployeeToDoListButton.Margin = new System.Windows.Forms.Padding(4);
            this._showEmployeeToDoListButton.Name = "_showEmployeeToDoListButton";
            this._showEmployeeToDoListButton.Size = new System.Drawing.Size(157, 40);
            this._showEmployeeToDoListButton.TabIndex = 15;
            this._showEmployeeToDoListButton.Text = "Список задач сотрудников";
            this._showEmployeeToDoListButton.UseVisualStyleBackColor = true;
            this._showEmployeeToDoListButton.Click += new System.EventHandler(this._showEmployeeToDoListButton_Click);
            // 
            // _addNewProjectButton
            // 
            this._addNewProjectButton.Location = new System.Drawing.Point(10, 280);
            this._addNewProjectButton.Name = "_addNewProjectButton";
            this._addNewProjectButton.Size = new System.Drawing.Size(157, 38);
            this._addNewProjectButton.TabIndex = 16;
            this._addNewProjectButton.Text = "Добавить проект";
            this._addNewProjectButton.UseVisualStyleBackColor = true;
            this._addNewProjectButton.Click += new System.EventHandler(this._addNewProjectButton_Click);
            // 
            // HeadOfDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 338);
            this.Controls.Add(this._addNewProjectButton);
            this.Controls.Add(this._showEmployeeToDoListButton);
            this.Controls.Add(this._sendTaskButton);
            this.Controls.Add(this._employeeTasksLabel);
            this.Controls.Add(this._employeeTasksTextBox);
            this.Controls.Add(this._menuHeadOfDepartmentLabel);
            this.Controls.Add(this._projectLabel);
            this.Controls.Add(this._projectComboBox);
            this.Controls.Add(this._fullNameLabel);
            this.Controls.Add(this._fullNameComboBox);
            this.Controls.Add(this._positionLabel);
            this.Controls.Add(this._positionComboBox);
            this.Controls.Add(this._departmentLabel);
            this.Controls.Add(this._departmentComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HeadOfDepartmentForm";
            this.Text = "HeadOfDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _departmentComboBox;
        private System.Windows.Forms.Label _departmentLabel;
        private System.Windows.Forms.Label _positionLabel;
        private System.Windows.Forms.ComboBox _positionComboBox;
        private System.Windows.Forms.Label _fullNameLabel;
        private System.Windows.Forms.ComboBox _fullNameComboBox;
        private System.Windows.Forms.Label _projectLabel;
        private System.Windows.Forms.ComboBox _projectComboBox;
        private System.Windows.Forms.Label _menuHeadOfDepartmentLabel;
        private System.Windows.Forms.TextBox _employeeTasksTextBox;
        private System.Windows.Forms.Label _employeeTasksLabel;
        private System.Windows.Forms.Button _sendTaskButton;
        private System.Windows.Forms.Button _showEmployeeToDoListButton;
        private System.Windows.Forms.Button _addNewProjectButton;
    }
}