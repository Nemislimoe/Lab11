namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.RegistrButton = new System.Windows.Forms.Button();
            this.agreementCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.PasswordBox = new System.Windows.Forms.GroupBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordBox = new System.Windows.Forms.GroupBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.GroupBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.LoginBox.SuspendLayout();
            this.PasswordBox.SuspendLayout();
            this.ConfirmPasswordBox.SuspendLayout();
            this.EmailBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AllowDrop = true;
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(328, 23);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(127, 25);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.Text = "Registration";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistrationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(115, 18);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(120, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // RegistrButton
            // 
            this.RegistrButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegistrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrButton.Location = new System.Drawing.Point(295, 334);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(193, 42);
            this.RegistrButton.TabIndex = 2;
            this.RegistrButton.Text = "Registr";
            this.RegistrButton.UseVisualStyleBackColor = true;
            this.RegistrButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // agreementCheckBox
            // 
            this.agreementCheckBox.AutoSize = true;
            this.agreementCheckBox.Location = new System.Drawing.Point(291, 297);
            this.agreementCheckBox.Name = "agreementCheckBox";
            this.agreementCheckBox.Size = new System.Drawing.Size(223, 17);
            this.agreementCheckBox.TabIndex = 3;
            this.agreementCheckBox.Text = "if you agree with confidentiality agreement";
            this.agreementCheckBox.UseVisualStyleBackColor = true;
            this.agreementCheckBox.CheckedChanged += new System.EventHandler(this.agreementCheckBox_CheckedChanged);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(31, 18);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(52, 20);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login:";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.LoginLabel);
            this.LoginBox.Controls.Add(this.LoginTextBox);
            this.LoginBox.Location = new System.Drawing.Point(272, 73);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(243, 50);
            this.LoginBox.TabIndex = 5;
            this.LoginBox.TabStop = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Controls.Add(this.PasswordLabel);
            this.PasswordBox.Controls.Add(this.PasswordTextBox);
            this.PasswordBox.Location = new System.Drawing.Point(272, 129);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(243, 50);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.TabStop = false;
            this.PasswordBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(15, 18);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(115, 18);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.Controls.Add(this.ConfirmPasswordLabel);
            this.ConfirmPasswordBox.Controls.Add(this.ConfirmPasswordTextBox);
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(253, 185);
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(285, 50);
            this.ConfirmPasswordBox.TabIndex = 7;
            this.ConfirmPasswordBox.TabStop = false;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(6, 18);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(140, 20);
            this.ConfirmPasswordLabel.TabIndex = 4;
            this.ConfirmPasswordLabel.Text = "Confirm password:";
            this.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmPasswordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(150, 18);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.ConfirmPasswordTextBox.TabIndex = 1;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Controls.Add(this.EmailLabel);
            this.EmailBox.Controls.Add(this.EmailTextBox);
            this.EmailBox.Location = new System.Drawing.Point(291, 241);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(197, 50);
            this.EmailBox.TabIndex = 8;
            this.EmailBox.TabStop = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(6, 18);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(52, 20);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(69, 18);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(120, 20);
            this.EmailTextBox.TabIndex = 1;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(318, 318);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessageLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(769, 386);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.ConfirmPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.agreementCheckBox);
            this.Controls.Add(this.RegistrButton);
            this.Controls.Add(this.RegistrationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.PasswordBox.ResumeLayout(false);
            this.PasswordBox.PerformLayout();
            this.ConfirmPasswordBox.ResumeLayout(false);
            this.ConfirmPasswordBox.PerformLayout();
            this.EmailBox.ResumeLayout(false);
            this.EmailBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button RegistrButton;
        private System.Windows.Forms.CheckBox agreementCheckBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.GroupBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.GroupBox ConfirmPasswordBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.GroupBox EmailBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}

