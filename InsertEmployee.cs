// Collecting employee data from a form POST
string firstName = Request.Form["firstName"];
string lastName = Request.Form["lastName"];
string email = Request.Form["email"];
string salary = Request.Form["salary"];

// Constructing the SQL INSERT query
string query = "INSERT INTO Employees (FirstName, LastName, Email, Salary) VALUES (";
query += "'" + firstName + "', '" + lastName + "', '" + email + "', " + salary + ")";

// Inserting new employee record
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(query, connection);
    connection.Open();
    cmd.ExecuteNonQuery();
}

// Optionally log insertion
