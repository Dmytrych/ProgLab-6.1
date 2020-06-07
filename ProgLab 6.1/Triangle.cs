using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgLab_6._1
{
    class Triangle : Shape
    {
        public Triangle(double edge1, double edge2, double edge3)
        {
            edges = new double[3];
            edges[0] = edge1;
            edges[1] = edge2;
            edges[2] = edge3;
        }

        protected override double GetPerimeter()
        {
            return edges[0] + edges[1] + edges[2];
        }

        protected override double GetSurface()
        {
            double perim = GetPerimeter();
            return Math.Sqrt(perim * (perim - edges[0]) * (perim - edges[1]) * (perim - edges[2]));
        }
    }
}
