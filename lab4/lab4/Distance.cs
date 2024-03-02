using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Distance
  

    {
        private int feet;
        private int inches;

       
        public Distance()
        {
            feet = 0;
            inches = 0;
        }

      
        public Distance(int ft, int in_)
        {
            feet = ft;
            inches = in_;
        }

        
        public void AddDistance(Distance other)
        {
            inches += other.inches;
            feet += other.feet + (inches / 12);
            inches %= 12;
        }

       
        public void DisplayDistance()
        {
            Console.WriteLine($"Distance: {feet}feet-{inches}inc");
        }
    }

    class MyDistance
    {
        static void Main()
        {
          
            Distance distance1 = new Distance(5, 7);
            Distance distance2 = new Distance(3, 10);

            
            distance1.AddDistance(distance2);

            
            distance1.DisplayDistance();
        }
    }

}

