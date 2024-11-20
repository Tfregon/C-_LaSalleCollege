namespace Midterm_03_05_Management_hospital
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
            Appointment = new GroupBox();
            dateTimePickerSchedule = new DateTimePicker();
            checkedListBoxNurse = new CheckedListBox();
            checkedListBoxDoctor = new CheckedListBox();
            checkBoxBlood = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBoxXray = new CheckBox();
            checkBoxCheckUp = new CheckBox();
            button_Next = new Button();
            button_Exit = new Button();
            Appointment.SuspendLayout();
            SuspendLayout();
            // 
            // Appointment
            // 
            Appointment.Controls.Add(checkBoxCheckUp);
            Appointment.Controls.Add(checkBoxXray);
            Appointment.Controls.Add(label4);
            Appointment.Controls.Add(label3);
            Appointment.Controls.Add(label2);
            Appointment.Controls.Add(label1);
            Appointment.Controls.Add(checkBoxBlood);
            Appointment.Controls.Add(checkedListBoxDoctor);
            Appointment.Controls.Add(checkedListBoxNurse);
            Appointment.Controls.Add(dateTimePickerSchedule);
            Appointment.Location = new Point(23, 15);
            Appointment.Name = "Appointment";
            Appointment.Size = new Size(527, 319);
            Appointment.TabIndex = 0;
            Appointment.TabStop = false;
            Appointment.Text = "Appointment";
            // 
            // dateTimePickerSchedule
            // 
            dateTimePickerSchedule.Location = new Point(146, 47);
            dateTimePickerSchedule.Name = "dateTimePickerSchedule";
            dateTimePickerSchedule.Size = new Size(250, 27);
            dateTimePickerSchedule.TabIndex = 0;
            // 
            // checkedListBoxNurse
            // 
            checkedListBoxNurse.FormattingEnabled = true;
            checkedListBoxNurse.Items.AddRange(new object[] { "Misty", "Jina", "Rolly" });
            checkedListBoxNurse.Location = new Point(147, 100);
            checkedListBoxNurse.Name = "checkedListBoxNurse";
            checkedListBoxNurse.Size = new Size(249, 26);
            checkedListBoxNurse.TabIndex = 1;
            // 
            // checkedListBoxDoctor
            // 
            checkedListBoxDoctor.FormattingEnabled = true;
            checkedListBoxDoctor.Items.AddRange(new object[] { "Thomas", "Ricardo", "Andreas", "Katherin" });
            checkedListBoxDoctor.Location = new Point(147, 158);
            checkedListBoxDoctor.Name = "checkedListBoxDoctor";
            checkedListBoxDoctor.Size = new Size(249, 26);
            checkedListBoxDoctor.TabIndex = 2;
            // 
            // checkBoxBlood
            // 
            checkBoxBlood.AutoSize = true;
            checkBoxBlood.Location = new Point(115, 237);
            checkBoxBlood.Name = "checkBoxBlood";
            checkBoxBlood.Size = new Size(71, 24);
            checkBoxBlood.TabIndex = 3;
            checkBoxBlood.Text = "Blood";
            checkBoxBlood.UseVisualStyleBackColor = true;
            checkBoxBlood.CheckedChanged += checkBoxBlood_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 4;
            label1.Text = "Date Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 100);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Nurse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 158);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "Doctor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 237);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Exam";
            // 
            // checkBoxXray
            // 
            checkBoxXray.AutoSize = true;
            checkBoxXray.Location = new Point(192, 237);
            checkBoxXray.Name = "checkBoxXray";
            checkBoxXray.Size = new Size(70, 24);
            checkBoxXray.TabIndex = 8;
            checkBoxXray.Text = "X-Ray";
            checkBoxXray.UseVisualStyleBackColor = true;
            checkBoxXray.CheckedChanged += checkBoxXray_CheckedChanged;
            // 
            // checkBoxCheckUp
            // 
            checkBoxCheckUp.AutoSize = true;
            checkBoxCheckUp.Location = new Point(268, 237);
            checkBoxCheckUp.Name = "checkBoxCheckUp";
            checkBoxCheckUp.Size = new Size(95, 24);
            checkBoxCheckUp.TabIndex = 9;
            checkBoxCheckUp.Text = "Check-Up";
            checkBoxCheckUp.UseVisualStyleBackColor = true;
            checkBoxCheckUp.CheckedChanged += checkBoxCheckUp_CheckedChanged;
            // 
            // button_Next
            // 
            button_Next.Location = new Point(456, 373);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(94, 29);
            button_Next.TabIndex = 1;
            button_Next.Text = "Next";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Click += button_Next_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(356, 373);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(94, 29);
            button_Exit.TabIndex = 2;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 429);
            Controls.Add(button_Exit);
            Controls.Add(button_Next);
            Controls.Add(Appointment);
            Name = "Form2";
            Text = "Form2";
            Appointment.ResumeLayout(false);
            Appointment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Appointment;
        private DateTimePicker dateTimePickerSchedule;
        private CheckBox checkBoxCheckUp;
        private CheckBox checkBoxXray;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxBlood;
        private CheckedListBox checkedListBoxDoctor;
        private CheckedListBox checkedListBoxNurse;
        private Button button_Next;
        private Button button_Exit;
    }
}