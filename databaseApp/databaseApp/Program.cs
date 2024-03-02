using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string constr = "server=localhost;database=bank;uid=root;password='';";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            int accno, row = 0;
            string name, address;
            double Deposite;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Customer Record-" + i);
                accno = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                address = Console.ReadLine();
                Deposite = double.Parse(Console.ReadLine());
                string sql = "insert into customers values('" + accno + "','" + name + "','" + address + "','" + Deposite + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                row++;
            }
            if (row > 0)
            {
                Console.WriteLine(row + "row is inserted");
            }
            else
            {
                Console.WriteLine("error");
            }
            con.Close();
            Console.ReadLine();
        }
    }
}