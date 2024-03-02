using MySql.Data.MySqlClient;
using System;

namespace databaseApp
{
    internal class delete
    {
        static void Main(string[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            string sql = "delete from customers where accno=103";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            int row = cmd.ExecuteNonQuery();

            if (row > 0)
            {
                Console.WriteLine("Data deleted");
            }
            else
            {
                Console.WriteLine("Error deleting data");
            }
            con.Close();
            Console.ReadKey();
        }
    }
}
