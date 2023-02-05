using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison2
{
    internal class Program
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

                Console.Write(" X3 = ");
                double x3 = double.Parse((Console.ReadLine()));
                Console.Write(" Y3 = ");
                double y3 = double.Parse((Console.ReadLine()));

                Console.Write(" X4 = ");
                double x4 = double.Parse((Console.ReadLine()));
                Console.Write(" Y4 = ");
                double y4 = double.Parse((Console.ReadLine()));

                
                double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                Console.WriteLine("Length of a Line is", Length);

            double LengthTwo = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
                Console.WriteLine("Lenght" + LengthTwo);

                if (Length == (LengthTwo))
                {
                    Console.WriteLine("First and Second Lines are Equal");
                }
                else
                {
                    Console.WriteLine("First and Second Lines are not Equal");
                }

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Line Comparison");
                Length();
            }
        }
    }

