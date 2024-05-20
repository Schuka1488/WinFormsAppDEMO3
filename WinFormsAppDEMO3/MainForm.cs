using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsAppDEMO3
{
    public partial class MainForm : Form
    {
        private DatabaseManager databaseManager;
        System.Data.DataTable dataTable;
        public MainForm(string userType)
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();

            if (userType != "Administrator")
            {
                button1.Visible = false;
            }

            LoadComboBoxData();
        }

        private void LoadUserData()
        {
            dataGridView1.DataSource = null;
            string query = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);


            DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
            var list = new List<string>() { "Уволен", "Активен" };
            status.DataSource = list;
            status.HeaderText = "Статус";
            status.DataPropertyName = "UserStatus";

            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

            dataGridView1.Columns.AddRange(status);
        }
        private void LoadShiftData()
        {
            dataGridView2.DataSource = null;
            string query = "SELECT * FROM shifts";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

        }
        private void LoadComboBoxData()
        {
            string queryUserTypes = "SELECT DISTINCT UserType FROM Users";
            MySqlCommand cmdUserTypes = new MySqlCommand(queryUserTypes, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmdUserTypes.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("UserType"));
                }
            }

            string queryUserStatuses = "SELECT DISTINCT UserStatus FROM Users";
            MySqlCommand cmdUserStatuses = new MySqlCommand(queryUserStatuses, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmdUserStatuses.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString("UserStatus"));
                }
            }
            string query1 = "SELECT DISTINCT WaiterID FROM Shifts";
            MySqlCommand cmd1 = new MySqlCommand(query1, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetInt32("WaiterID").ToString());
                }
            }

            string query2 = "SELECT DISTINCT ChefID FROM Shifts";
            MySqlCommand cmd2 = new MySqlCommand(query2, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBox4.Items.Add(reader.GetInt32("ChefID").ToString());
                }
            }
        }

        private void AddButtonUser_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string userType = comboBox1.SelectedItem.ToString();
            string userStatus = comboBox2.SelectedItem.ToString();

            string query = "INSERT INTO Users (Username, Password, UserType, UserStatus) VALUES (@username, @password, @userType, @userStatus)";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@userType", userType);
            cmd.Parameters.AddWithValue("@userStatus", userStatus);

            cmd.ExecuteNonQuery();

            LoadUserData();
        }

        private void AddButtonUser2_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadShiftData();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        void SetStatusEmployee(int id, string fired)
        {
            MySqlCommand cmd = new MySqlCommand($"UPDATE users SET UserStatus='{fired}' WHERE UserID={id};", databaseManager.GetConnection());
            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            SetStatusEmployee(Convert.ToInt32(dataTable.Rows[i]["UserID"]), Convert.ToString(dataTable.Rows[i]["UserStatus"]));
            LoadUserData();
        }
        void SetWaiterID(int id, string fired)
        {
            MySqlCommand cmd = new MySqlCommand($"UPDATE users SET UserStatus='{fired}' WHERE UserID={id};", databaseManager.GetConnection());
            cmd.ExecuteNonQuery();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            SetWaiterID(Convert.ToInt32(dataTable.Rows[i]["ShiftID"]), Convert.ToString(dataTable.Rows[i]["WaiterID"]));
            LoadShiftData();
        }

        private void AddShiftButton_Click(object sender, EventArgs e)
        {
            string shiftdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string desc = textBox3.Text;
            string wait = comboBox3.SelectedItem.ToString();
            string chef = comboBox4.SelectedItem.ToString();

            string query = "INSERT INTO Shifts (ShiftDate, ShiftDescription, WaiterID, ChefID) VALUES (@shiftdate, @desc, @wait, @chef)";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            cmd.Parameters.AddWithValue("@shiftdate", shiftdate);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@wait", wait);
            cmd.Parameters.AddWithValue("@chef", chef);

            cmd.ExecuteNonQuery();

            LoadShiftData();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
