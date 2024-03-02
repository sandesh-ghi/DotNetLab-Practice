using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseApp
{
    internal class insert
    {
        static void Main(String[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            string sql = "insert into customers value (1234,'Ramesh','Kathmandu',45000)";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            int row = cmd.ExecuteNonQuery();

            if (row > 0)
            {
                Console.WriteLine("Data inserted");
            }
            else
            {
                Console.WriteLine("Error inserting data");
            }
            con.Close();
            Console.ReadKey();
        }
    }
}
