using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Person
    {
        public void sendMsg(String name, double oprice, double nprice)
        {
            Console.WriteLine("The price of stock " +
                name + " is changed from " + oprice + " to " + nprice);
        }
    }
    public delegate void priceChange(string name, double op, double np);
    public class stockTicker
    {
        public event priceChange pc;
        public string name { get; set; }
        public double price;
        public double Price
        {
            get { return price; }
            set
            {
                double oldprice = price;
                price = value;
                if (pc != null)
                {
                    pc.Invoke(name, oldprice, price);
                }

            }

        }

    }
    public class EventHandlling
    {
        public static string name;

        public static int Price { get; private set; }

        public static void Main(string[] args)
        {
            Person person = new Person();
            stockTicker stock = new stockTicker()
            {
                name = "Nabil",
            Price = 500
        };
            stock.pc += person.sendMsg;
            stock.Price = 900;
            Console.ReadKey();
        }
    }
}
