
using Microsoft.Data.SqlClient;
namespace TesTing_Sistem;


public class ProjectsDBConnect
{
    private readonly string _connectionString =
        @"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
        Initial Catalog=PizzaMizza2;
        Integrated Security=True;
        TrustServerCertificate=True;";

    public void SelectAll(string tableName)
    {
        using SqlConnection conn = new SqlConnection(_connectionString);
        conn.Open();
        string query = $"select * from {tableName}";
        using SqlCommand cmd = new SqlCommand(query, conn);
        using SqlDataReader reader=cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader["ID"]}-{reader["Name"]}");
        }
    }
    public void DeleteByID(int id,string tableName)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(tableName))
                throw new ArgumentException("Invalid table name");
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            string query = $"Delete from {tableName} where ID=@id ";
            
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            int affected=cmd.ExecuteNonQuery();
            if(affected > 0)
            {
                Console.WriteLine($"ID-{id}, Table-{tableName} deleted successfully");
            }
            else
            {
                Console.WriteLine($"No record found with ID-{id}");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message+"Deleted failed");
        }
    }
}
