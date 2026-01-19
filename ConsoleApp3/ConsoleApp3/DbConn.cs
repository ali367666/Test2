using Microsoft.Data.SqlClient;

namespace ConsoleApp3;

public class DbConn
{
    string connectionString =
@"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
Initial Catalog=PizzaMizza2;
Integrated Security=True;
Encrypt=True;
TrustServerCertificate=True;";
    private SqlConnection connection1;

    public  void SelectAll()
    {
        SqlConnection connection = new SqlConnection(connectionString);

        
        connection.Open();
        string query = "SELECT * FROM Products";
        SqlCommand sql = new SqlCommand(query, connection);
        using (SqlDataReader reader = sql.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"] + " - " + reader["Description"]);
            }
        }

    }

    public void Delete(int id)
    {


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = $"DELETE FROM Products WHERE ID = {id}";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
               
                connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Silindi ✅" : "Tapılmadı ❌");
            }
        }



    }
}
