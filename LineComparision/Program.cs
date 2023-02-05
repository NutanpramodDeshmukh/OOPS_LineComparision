using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public static void Length()
            {
                Console.Write("Enter Lengths");

                Console.Write(" X1 = ");
                double x1 = double.Parse((Console.ReadLine()));
                Console.Write(" Y1 = ");
                double y1 = double.Parse((Console.ReadLine()));
               
                Console.Write("X2 = ");
                double x2 = double.Parse((Console.ReadLine()));
                Console.Write(" Y2 = ");
                double y2 = double.Parse((Console.ReadLine()));

                Console.WriteLine("Length of a Line is" +Length);
                double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));



            }


            public static void Main()
            {

                Length();
            }
        }
    }
}
