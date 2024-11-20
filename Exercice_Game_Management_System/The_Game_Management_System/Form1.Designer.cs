namespace The_Game_Management_System
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonRegisterUser = new Button();
            buttonExit = new Button();
            groupBox2 = new GroupBox();
            buttonSearch = new Button();
            textBoxTypeOfGameSearch = new TextBox();
            textBoxTitleSearch = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dataGridViewSearch = new DataGridView();
            groupBox1 = new GroupBox();
            textBoxGameId = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dateTimePickerReleaseDate = new DateTimePicker();
            textBoxTypeOfGame = new TextBox();
            textBoxTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridViewUser = new DataGridView();
            groupBox3 = new GroupBox();
            buttonAddUser = new Button();
            buttonDelUser = new Button();
            checkedListBoxGameInUser = new CheckedListBox();
            checkedListBoxGenreUser = new CheckedListBox();
            textBoxUserName = new TextBox();
            textBoxIdUser = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(912, 508);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonRegisterUser);
            tabPage1.Controls.Add(buttonExit);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(904, 475);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterUser
            // 
            buttonRegisterUser.Location = new Point(740, 306);
            buttonRegisterUser.Name = "buttonRegisterUser";
            buttonRegisterUser.Size = new Size(94, 97);
            buttonRegisterUser.TabIndex = 20;
            buttonRegisterUser.Text = "Register User";
            buttonRegisterUser.UseVisualStyleBackColor = true;
            buttonRegisterUser.Click += buttonRegisterUser_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(594, 306);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 97);
            buttonExit.TabIndex = 19;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSearch);
            groupBox2.Controls.Add(textBoxTypeOfGameSearch);
            groupBox2.Controls.Add(textBoxTitleSearch);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dataGridViewSearch);
            groupBox2.Location = new Point(9, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 237);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Game";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(419, 64);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 97);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxTypeOfGameSearch
            // 
            textBoxTypeOfGameSearch.Location = new Point(6, 166);
            textBoxTypeOfGameSearch.Name = "textBoxTypeOfGameSearch";
            textBoxTypeOfGameSearch.Size = new Size(125, 27);
            textBoxTypeOfGameSearch.TabIndex = 18;
            // 
            // textBoxTitleSearch
            // 
            textBoxTitleSearch.Location = new Point(6, 75);
            textBoxTitleSearch.Name = "textBoxTitleSearch";
            textBoxTitleSearch.Size = new Size(125, 27);
            textBoxTitleSearch.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 121);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 17;
            label7.Text = "Type Of Game";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 39);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 16;
            label6.Text = "Title";
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(159, 26);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowHeadersWidth = 51;
            dataGridViewSearch.Size = new Size(254, 167);
            dataGridViewSearch.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxGameId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(dateTimePickerReleaseDate);
            groupBox1.Controls.Add(textBoxTypeOfGame);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 229);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register Game";
            // 
            // textBoxGameId
            // 
            textBoxGameId.Location = new Point(146, 185);
            textBoxGameId.Name = "textBoxGameId";
            textBoxGameId.Size = new Size(125, 27);
            textBoxGameId.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 188);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 14;
            label5.Text = "Game ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Solo", "PvP" });
            comboBox1.Location = new Point(146, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(409, 106);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Del";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(409, 66);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(409, 30);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(147, 102);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(250, 27);
            dateTimePickerReleaseDate.TabIndex = 9;
            // 
            // textBoxTypeOfGame
            // 
            textBoxTypeOfGame.Location = new Point(146, 63);
            textBoxTypeOfGame.Name = "textBoxTypeOfGame";
            textBoxTypeOfGame.Size = new Size(125, 27);
            textBoxTypeOfGame.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(146, 28);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 144);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Game Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 106);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Release Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Type Of Game";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(560, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 216);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewUser);
            tabPage2.Controls.Add(buttonDelUser);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(904, 475);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(514, 25);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(300, 188);
            dataGridViewUser.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonAddUser);
            groupBox3.Controls.Add(checkedListBoxGameInUser);
            groupBox3.Controls.Add(checkedListBoxGenreUser);
            groupBox3.Controls.Add(textBoxUserName);
            groupBox3.Controls.Add(textBoxIdUser);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(19, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 213);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Register User";
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(286, 144);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(94, 29);
            buttonAddUser.TabIndex = 9;
            buttonAddUser.Text = "Add User";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonDelUser
            // 
            buttonDelUser.Location = new Point(720, 399);
            buttonDelUser.Name = "buttonDelUser";
            buttonDelUser.Size = new Size(94, 29);
            buttonDelUser.TabIndex = 8;
            buttonDelUser.Text = "Exiit";
            buttonDelUser.UseVisualStyleBackColor = true;
            buttonDelUser.Click += buttonDelUser_Click;
            // 
            // checkedListBoxGameInUser
            // 
            checkedListBoxGameInUser.FormattingEnabled = true;
            checkedListBoxGameInUser.Location = new Point(96, 147);
            checkedListBoxGameInUser.Name = "checkedListBoxGameInUser";
            checkedListBoxGameInUser.Size = new Size(150, 26);
            checkedListBoxGameInUser.TabIndex = 7;
            // 
            // checkedListBoxGenreUser
            // 
            checkedListBoxGenreUser.FormattingEnabled = true;
            checkedListBoxGenreUser.Items.AddRange(new object[] { "Male", "Female" });
            checkedListBoxGenreUser.Location = new Point(98, 110);
            checkedListBoxGenreUser.Name = "checkedListBoxGenreUser";
            checkedListBoxGenreUser.Size = new Size(150, 26);
            checkedListBoxGenreUser.TabIndex = 6;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(96, 71);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(125, 27);
            textBoxUserName.TabIndex = 5;
            // 
            // textBoxIdUser
            // 
            textBoxIdUser.Location = new Point(96, 37);
            textBoxIdUser.Name = "textBoxIdUser";
            textBoxIdUser.Size = new Size(125, 27);
            textBoxIdUser.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 153);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 3;
            label11.Text = "Game";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 111);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 2;
            label10.Text = "Genre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 71);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 1;
            label9.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 39);
            label8.Name = "label8";
            label8.Size = new Size(22, 20);
            label8.TabIndex = 0;
            label8.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 579);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private DateTimePicker dateTimePickerReleaseDate;
        private TextBox textBoxTypeOfGame;
        private TextBox textBoxTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBoxGameId;
        private GroupBox groupBox2;
        private Button buttonSearch;
        private TextBox textBoxTypeOfGameSearch;
        private TextBox textBoxTitleSearch;
        private Label label7;
        private Label label6;
        private DataGridView dataGridViewSearch;
        private Button buttonRegisterUser;
        private Button buttonExit;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dataGridViewUser;
        private CheckedListBox checkedListBoxGameInUser;
        private CheckedListBox checkedListBoxGenreUser;
        private TextBox textBoxUserName;
        private TextBox textBoxIdUser;
        private Label label11;
        private Button buttonAddUser;
        private Button buttonDelUser;
    }
}
