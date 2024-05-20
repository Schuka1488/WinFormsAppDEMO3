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

namespace WinFormsAppDEMO3
{
    public partial class AddUserForm : Form
    {
        private DatabaseManager databaseManager;

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
        }
        public AddUserForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            LoadComboBoxData();
        }

        private void button1_Click(object sender, EventArgs e)
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

            this.Close();
        }
    }
}
