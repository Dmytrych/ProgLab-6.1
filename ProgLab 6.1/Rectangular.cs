using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._1
{
    class Rectangle : Shape
    {
        public Rectangle(double edge1, double edge2)
        {
            edges = new double[2];
            edges[0] = edge1;
            edges[1] = edge2;
        }

        protected override double GetPerimeter()
        {
            return 2 * (edges[0] + edges[1]);
        }

        protected override double GetSurface()
        {
            return edges[0] * edges[1];
        }
    }
}
