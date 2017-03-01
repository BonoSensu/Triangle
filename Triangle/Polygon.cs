using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Polygon
    {

        public double PolArea { get; set; }
        public double PolPerimeter { get; set; }
        
        public Polygon(Point[] num)
        {
            PolArea = 0;
            for (int i = 1; i < num.Length - 1; i++)
            {
                Triangle KMN = new Triangle(num[0], num[i], num[i + 1]);
                PolArea += KMN.area;
                //Console.WriteLine("Current Area: " + Math.Round(KMN.area));
                
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (i<num.Length-1)
                {
                    PolPerimeter += Math.Sqrt(Math.Pow((num[i].getX() - num[i+1].getX()), 2.0) + Math.Pow((num[i].getY() - num[i+1].getY()), 2.0));
                    //Console.WriteLine("Current Perimeter: " + Math.Round(PolSumPerimeter));
                }
                else
                {
                    PolPerimeter += Math.Sqrt(Math.Pow((num[i].getX() - num[0].getX()), 2.0) + Math.Pow((num[i].getY() - num[0].getY()), 2.0));
                    //Console.WriteLine("Current Perimeter: " + Math.Round(PolSumPerimeter));
                }
            }
        }
    }
}
