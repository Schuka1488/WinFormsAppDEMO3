using MySql.Data.MySqlClient;

namespace WinFormsAppDEMO3
{
    public partial class Form1 : Form
    {
        private DatabaseManager databaseManager;

        public Form1()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            string username = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            MySqlConnection connection = databaseManager.GetConnection();

            string query = "SELECT UserType FROM Users WHERE Username = @username AND Password = @password";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            object userType = cmd.ExecuteScalar();

            if (userType != null)
            {
                MainForm mainForm = new MainForm(userType.ToString());
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("???????? ????? ??? ??????");
            }
        }
    }
}
