
namespace PlantManagment.Presentation
{
    partial class ManagerForm
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
            this._idDeleteTextBox = new System.Windows.Forms.TextBox();
            this._newEmployeeListLabel = new System.Windows.Forms.Label();
            this._deleteEmployeeButton = new System.Windows.Forms.Button();
            this._employeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _idDeleteTextBox
            // 
            this._idDeleteTextBox.Location = new System.Drawing.Point(134, 221);
            this._idDeleteTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._idDeleteTextBox.Name = "_idDeleteTextBox";
            this._idDeleteTextBox.Size = new System.Drawing.Size(116, 23);
            this._idDeleteTextBox.TabIndex = 11;
            // 
            // _newEmployeeListLabel
            // 
            this._newEmployeeListLabel.AutoSize = true;
            this._newEmployeeListLabel.Location = new System.Drawing.Point(157, 34);
            this._newEmployeeListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._newEmployeeListLabel.Name = "_newEmployeeListLabel";
            this._newEmployeeListLabel.Size = new System.Drawing.Size(155, 15);
            this._newEmployeeListLabel.TabIndex = 10;
            this._newEmployeeListLabel.Text = "Список работников завода";
            // 
            // _deleteEmployeeButton
            // 
            this._deleteEmployeeButton.Location = new System.Drawing.Point(39, 218);
            this._deleteEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._deleteEmployeeButton.Name = "_deleteEmployeeButton";
            this._deleteEmployeeButton.Size = new System.Drawing.Size(88, 27);
            this._deleteEmployeeButton.TabIndex = 8;
            this._deleteEmployeeButton.Text = "Уволить";
            this._deleteEmployeeButton.UseVisualStyleBackColor = true;
            this._deleteEmployeeButton.Click += new System.EventHandler(this._deleteEmployeeButton_Click);
            // 
            // _employeeListBox
            // 
            this._employeeListBox.FormattingEnabled = true;
            this._employeeListBox.ItemHeight = 15;
            this._employeeListBox.Location = new System.Drawing.Point(39, 58);
            this._employeeListBox.Name = "_employeeListBox";
            this._employeeListBox.Size = new System.Drawing.Size(386, 154);
            this._employeeListBox.TabIndex = 12;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 266);
            this.Controls.Add(this._employeeListBox);
            this.Controls.Add(this._idDeleteTextBox);
            this.Controls.Add(this._newEmployeeListLabel);
            this.Controls.Add(this._deleteEmployeeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManagerForm";
            this.Text = "HRManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _idDeleteTextBox;
        private System.Windows.Forms.Label _newEmployeeListLabel;
        private System.Windows.Forms.Button _deleteEmployeeButton;
        private System.Windows.Forms.ListBox _employeeListBox;
    }
}