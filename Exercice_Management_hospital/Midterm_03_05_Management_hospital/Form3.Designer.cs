namespace Midterm_03_05_Management_hospital
{
    partial class Form3
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
            groupBox5 = new GroupBox();
            labelNurse = new Label();
            groupBox4 = new GroupBox();
            labelTypeExam = new Label();
            groupBox3 = new GroupBox();
            labelDoctor = new Label();
            groupBox2 = new GroupBox();
            labelName = new Label();
            buttonEnd = new Button();
            buttonShowInfo = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(13, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelNurse);
            groupBox5.Location = new Point(328, 133);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 70);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Nurse";
            // 
            // labelNurse
            // 
            labelNurse.AutoSize = true;
            labelNurse.Location = new Point(17, 34);
            labelNurse.Name = "labelNurse";
            labelNurse.Size = new Size(0, 20);
            labelNurse.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelTypeExam);
            groupBox4.Location = new Point(39, 204);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(257, 70);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Type of Exam";
            // 
            // labelTypeExam
            // 
            labelTypeExam.AutoSize = true;
            labelTypeExam.Location = new Point(30, 34);
            labelTypeExam.Name = "labelTypeExam";
            labelTypeExam.Size = new Size(0, 20);
            labelTypeExam.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelDoctor);
            groupBox3.Location = new Point(328, 51);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 62);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Doctor";
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Location = new Point(17, 23);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(0, 20);
            labelDoctor.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelName);
            groupBox2.Location = new Point(39, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Name of Patient";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 20);
            labelName.TabIndex = 0;
            // 
            // buttonEnd
            // 
            buttonEnd.Location = new Point(682, 202);
            buttonEnd.Name = "buttonEnd";
            buttonEnd.Size = new Size(94, 123);
            buttonEnd.TabIndex = 1;
            buttonEnd.Text = "End";
            buttonEnd.UseVisualStyleBackColor = true;
            buttonEnd.Click += buttonEnd_Click;
            // 
            // buttonShowInfo
            // 
            buttonShowInfo.Location = new Point(682, 43);
            buttonShowInfo.Name = "buttonShowInfo";
            buttonShowInfo.Size = new Size(94, 123);
            buttonShowInfo.TabIndex = 2;
            buttonShowInfo.Text = "Show";
            buttonShowInfo.UseVisualStyleBackColor = true;
            buttonShowInfo.Click += buttonShowInfo_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowInfo);
            Controls.Add(buttonEnd);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Label labelNurse;
        private Label labelTypeExam;
        private Label labelDoctor;
        private Label labelName;
        private Button buttonEnd;
        private Button buttonShowInfo;
    }
}