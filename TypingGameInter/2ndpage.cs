using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TypingGameInter
{
    public partial class _2ndpage : Form
    {
        private readonly dbConnection DbConnection;

        
        public _2ndpage()
        {
            InitializeComponent();
            DbConnection = new dbConnection(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter Your Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display the name in Form1
            Form1 form1 = new Form1();
            form1.NameLabel.Text = nameTextBox.Text;
            form1.Show();
            this.Close();
        }

        public void SaveNameScoreAndTimeToDatabase(string name, int correct, int mistakes, int chosenTimeInSeconds, string tableName)
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    string query = $"INSERT INTO {tableName} (UserName, Score, Mistakes, ChosenTime) VALUES (@UserName, @Score, @Mistakes, @ChosenTime)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", name);
                        command.Parameters.AddWithValue("@Score", correct);
                        command.Parameters.AddWithValue("@Mistakes", mistakes);
                        command.Parameters.AddWithValue("@ChosenTime", chosenTimeInSeconds);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _1stpage p1 = new _1stpage();
            p1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter Your Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Display the name in Form2
            Form2 form2 = new Form2();
            form2.NameLabel.Text = nameTextBox.Text;
            form2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please Enter Your Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Display the name in Form3
            Form3 form3 = new Form3();
            form3.NameLabel.Text = nameTextBox.Text;
            form3.Show();
            this.Close();
        }

        public class dbConnection
        {
            private readonly string connectionString;

            
            public dbConnection()
            {
                
                connectionString = "Data Source=DESKTOP-33FFJIP\\SQLEXPRESS;Initial Catalog=SpeedTypingSystem;Integrated Security=True;TrustServerCertificate=True";
            }

            
            public dbConnection(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
