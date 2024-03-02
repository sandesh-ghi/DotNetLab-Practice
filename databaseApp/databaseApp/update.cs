using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseApp
{
    internal class update
    {
        static void Main(String[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            string sql = "update customers set address='Kathmandu' where accno=1234";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            int row = cmd.ExecuteNonQuery();

            if (row > 0)
            {
                Console.WriteLine("Data updated");
            }
            else
            {
                Console.WriteLine("Error updating data");
            }
            con.Close();
            Console.ReadKey();
        }
    }
}
