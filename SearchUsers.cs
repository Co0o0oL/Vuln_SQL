// Retrieving search criteria from a form POST
string searchName = Request.Form["searchName"];
string searchStatus = Request.Form["searchStatus"];

// Constructing a dynamic SQL query
string query = "SELECT * FROM Users WHERE Name LIKE '%" + searchName + "%'";
query += " AND Status = '" + searchStatus + "'";

// Executing the query
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    SqlDataReader reader = cmd.ExecuteReader();

    // Handling the search results
    while (reader.Read())
    {
        // Logic to process user data
    }
}
