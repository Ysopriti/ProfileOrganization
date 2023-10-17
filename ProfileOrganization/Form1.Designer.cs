namespace ProfileOrganization
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            cbPrograms = new ComboBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 85);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 80);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 119);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(619, 119);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 4;
            label5.Text = "M.I";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 168);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 158);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 200);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Birthday:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(338, 203);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 8;
            label9.Text = "Contact No.:";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(311, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(145, 77);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(153, 23);
            txtStudentNo.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(145, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(153, 23);
            txtLastName.TabIndex = 11;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(417, 72);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(173, 23);
            cbPrograms.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(417, 111);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 13;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(649, 111);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(63, 23);
            txtMiddleInitial.TabIndex = 14;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(145, 160);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(153, 23);
            txtAge.TabIndex = 15;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(417, 195);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(173, 23);
            txtContactNo.TabIndex = 16;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(417, 150);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(173, 23);
            cbGender.TabIndex = 17;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(145, 200);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(153, 23);
            datePickerBirthday.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(36, 32);
            label10.Name = "label10";
            label10.Size = new Size(159, 18);
            label10.TabIndex = 19;
            label10.Text = "REGISTRATION*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 316);
            Controls.Add(label10);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(cbPrograms);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private ComboBox cbPrograms;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Label label10;
    }
}