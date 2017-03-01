using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Edge
    {
        public double len { get; set; }

        public Edge(Point p1, Point p2)
        {
            len = Math.Sqrt(Math.Pow((p1.getX() - p2.getX()), 2.0) + Math.Pow((p1.getY() - p2.getY()), 2.0));
        }
    }
}
