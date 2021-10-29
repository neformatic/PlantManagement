
namespace PlantManagment.Presentation
{
    partial class EmployeeForm
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
            this._menuEmployeeLabel = new System.Windows.Forms.Label();
            this._actualTasksLabel = new System.Windows.Forms.Label();
            this._newTasksLabel = new System.Windows.Forms.Label();
            this._readyTaskButton = new System.Windows.Forms.Button();
            this._acceptTaskButton = new System.Windows.Forms.Button();
            this._newTaskListBox = new System.Windows.Forms.ListBox();
            this._actualTasksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _menuEmployeeLabel
            // 
            this._menuEmployeeLabel.AutoSize = true;
            this._menuEmployeeLabel.Location = new System.Drawing.Point(311, 28);
            this._menuEmployeeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._menuEmployeeLabel.Name = "_menuEmployeeLabel";
            this._menuEmployeeLabel.Size = new System.Drawing.Size(102, 15);
            this._menuEmployeeLabel.TabIndex = 1;
            this._menuEmployeeLabel.Text = "Меню работника";
            // 
            // _actualTasksLabel
            // 
            this._actualTasksLabel.AutoSize = true;
            this._actualTasksLabel.Location = new System.Drawing.Point(373, 70);
            this._actualTasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._actualTasksLabel.Name = "_actualTasksLabel";
            this._actualTasksLabel.Size = new System.Drawing.Size(99, 15);
            this._actualTasksLabel.TabIndex = 3;
            this._actualTasksLabel.Text = "Текущие задачи:";
            // 
            // _newTasksLabel
            // 
            this._newTasksLabel.AutoSize = true;
            this._newTasksLabel.Location = new System.Drawing.Point(13, 70);
            this._newTasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._newTasksLabel.Name = "_newTasksLabel";
            this._newTasksLabel.Size = new System.Drawing.Size(87, 15);
            this._newTasksLabel.TabIndex = 6;
            this._newTasksLabel.Text = "Новые задачи:";
            // 
            // _readyTaskButton
            // 
            this._readyTaskButton.Location = new System.Drawing.Point(645, 243);
            this._readyTaskButton.Name = "_readyTaskButton";
            this._readyTaskButton.Size = new System.Drawing.Size(88, 27);
            this._readyTaskButton.TabIndex = 11;
            this._readyTaskButton.Text = "Готово";
            this._readyTaskButton.UseVisualStyleBackColor = true;
            this._readyTaskButton.Click += new System.EventHandler(this._readyTaskButton_Click);
            // 
            // _acceptTaskButton
            // 
            this._acceptTaskButton.Location = new System.Drawing.Point(278, 248);
            this._acceptTaskButton.Name = "_acceptTaskButton";
            this._acceptTaskButton.Size = new System.Drawing.Size(88, 27);
            this._acceptTaskButton.TabIndex = 12;
            this._acceptTaskButton.Text = "Принять";
            this._acceptTaskButton.UseVisualStyleBackColor = true;
            this._acceptTaskButton.Click += new System.EventHandler(this._acceptTaskButton_Click);
            // 
            // _newTaskListBox
            // 
            this._newTaskListBox.FormattingEnabled = true;
            this._newTaskListBox.ItemHeight = 15;
            this._newTaskListBox.Location = new System.Drawing.Point(13, 88);
            this._newTaskListBox.Name = "_newTaskListBox";
            this._newTaskListBox.Size = new System.Drawing.Size(353, 154);
            this._newTaskListBox.TabIndex = 13;
            // 
            // _actualTasksListBox
            // 
            this._actualTasksListBox.FormattingEnabled = true;
            this._actualTasksListBox.ItemHeight = 15;
            this._actualTasksListBox.Location = new System.Drawing.Point(380, 88);
            this._actualTasksListBox.Name = "_actualTasksListBox";
            this._actualTasksListBox.Size = new System.Drawing.Size(353, 154);
            this._actualTasksListBox.TabIndex = 14;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 342);
            this.Controls.Add(this._actualTasksListBox);
            this.Controls.Add(this._newTaskListBox);
            this.Controls.Add(this._acceptTaskButton);
            this.Controls.Add(this._readyTaskButton);
            this.Controls.Add(this._newTasksLabel);
            this.Controls.Add(this._actualTasksLabel);
            this.Controls.Add(this._menuEmployeeLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _menuEmployeeLabel;
        private System.Windows.Forms.Label _actualTasksLabel;
        private System.Windows.Forms.Label _newTasksLabel;
        private System.Windows.Forms.Button _readyTaskButton;
        private System.Windows.Forms.Button _acceptTaskButton;
        private System.Windows.Forms.ListBox _newTaskListBox;
        private System.Windows.Forms.ListBox _actualTasksListBox;
    }
}