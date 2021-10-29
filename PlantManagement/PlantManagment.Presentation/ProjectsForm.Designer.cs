
namespace PlantManagment.Presentation
{
    partial class ProjectsForm
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
            this._addNewProjectButton = new System.Windows.Forms.Button();
            this._addMenuLabel = new System.Windows.Forms.Label();
            this._addProjectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _addNewProjectButton
            // 
            this._addNewProjectButton.Location = new System.Drawing.Point(194, 198);
            this._addNewProjectButton.Name = "_addNewProjectButton";
            this._addNewProjectButton.Size = new System.Drawing.Size(75, 23);
            this._addNewProjectButton.TabIndex = 0;
            this._addNewProjectButton.Text = "Добавить";
            this._addNewProjectButton.UseVisualStyleBackColor = true;
            this._addNewProjectButton.Click += new System.EventHandler(this._addNewProjectButton_Click);
            // 
            // _addMenuLabel
            // 
            this._addMenuLabel.AutoSize = true;
            this._addMenuLabel.Location = new System.Drawing.Point(28, 19);
            this._addMenuLabel.Name = "_addMenuLabel";
            this._addMenuLabel.Size = new System.Drawing.Size(89, 15);
            this._addMenuLabel.TabIndex = 1;
            this._addMenuLabel.Text = "Новый проект:";
            // 
            // _addProjectTextBox
            // 
            this._addProjectTextBox.Location = new System.Drawing.Point(28, 37);
            this._addProjectTextBox.Multiline = true;
            this._addProjectTextBox.Name = "_addProjectTextBox";
            this._addProjectTextBox.Size = new System.Drawing.Size(408, 155);
            this._addProjectTextBox.TabIndex = 2;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 246);
            this.Controls.Add(this._addProjectTextBox);
            this.Controls.Add(this._addMenuLabel);
            this.Controls.Add(this._addNewProjectButton);
            this.Name = "ProjectsForm";
            this.Text = "ProjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _addNewProjectButton;
        private System.Windows.Forms.Label _addMenuLabel;
        private System.Windows.Forms.TextBox _addProjectTextBox;
    }
}