
namespace PlantManagment.Presentation
{
    partial class StartMenuForm
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
            this._startMenuLabel = new System.Windows.Forms.Label();
            this._registrationButton = new System.Windows.Forms.Button();
            this._enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _startMenuLabel
            // 
            this._startMenuLabel.AutoSize = true;
            this._startMenuLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this._startMenuLabel.Location = new System.Drawing.Point(25, 40);
            this._startMenuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._startMenuLabel.Name = "_startMenuLabel";
            this._startMenuLabel.Size = new System.Drawing.Size(252, 15);
            this._startMenuLabel.TabIndex = 0;
            this._startMenuLabel.Text = "Минский моторный завод приветствует Вас!";
            // 
            // _registrationButton
            // 
            this._registrationButton.Location = new System.Drawing.Point(176, 73);
            this._registrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._registrationButton.Name = "_registrationButton";
            this._registrationButton.Size = new System.Drawing.Size(105, 26);
            this._registrationButton.TabIndex = 2;
            this._registrationButton.Text = "Регистрация";
            this._registrationButton.UseVisualStyleBackColor = true;
            this._registrationButton.Click += new System.EventHandler(this._registrationButton_Click);
            // 
            // _enterButton
            // 
            this._enterButton.Location = new System.Drawing.Point(46, 73);
            this._enterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._enterButton.Name = "_enterButton";
            this._enterButton.Size = new System.Drawing.Size(105, 26);
            this._enterButton.TabIndex = 3;
            this._enterButton.Text = "Вход";
            this._enterButton.UseVisualStyleBackColor = true;
            this._enterButton.Click += new System.EventHandler(this._enterButton_Click);
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(310, 240);
            this.Controls.Add(this._enterButton);
            this.Controls.Add(this._registrationButton);
            this.Controls.Add(this._startMenuLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartMenuForm";
            this.Text = "StartMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _startMenuLabel;
        private System.Windows.Forms.Button _registrationButton;
        private System.Windows.Forms.Button _enterButton;
    }
}