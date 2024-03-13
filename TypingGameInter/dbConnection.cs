using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameInter
{
    internal class dbConnection
    {
        private string connectionString;

        public dbConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveScore(string playerName, int score, int mistakes)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Try_SpeedType (Player_ID, Player_Name, Score, Mistakes) VALUES (@Player_ID, @Player_Name, @Score, @Mistakes)", connection))
                    {
                        command.Parameters.AddWithValue("@Player_ID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@Player_Name", playerName);
                        command.Parameters.AddWithValue("@Score", score);
                        command.Parameters.AddWithValue("@Mistakes", mistakes);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log, display a message, etc.)
                Console.WriteLine($"Error saving score: {ex.Message}");
            }
        }

    }
}

