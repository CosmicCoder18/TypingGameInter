using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGameInter
{
    public partial class Form3 : Form
    {
        string[] words = { "Pneumonoultramicroscopicsilicovolcanoconiosis", "Hippopotomonstrosesquippedaliophobia", "Supercalifragilisticexpialidocious", "Pseudopseudohypoparathyroidism", "Floccinaucinihilipilification" };

        Random rnd = new Random();
        int seconds = 0;
        int correct = 0;
        int incorrect = 0;
        int chosenTimeInSeconds;

        private _2ndpage.dbConnection DbConnection;
        private _2ndpage _2ndPageInstance;
        private TextBox nameTextBox;

        public Form3()
        {
            InitializeComponent();

            lblword.Text = words[rnd.Next(0, words.Length)];

            // Initialize DbConnection
            DbConnection = new _2ndpage.dbConnection();

            // Initialize _2ndpage instance
            _2ndPageInstance = new _2ndpage();
        }

        private void CheckGame(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblword.Text)
                {
                    correct++;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                else
                {
                    incorrect++;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                lblright.Text = "Score: " + correct;
                lblwrong.Text = "Mistake: " + incorrect;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chosenTimeInSeconds = 15;
            StartGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chosenTimeInSeconds = 30;
            StartGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chosenTimeInSeconds = 60;
            StartGame();
        }
        private void StartGame()
        {
            // Reset the timer and start it
            seconds = chosenTimeInSeconds;
            countdownTimer.Start();
        }
        
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = seconds--.ToString();
            if (seconds < 0)
            {
                countdownTimer.Stop();

                // Save the user's name, score, and time to the "Scores2" table in the database
                _2ndPageInstance.SaveNameScoreAndTimeToDatabase(NameLabel.Text, correct, incorrect, chosenTimeInSeconds, "Scores3");

                lblright.Text = "Score: 0 ";
                lblwrong.Text = "Mistake: 0 ";
                MessageBox.Show("Congratulations...\nThis is the result\nScore: " + correct + "\nMistake: " + incorrect, "Typing Game Intermediate");

                // Refresh the DataGridView with the latest scores
                DisplayPlayerScores();

                correct = 0; incorrect = 0;
                this.Hide();
                _2ndPageInstance.Show();
            }
        }
        private void DisplayPlayerScores()
        {
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT ID, UserName AS dgvName, Score AS dgvScores, Mistakes AS dgvMistakes, ChosenTime AS dgvChosenTime FROM Scores3 ORDER BY Score DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing data in the DataGridView
                            dataGridView1.Rows.Clear();

                            while (reader.Read())
                            {
                                // Add a new row to the DataGridView with player data
                                dataGridView1.Rows.Add(
                                    reader["ID"].ToString(),
                                    reader["dgvName"].ToString(),
                                    reader["dgvScores"].ToString(),
                                    reader["dgvMistakes"].ToString(),
                                    reader["dgvChosenTime"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception for further investigation if needed
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }

       
       

        private void lblScreen_Click(object sender, EventArgs e)
        {

        }

        private void lblwrong_Click(object sender, EventArgs e)
        {

        }
                
        private void lblright_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            _2ndpage p2 = new _2ndpage();
            p2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // Initialize DbConnection
            DbConnection = new _2ndpage.dbConnection();

            // Call the method to display player scores when the form is loaded
            DisplayPlayerScores();
        }
    }
}

