using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseApp
{
    internal class userinput
    {
        static void Main(String[] args)
        {
            string constr = "server=localhost; database=bank; uid=root; password='';";

            MySqlConnection con = new MySqlConnection(constr);

            con.Open();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Contumer Derails:");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Deposit:");
                double amount = double.Parse(Console.ReadLine());

                string sql = ($"insert into customers values ({id},'{name}','{address}',{amount})");
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

            }
            con.Close();
            Console.ReadKey();
        }
    }
}
