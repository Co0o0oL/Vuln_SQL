using System;

class Program
{
    static void Main()
    {
        string connectionString = "your-connection-string-here";
        vulnX.DatabaseHelper dbHelper = new vulnX.DatabaseHelper(connectionString);

        // Vulnerable usage
        Console.WriteLine("Vulnerable function call:");
        dbHelper.GetUserDetails("1 OR 1=1");

        // Safe usage
        Console.WriteLine("\nSafe function call:");
        dbHelper.GetUserDetailsSafe("1");

        // Adding a new user
        Console.WriteLine("\nAdding a new user:");
        dbHelper.AddNewUser("newuser", "password123");
    }
}
