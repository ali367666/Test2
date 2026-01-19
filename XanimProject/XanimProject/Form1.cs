using Microsoft.Data.SqlClient;

namespace XanimProject;

public partial class Form1 : Form
{
    string _connectionString =
    @"Data Source=DESKTOP-ET5TVFM\SQLEXPRESS;
      Integrated Security=True;
      TrustServerCertificate=True;";
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        //using SqlConnection conn = new SqlConnection(connectionString);
        //conn.Open();
        //string query = "Select Name from Products";
        //using SqlCommand cmd = new SqlCommand(query, conn);
        //while (cmd.Parameters.Count > 0)
        //{
        //    Console.WriteLine($"{Name}");
        //}
    }

    public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        using SqlConnection con = new SqlConnection(_connectionString);
        con.Open();

        string query = $"SELECT Name FROM Products";
        using SqlCommand cmd = new SqlCommand(query, con);
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            
            Console.WriteLine($"{Name}");
        }
    }
}
