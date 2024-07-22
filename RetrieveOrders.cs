// Extracting date range from GET request
string startDate = Request.QueryString["startDate"];
string endDate = Request.QueryString["endDate"];

// Building the query to retrieve orders
string query = "SELECT * FROM Orders WHERE OrderDate BETWEEN '" + startDate + "' AND '" + endDate + "'";

// Executing the query
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    SqlDataReader reader = cmd.ExecuteReader();

    // Processing the results
    while (reader.Read())
    {
        // Logic to handle order data
    }
}
