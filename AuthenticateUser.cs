// Fetching user credentials and optional parameters from GET request
string username = Request.QueryString["username"];
string password = Request.QueryString["password"];
string rememberMe = Request.QueryString["rememberMe"];

// Building the query to authenticate user
string query = "SELECT * FROM Users WHERE Username = '" + username + "'";
query += " AND Password = '" + password + "' AND RememberMe = '" + rememberMe + "'";

// Executing the authentication query
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    SqlDataReader reader = cmd.ExecuteReader();

    // Process authentication results
    while (reader.Read())
    {
        // Logic to handle authentication
    }
}
