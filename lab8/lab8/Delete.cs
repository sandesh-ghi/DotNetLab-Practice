using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Delete
    {
        static void Main(String[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            string sql = "delete from customer where id=1006";
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
