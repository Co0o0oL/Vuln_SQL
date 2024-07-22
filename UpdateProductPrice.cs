// Retrieving product ID and new price from a form POST
string productId = Request.Form["productId"];
string newPrice = Request.Form["newPrice"];

// Building the update query
string query = "UPDATE Products SET Price = " + newPrice + " WHERE ProductID = " + productId;

// Executing the update command
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    cmd.ExecuteNonQuery();
}

// Optionally log the update
