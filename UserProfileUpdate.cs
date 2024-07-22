// Extracting form data
string userId = Request.Form["userId"];
string newEmail = Request.Form["newEmail"];
string newPhone = Request.Form["newPhone"];

// Creating an update query
string query = "UPDATE Users SET Email = '" + newEmail + "', PhoneNumber = '" + newPhone + "'";
query += " WHERE UserId = " + userId;

// Executing the update command
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    cmd.ExecuteNonQuery();
}

// Optionally log update operation
