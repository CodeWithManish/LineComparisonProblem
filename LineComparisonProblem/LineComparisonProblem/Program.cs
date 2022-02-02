using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program");
            LineComparison line1 = new LineComparison(3, 5, 4, 5);
            line1.CalculateLength();
            LineComparison line2 = new LineComparison(1, 2, 4, 5);
            line2.CalculateLength();
            if (line1.CalculateLength() > line2.CalculateLength())
            {
                Console.WriteLine("Line1 is greater than line2 \n");
            }
            if (line1.CalculateLength() < line2.CalculateLength())
            {
                Console.WriteLine("Lines1 is smaller than Line2 \n");
            }
            if (line1.CalculateLength() == line2.CalculateLength())
            {
                Console.WriteLine("Line1 are line2 are equal \n");
            }
            Console.ReadLine();
        }
    }
}
