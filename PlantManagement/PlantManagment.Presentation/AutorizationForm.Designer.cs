
namespace PlantManagment.Presentation
{
    partial class AutorizationForm
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
            this._autorizationLoginLabel = new System.Windows.Forms.Label();
            this._autorizationLoginTextBox = new System.Windows.Forms.TextBox();
            this._autorizationPasswordTextBox = new System.Windows.Forms.TextBox();
            this._autorizationPasswordLabel = new System.Windows.Forms.Label();
            this._autorizationAcceptButton = new System.Windows.Forms.Button();
            this._autorizationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _autorizationLoginLabel
            // 
            this._autorizationLoginLabel.AutoSize = true;
            this._autorizationLoginLabel.Location = new System.Drawing.Point(66, 154);
            this._autorizationLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._autorizationLoginLabel.Name = "_autorizationLoginLabel";
            this._autorizationLoginLabel.Size = new System.Drawing.Size(44, 15);
            this._autorizationLoginLabel.TabIndex = 0;
            this._autorizationLoginLabel.Text = "Логин:";
            // 
            // _autorizationLoginTextBox
            // 
            this._autorizationLoginTextBox.Location = new System.Drawing.Point(141, 150);
            this._autorizationLoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._autorizationLoginTextBox.Name = "_autorizationLoginTextBox";
            this._autorizationLoginTextBox.Size = new System.Drawing.Size(136, 23);
            this._autorizationLoginTextBox.TabIndex = 1;
            // 
            // _autorizationPasswordTextBox
            // 
            this._autorizationPasswordTextBox.Location = new System.Drawing.Point(141, 180);
            this._autorizationPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._autorizationPasswordTextBox.Name = "_autorizationPasswordTextBox";
            this._autorizationPasswordTextBox.Size = new System.Drawing.Size(136, 23);
            this._autorizationPasswordTextBox.TabIndex = 2;
            // 
            // _autorizationPasswordLabel
            // 
            this._autorizationPasswordLabel.AutoSize = true;
            this._autorizationPasswordLabel.Location = new System.Drawing.Point(66, 188);
            this._autorizationPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._autorizationPasswordLabel.Name = "_autorizationPasswordLabel";
            this._autorizationPasswordLabel.Size = new System.Drawing.Size(52, 15);
            this._autorizationPasswordLabel.TabIndex = 3;
            this._autorizationPasswordLabel.Text = "Пароль:";
            // 
            // _autorizationAcceptButton
            // 
            this._autorizationAcceptButton.Location = new System.Drawing.Point(164, 210);
            this._autorizationAcceptButton.Margin = new System.Windows.Forms.Padding(4);
            this._autorizationAcceptButton.Name = "_autorizationAcceptButton";
            this._autorizationAcceptButton.Size = new System.Drawing.Size(88, 26);
            this._autorizationAcceptButton.TabIndex = 4;
            this._autorizationAcceptButton.Text = "Войти";
            this._autorizationAcceptButton.UseVisualStyleBackColor = true;
            this._autorizationAcceptButton.Click += new System.EventHandler(this._autorizationAcceptButton_Click);
            // 
            // _autorizationLabel
            // 
            this._autorizationLabel.AutoSize = true;
            this._autorizationLabel.Location = new System.Drawing.Point(165, 116);
            this._autorizationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._autorizationLabel.Name = "_autorizationLabel";
            this._autorizationLabel.Size = new System.Drawing.Size(78, 15);
            this._autorizationLabel.TabIndex = 5;
            this._autorizationLabel.Text = "Авторизация";
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 390);
            this.Controls.Add(this._autorizationLabel);
            this.Controls.Add(this._autorizationAcceptButton);
            this.Controls.Add(this._autorizationPasswordLabel);
            this.Controls.Add(this._autorizationPasswordTextBox);
            this.Controls.Add(this._autorizationLoginTextBox);
            this.Controls.Add(this._autorizationLoginLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutorizationForm";
            this.Text = "AutorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _autorizationLoginLabel;
        private System.Windows.Forms.TextBox _autorizationLoginTextBox;
        private System.Windows.Forms.TextBox _autorizationPasswordTextBox;
        private System.Windows.Forms.Label _autorizationPasswordLabel;
        private System.Windows.Forms.Button _autorizationAcceptButton;
        private System.Windows.Forms.Label _autorizationLabel;
    }
}