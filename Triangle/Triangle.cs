using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        private Point Point1, Point2, Point3;
        private Edge E12, E23, E31;
        public double HalfPer;
        public double area { get; set; }
        public double perimeter { get; set; }
        public bool orthogonal { get; set; }
        public bool isosceles { get; set; }
        
        public Triangle(Point p1, Point p2, Point p3)
        {
            double HalfPer;

            Point1 = p1;
            Point2 = p2;
            Point3 = p3;

            if (Point1 != Point2 && Point2 != Point3 && Point1 != Point3)
            {
                
                E12 = new Edge(Point1, Point2);
                E23 = new Edge(Point2, Point3);
                E31 = new Edge(Point3, Point1);

                perimeter = Math.Round(E12.len + E23.len + E31.len);
                HalfPer = perimeter / 2;
                area = Math.Round(Math.Sqrt(HalfPer * (HalfPer - E12.len) * (HalfPer - E23.len) * (HalfPer - E31.len)));

                if (area == 0)
                {
                    Console.WriteLine("It\'s not a triangle!");
                }
                else
                {
                    //Console.WriteLine("Current Area: " + area);
                    //Console.WriteLine("Current Perimetr: " + perimeter);

                    if ((E12.len == E23.len) || (E12.len == E31.len) || (E31.len == E23.len))
                    {
                        isosceles = true;
                    }
                    else isosceles = false;

                    if (((0.5 * E12.len * E23.len) == area) || ((0.5 * E12.len * E31.len) == area) || ((0.5 * E31.len * E23.len) == area))
                    {
                        orthogonal = true;
                    }
                    else orthogonal = false;

                }
            }
            else
            {
                Console.WriteLine("It\'s not a triangle!");
                
            }
        }
    }
}
