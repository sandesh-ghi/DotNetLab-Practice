using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Update
    {
        static void Main(String[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            string sql = "update customer set address='Kathmandu' where id=1234";
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
