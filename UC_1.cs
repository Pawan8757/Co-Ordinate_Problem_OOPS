using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LenthPblm
    {
        public void CalculatingLength()
        {
           double x1, x2, y1, y2;
            double  length;

            Console.WriteLine("Enter the value of x1:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt((x1-x2)* (x1 - x2) + (y1-y2)* (y1 - y2));
            Console.WriteLine(length);
            Console.ReadLine();




        }
    }
}
