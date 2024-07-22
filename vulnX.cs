using System;
using System.Data.SqlClient;

namespace vulnX
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string connString)
        {
            connectionString = connString;
        }

        // Vulnerable function demonstrating SQL injection
        public void GetUserDetails(string userId)
        {
            // Vulnerable code: concatenating user input directly into SQL query
            string query = "SELECT * FROM Users WHERE UserId = '" + userId + "'";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Process user details
                while (reader.Read())
                {
                    Console.WriteLine($"User ID: {reader["UserId"]}, Username: {reader["Username"]}");
                }
            }
        }

        // Safe function using parameterized queries
        public void GetUserDetailsSafe(string userId)
        {
            // Safe code: using parameterized queries to prevent SQL injection
            string query = "SELECT * FROM Users WHERE UserId = @userId";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Process user details
                while (reader.Read())
                {
                    Console.WriteLine($"User ID: {reader["UserId"]}, Username: {reader["Username"]}");
                }
            }
        }

        // Another example function, not related to SQL injection
        public void AddNewUser(string username, string password)
        {
            // Safe code: using parameterized queries to prevent SQL injection
            string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
