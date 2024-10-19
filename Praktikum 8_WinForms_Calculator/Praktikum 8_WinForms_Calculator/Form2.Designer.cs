namespace Praktikum_8_WinForms_Calculator
{
    partial class Form2
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
            Header = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            value1 = new TextBox();
            value2 = new TextBox();
            value3 = new TextBox();
            opsi1 = new RadioButton();
            opsi2 = new RadioButton();
            opsi3 = new RadioButton();
            opsi4 = new RadioButton();
            groupBox1 = new GroupBox();
            Hitung = new Button();
            Kembali = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Coolvetica Rg", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(99, 45);
            Header.Name = "Header";
            Header.Size = new Size(405, 53);
            Header.TabIndex = 0;
            Header.Text = "Welcome, RamaKima!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 128);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Value 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 175);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Value 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 222);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Answer";
            // 
            // value1
            // 
            value1.Location = new Point(146, 125);
            value1.Name = "value1";
            value1.Size = new Size(70, 27);
            value1.TabIndex = 4;
            // 
            // value2
            // 
            value2.Location = new Point(146, 172);
            value2.Name = "value2";
            value2.Size = new Size(70, 27);
            value2.TabIndex = 5;
            // 
            // value3
            // 
            value3.Location = new Point(146, 219);
            value3.Name = "value3";
            value3.Size = new Size(70, 27);
            value3.TabIndex = 6;
            // 
            // opsi1
            // 
            opsi1.AutoSize = true;
            opsi1.Location = new Point(6, 5);
            opsi1.Name = "opsi1";
            opsi1.Size = new Size(112, 24);
            opsi1.TabIndex = 7;
            opsi1.TabStop = true;
            opsi1.Text = "Addition (+)";
            opsi1.UseVisualStyleBackColor = true;
            // 
            // opsi2
            // 
            opsi2.AutoSize = true;
            opsi2.Location = new Point(6, 38);
            opsi2.Name = "opsi2";
            opsi2.Size = new Size(126, 24);
            opsi2.TabIndex = 8;
            opsi2.TabStop = true;
            opsi2.Text = "Subtraction (-)";
            opsi2.UseVisualStyleBackColor = true;
            // 
            // opsi3
            // 
            opsi3.AutoSize = true;
            opsi3.Location = new Point(6, 71);
            opsi3.Name = "opsi3";
            opsi3.Size = new Size(143, 24);
            opsi3.TabIndex = 9;
            opsi3.TabStop = true;
            opsi3.Text = "Multiplication (x)";
            opsi3.UseVisualStyleBackColor = true;
            // 
            // opsi4
            // 
            opsi4.AutoSize = true;
            opsi4.Location = new Point(6, 104);
            opsi4.Name = "opsi4";
            opsi4.Size = new Size(103, 24);
            opsi4.TabIndex = 10;
            opsi4.TabStop = true;
            opsi4.Text = "Division (/)";
            opsi4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(opsi4);
            groupBox1.Controls.Add(opsi3);
            groupBox1.Controls.Add(opsi2);
            groupBox1.Controls.Add(opsi1);
            groupBox1.Location = new Point(355, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(149, 134);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // Hitung
            // 
            Hitung.Location = new Point(410, 265);
            Hitung.Name = "Hitung";
            Hitung.Size = new Size(94, 29);
            Hitung.TabIndex = 12;
            Hitung.Text = "Calculate";
            Hitung.UseVisualStyleBackColor = true;
            Hitung.Click += Hitung_Click;
            // 
            // Kembali
            // 
            Kembali.Location = new Point(99, 265);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(94, 29);
            Kembali.TabIndex = 13;
            Kembali.Text = "Back";
            Kembali.UseVisualStyleBackColor = true;
            Kembali.Click += Kembali_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 315);
            Controls.Add(Kembali);
            Controls.Add(Hitung);
            Controls.Add(groupBox1);
            Controls.Add(value3);
            Controls.Add(value2);
            Controls.Add(value1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Header);
            Name = "Form2";
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
        private Label label3;
        private TextBox value1;
        private TextBox value2;
        private TextBox value3;
        private RadioButton opsi1;
        private RadioButton opsi2;
        private RadioButton opsi3;
        private RadioButton opsi4;
        private GroupBox groupBox1;
        private Button Hitung;
        private Button Kembali;
    }
}