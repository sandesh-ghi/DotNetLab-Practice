using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Display
    {
        static void Main(String[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            string sql = "select * from customer";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("Id\t Name\t Address\tDeposit");

            while (dr.Read())
            {
                Console.WriteLine(dr[0]+"\t"+ dr[1] + "\t" +dr[2] + "\t" + dr[3] + "\t" );
            }
            con.Close();
            Console.ReadKey();
        }
    }
}
