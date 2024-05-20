namespace WinFormsAppDEMO3
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            AddButtonUser = new Button();
            AddButtonUser2 = new Button();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            LogoutButton = new Button();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            AddShiftButton = new Button();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 330);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(686, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // AddButtonUser
            // 
            AddButtonUser.Location = new Point(189, 240);
            AddButtonUser.Name = "AddButtonUser";
            AddButtonUser.Size = new Size(93, 60);
            AddButtonUser.TabIndex = 1;
            AddButtonUser.Text = "Добавить пользователя";
            AddButtonUser.UseVisualStyleBackColor = true;
            AddButtonUser.Click += AddButtonUser_Click;
            // 
            // AddButtonUser2
            // 
            AddButtonUser2.Location = new Point(122, 12);
            AddButtonUser2.Name = "AddButtonUser2";
            AddButtonUser2.Size = new Size(93, 60);
            AddButtonUser2.TabIndex = 2;
            AddButtonUser2.Text = "Добавление (форма)";
            AddButtonUser2.UseVisualStyleBackColor = true;
            AddButtonUser2.Click += AddButtonUser2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(704, 330);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(690, 250);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 277);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(1319, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(1025, 31);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 10;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(751, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(751, 230);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 12;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(751, 277);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(751, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // AddShiftButton
            // 
            AddShiftButton.Location = new Point(966, 240);
            AddShiftButton.Name = "AddShiftButton";
            AddShiftButton.Size = new Size(93, 60);
            AddShiftButton.TabIndex = 15;
            AddShiftButton.Text = "Добавить смену";
            AddShiftButton.UseVisualStyleBackColor = true;
            AddShiftButton.Click += AddShiftButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(259, 31);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(101, 41);
            RefreshButton.TabIndex = 16;
            RefreshButton.Text = "обновить";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 592);
            Controls.Add(RefreshButton);
            Controls.Add(AddShiftButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(textBox3);
            Controls.Add(LogoutButton);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(AddButtonUser2);
            Controls.Add(AddButtonUser);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddButtonUser;
        private Button AddButtonUser2;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button LogoutButton;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker1;
        private Button AddShiftButton;
        private Button RefreshButton;
    }
}