namespace Praktikum_8_WinForms_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Header = new Label();
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            Login = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Coolvetica Rg", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(202, 47);
            Header.Name = "Header";
            Header.Size = new Size(198, 53);
            Header.TabIndex = 0;
            Header.Text = "Welcome!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F);
            label2.Location = new Point(11, 69);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // username
            // 
            username.Location = new Point(112, 19);
            username.Name = "username";
            username.Size = new Size(198, 27);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(112, 67);
            password.Name = "password";
            password.Size = new Size(198, 27);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(216, 119);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Login);
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(username);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(131, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 165);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 314);
            Controls.Add(groupBox1);
            Controls.Add(Header);
            Name = "Form1";
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button Login;
        private GroupBox groupBox1;
    }
}
