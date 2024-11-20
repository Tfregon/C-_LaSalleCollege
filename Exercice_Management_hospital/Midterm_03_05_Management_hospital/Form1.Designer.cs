namespace Midterm_03_05_Management_hospital
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            textBoxCity = new TextBox();
            textBoxPostalCode = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBoxUnit = new TextBox();
            checkedListBox1 = new CheckedListBox();
            dateTimePickerBirthday = new DateTimePicker();
            textBoxPhone = new TextBox();
            textBoxID = new TextBox();
            textBoxlastName = new TextBox();
            textBoxFirstName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonNext = new Button();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCity);
            groupBox1.Controls.Add(textBoxPostalCode);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxUnit);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(dateTimePickerBirthday);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxlastName);
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Management";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(428, 92);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 17;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(428, 139);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(125, 27);
            textBoxPostalCode.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(346, 142);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 15;
            label9.Text = "Postal Code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 92);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 14;
            label8.Text = "City";
            // 
            // textBoxUnit
            // 
            textBoxUnit.Location = new Point(428, 42);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(125, 27);
            textBoxUnit.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Male", "Female" });
            checkedListBox1.Location = new Point(428, 190);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 48);
            checkedListBox1.TabIndex = 12;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(97, 235);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(250, 27);
            dateTimePickerBirthday.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(123, 183);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 10;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(137, 135);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(111, 27);
            textBoxID.TabIndex = 9;
            // 
            // textBoxlastName
            // 
            textBoxlastName.Location = new Point(123, 92);
            textBoxlastName.Name = "textBoxlastName";
            textBoxlastName.Size = new Size(125, 27);
            textBoxlastName.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(123, 49);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 190);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 49);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 240);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 190);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 142);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Identification:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 56);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(622, 390);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(94, 29);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(503, 390);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonNext);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePickerBirthday;
        private TextBox textBoxPhone;
        private TextBox textBoxID;
        private TextBox textBoxlastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxUnit;
        private CheckedListBox checkedListBox1;
        private Label label8;
        private TextBox textBoxCity;
        private TextBox textBoxPostalCode;
        private Label label9;
        private Button buttonNext;
        private Button buttonExit;
    }
}