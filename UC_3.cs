using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public  class Comparision
    {
        public void ComparingTwoLine()
        {
            double x1, x2, y1, y2, x3, y3, x4, y4;
            double Length1, Length2;

            Console.WriteLine("Enter the value of 1st line");

            Console.WriteLine("Enter the value of x1:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine(Length1);


            Console.WriteLine("Enter the value of 2nd line");

            Console.WriteLine("Enter the value of x3:");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x4:");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y3:");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y4:");
            y4 = Convert.ToInt32(Console.ReadLine());

            Length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine(Length2);

            if (Length1.Equals(Length2))
            {
                Console.WriteLine("both the line are equal");

            }
            else if (Length1 > Length2)
            {
                Console.WriteLine("lenth2 is greater than length1");
            }
            else
            {
                Console.WriteLine("lenth1 is greater than length2");
            }
        }
    }
}
