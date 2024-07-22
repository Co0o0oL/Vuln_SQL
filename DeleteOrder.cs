// Fetching order ID from GET request
string orderId = Request.QueryString["orderId"];
string customerId = Request.QueryString["customerId"];

// Constructing the SQL DELETE query
string query = "DELETE FROM Orders WHERE OrderID = " + orderId;
query += " AND CustomerID = " + customerId;

// Executing the delete command
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    cmd.ExecuteNonQuery();
}

// Optionally confirm deletion
