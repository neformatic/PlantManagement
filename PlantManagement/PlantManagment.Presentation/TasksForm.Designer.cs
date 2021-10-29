
namespace PlantManagment.Presentation
{
    partial class TasksForm
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
            this._listAllTasksLabel = new System.Windows.Forms.Label();
            this._closeTaskButton = new System.Windows.Forms.Button();
            this._infoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _listAllTasksLabel
            // 
            this._listAllTasksLabel.AutoSize = true;
            this._listAllTasksLabel.Location = new System.Drawing.Point(12, 9);
            this._listAllTasksLabel.Name = "_listAllTasksLabel";
            this._listAllTasksLabel.Size = new System.Drawing.Size(117, 15);
            this._listAllTasksLabel.TabIndex = 1;
            this._listAllTasksLabel.Text = "Задачи работников:";
            // 
            // _closeTaskButton
            // 
            this._closeTaskButton.Location = new System.Drawing.Point(505, 274);
            this._closeTaskButton.Name = "_closeTaskButton";
            this._closeTaskButton.Size = new System.Drawing.Size(75, 23);
            this._closeTaskButton.TabIndex = 3;
            this._closeTaskButton.Text = "Закрыть";
            this._closeTaskButton.UseVisualStyleBackColor = true;
            this._closeTaskButton.Click += new System.EventHandler(this._closeTaskButton_Click);
            // 
            // _infoTextBox
            // 
            this._infoTextBox.Location = new System.Drawing.Point(12, 27);
            this._infoTextBox.Multiline = true;
            this._infoTextBox.Name = "_infoTextBox";
            this._infoTextBox.ReadOnly = true;
            this._infoTextBox.Size = new System.Drawing.Size(568, 241);
            this._infoTextBox.TabIndex = 5;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 313);
            this.Controls.Add(this._infoTextBox);
            this.Controls.Add(this._closeTaskButton);
            this.Controls.Add(this._listAllTasksLabel);
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _listAllTasksLabel;
        private System.Windows.Forms.Button _closeTaskButton;
        private System.Windows.Forms.TextBox _infoTextBox;
    }
}