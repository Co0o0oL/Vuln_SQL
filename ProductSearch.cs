// Retrieving parameters from the GET request
string searchTerm = Request.QueryString["searchTerm"];
string sortColumn = Request.QueryString["sortColumn"];
string sortOrder = Request.QueryString["sortOrder"];

// Building the query to search products and sort results
string query = "SELECT * FROM Products WHERE Name LIKE '%" + searchTerm + "%'";
query += " ORDER BY " + sortColumn + " " + sortOrder;

// Executing the query
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    SqlDataReader reader = cmd.ExecuteReader();

    // Handling the search results
    while (reader.Read())
    {
        // Logic to process product data
    }
}
