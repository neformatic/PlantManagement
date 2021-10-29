
namespace PlantManagment.Presentation
{
    partial class RegistrationForm
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
            this._surNameTextBox = new System.Windows.Forms.TextBox();
            this._firstNameTextBox = new System.Windows.Forms.TextBox();
            this._middleNameTextBox = new System.Windows.Forms.TextBox();
            this._jobSelectionComboBox = new System.Windows.Forms.ComboBox();
            this._acceptButton = new System.Windows.Forms.Button();
            this._surNameLabel = new System.Windows.Forms.Label();
            this._firstNameLabel = new System.Windows.Forms.Label();
            this._middleNameLabel = new System.Windows.Forms.Label();
            this._jobSelectionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._loginLabel = new System.Windows.Forms.Label();
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _surNameTextBox
            // 
            this._surNameTextBox.Location = new System.Drawing.Point(144, 201);
            this._surNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._surNameTextBox.Name = "_surNameTextBox";
            this._surNameTextBox.Size = new System.Drawing.Size(159, 27);
            this._surNameTextBox.TabIndex = 0;
            // 
            // _firstNameTextBox
            // 
            this._firstNameTextBox.Location = new System.Drawing.Point(144, 257);
            this._firstNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._firstNameTextBox.Name = "_firstNameTextBox";
            this._firstNameTextBox.Size = new System.Drawing.Size(159, 27);
            this._firstNameTextBox.TabIndex = 1;
            // 
            // _middleNameTextBox
            // 
            this._middleNameTextBox.Location = new System.Drawing.Point(144, 315);
            this._middleNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._middleNameTextBox.Name = "_middleNameTextBox";
            this._middleNameTextBox.Size = new System.Drawing.Size(159, 27);
            this._middleNameTextBox.TabIndex = 2;
            // 
            // _jobSelectionComboBox
            // 
            this._jobSelectionComboBox.FormattingEnabled = true;
            this._jobSelectionComboBox.Location = new System.Drawing.Point(144, 375);
            this._jobSelectionComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._jobSelectionComboBox.Name = "_jobSelectionComboBox";
            this._jobSelectionComboBox.Size = new System.Drawing.Size(159, 28);
            this._jobSelectionComboBox.TabIndex = 3;
            // 
            // _acceptButton
            // 
            this._acceptButton.Location = new System.Drawing.Point(160, 429);
            this._acceptButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(101, 36);
            this._acceptButton.TabIndex = 5;
            this._acceptButton.Text = "Принять";
            this._acceptButton.UseVisualStyleBackColor = true;
            this._acceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // _surNameLabel
            // 
            this._surNameLabel.AutoSize = true;
            this._surNameLabel.Location = new System.Drawing.Point(65, 201);
            this._surNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._surNameLabel.Name = "_surNameLabel";
            this._surNameLabel.Size = new System.Drawing.Size(76, 20);
            this._surNameLabel.TabIndex = 6;
            this._surNameLabel.Text = "Фамилия:";
            // 
            // _firstNameLabel
            // 
            this._firstNameLabel.AutoSize = true;
            this._firstNameLabel.Location = new System.Drawing.Point(90, 257);
            this._firstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._firstNameLabel.Name = "_firstNameLabel";
            this._firstNameLabel.Size = new System.Drawing.Size(42, 20);
            this._firstNameLabel.TabIndex = 7;
            this._firstNameLabel.Text = "Имя:";
            // 
            // _middleNameLabel
            // 
            this._middleNameLabel.AutoSize = true;
            this._middleNameLabel.Location = new System.Drawing.Point(67, 315);
            this._middleNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._middleNameLabel.Name = "_middleNameLabel";
            this._middleNameLabel.Size = new System.Drawing.Size(75, 20);
            this._middleNameLabel.TabIndex = 8;
            this._middleNameLabel.Text = "Отчество:";
            // 
            // _jobSelectionLabel
            // 
            this._jobSelectionLabel.AutoSize = true;
            this._jobSelectionLabel.Location = new System.Drawing.Point(53, 375);
            this._jobSelectionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._jobSelectionLabel.Name = "_jobSelectionLabel";
            this._jobSelectionLabel.Size = new System.Drawing.Size(89, 20);
            this._jobSelectionLabel.TabIndex = 9;
            this._jobSelectionLabel.Text = "Должность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Форма регистрации";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(70, 149);
            this._passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(65, 20);
            this._passwordLabel.TabIndex = 12;
            this._passwordLabel.Text = "Пароль:";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(144, 149);
            this._passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(159, 27);
            this._passwordTextBox.TabIndex = 11;
            // 
            // _loginLabel
            // 
            this._loginLabel.AutoSize = true;
            this._loginLabel.Location = new System.Drawing.Point(79, 97);
            this._loginLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._loginLabel.Name = "_loginLabel";
            this._loginLabel.Size = new System.Drawing.Size(55, 20);
            this._loginLabel.TabIndex = 14;
            this._loginLabel.Text = "Логин:";
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Location = new System.Drawing.Point(144, 97);
            this._loginTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(159, 27);
            this._loginTextBox.TabIndex = 13;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 499);
            this.Controls.Add(this._loginLabel);
            this.Controls.Add(this._loginTextBox);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._jobSelectionLabel);
            this.Controls.Add(this._middleNameLabel);
            this.Controls.Add(this._firstNameLabel);
            this.Controls.Add(this._surNameLabel);
            this.Controls.Add(this._acceptButton);
            this.Controls.Add(this._jobSelectionComboBox);
            this.Controls.Add(this._middleNameTextBox);
            this.Controls.Add(this._firstNameTextBox);
            this.Controls.Add(this._surNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TextBox _surNameTextBox;
        private System.Windows.Forms.TextBox _firstNameTextBox;
        private System.Windows.Forms.TextBox _middleNameTextBox;
        private System.Windows.Forms.ComboBox _jobSelectionComboBox;
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.Label _surNameLabel;
        private System.Windows.Forms.Label _firstNameLabel;
        private System.Windows.Forms.Label _middleNameLabel;
        private System.Windows.Forms.Label _jobSelectionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _loginLabel;
        private System.Windows.Forms.TextBox _loginTextBox;
    }
           
}

