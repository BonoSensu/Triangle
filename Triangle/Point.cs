using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Point
    {
        private double[] coord;

        public Point(double X, double Y)
        {
            coord = new double[2];
            coord[0] = X;
            coord[1] = Y;
        }

        public void setX(double val)
        {
            coord[0] = val;
        }

        public void setY(double val)
        {
            coord[1] = val;
        }

        public double getX()
        {
            return coord[0];
        }

        public double getY()
        {
            return coord[1];
        }
    }
}
