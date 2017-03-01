using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Triangle
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Point A = new Point(2, 0);
            Point B = new Point(0, 2);
            Point C = new Point(-1, 0);

            Triangle ABC = new Triangle(A, B, C);

            Console.WriteLine("---FOR ONE TRIANGLE---");
            Console.WriteLine("Perimetr of triangle = " + ABC.perimeter);
            Console.WriteLine("Area of triangle = " + ABC.area);
            Console.WriteLine("This triangle is isosceles? " + ABC.isosceles);
            Console.WriteLine("This triangle is orthogonal? " + ABC.orthogonal);

            Console.WriteLine("---FOR ARRAY TRIANGLES---");
            Console.Write("Enter the number of triangles: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Triangle[] arr = new Triangle[num];
            Random Gen = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Point X = new Point(Gen.Next(20) - 10, Gen.Next(20) - 10);
                Point Y = new Point(Gen.Next(20) - 10, Gen.Next(20) - 10);
                Point Z = new Point(Gen.Next(20) - 10, Gen.Next(20) - 10);

                arr[i] = new Triangle(X, Y, Z);

            }
            double SumPerimetr = 0, SumArea = 0;
            int temp = 0, atemp = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j].orthogonal)
                {
                    SumPerimetr += arr[j].perimeter;
                    temp++;
                }
                if (arr[j].isosceles)
                {
                    SumArea += arr[j].area;
                    atemp++;
                }
            }
            double AveragePerimetr = SumPerimetr / temp;
            double AverageArea = SumArea / atemp;
            Console.WriteLine("Average Perimetr: " + AveragePerimetr + "\nAverage Area: " + AverageArea);
            
            Console.WriteLine("---POLYGON---");
            Console.Write("Enter the number of vertices: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            Point[] arpoint = new Point[Num];
            for (int i = 0; i < arpoint.Length; i++)
            {
                arpoint[i] = new Point(Gen.Next(), Gen.Next());
            }

            Polygon Pol = new Polygon(arpoint);

            Console.WriteLine("Area Polygon: " + Math.Round(Pol.PolArea));
            Console.WriteLine("Perimeter Polygon: " + Math.Round(Pol.PolPerimeter));
            Console.ReadKey();
        }
    }
}
