using System;
using System.Data.SqlClient;
public class Test
{
	public static void Main(string[] args)
	{
        SqlConnection conn = null;
		Console.WriteLine(args[0]);
        var sql = $"select * from datatable where id = '{args[0]}'";
        using (SqlCommand command = new SqlCommand(sql, conn))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                }
            }
        }   
    }
}
//comment
