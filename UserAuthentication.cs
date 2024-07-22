// Extracting user input from a POST request
string username = Request.Form["username"];
string password = Request.Form["password"];
string rememberMe = Request.Form["rememberMe"];

// Constructing a query to authenticate the user
string query = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
query += " AND RememberMe = '" + rememberMe + "' AND Active = 1";

// Preparing and executing the SQL command
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    SqlDataReader reader = cmd.ExecuteReader();

    // Process the results
    while (reader.Read())
    {
        // Logic to handle user data
    }
}
