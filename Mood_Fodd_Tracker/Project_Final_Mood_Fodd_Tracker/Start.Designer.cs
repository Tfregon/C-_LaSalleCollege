namespace Project_Final_Mood_Fodd_Tracker
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            label1 = new Label();
            label2 = new Label();
            textBoxNicknameUser = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 74);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Food Mood Tracker!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 261);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 1;
            label2.Text = "Please enter your nickname:";
            // 
            // textBoxNicknameUser
            // 
            textBoxNicknameUser.Location = new Point(73, 304);
            textBoxNicknameUser.Name = "textBoxNicknameUser";
            textBoxNicknameUser.Size = new Size(289, 27);
            textBoxNicknameUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 138);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 199);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 4;
            label3.Text = "Mood Food Tracker";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(160, 352);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 422);
            Controls.Add(buttonStart);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxNicknameUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Start";
            Text = "Mood Food Tracker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNicknameUser;
        private PictureBox pictureBox1;
        private Label label3;
        private Button buttonStart;
    }
}