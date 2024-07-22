// Collecting order details from a form POST
string orderId = Request.Form["orderId"];
string productId = Request.Form["productId"];
string quantity = Request.Form["quantity"];
string customerName = Request.Form["customerName"];

// Constructing the SQL INSERT query
string query = "INSERT INTO Orders (OrderID, ProductID, Quantity, CustomerName) VALUES (";
query += "'" + orderId + "', '" + productId + "', " + quantity + ", '" + customerName + "')";

// Inserting the new order
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    cmd.ExecuteNonQuery();
}

// Optionally log the order insertion
