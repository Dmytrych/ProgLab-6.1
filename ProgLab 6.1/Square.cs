using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._1
{
    class Square : Shape
    {
        public Square(double edge)
        {
            edges = new double[1];
            edges[0] = edge;
        }

        protected override double GetPerimeter()
        {
            return edges[0] * 4;
        }

        protected override double GetSurface()
        {
            return edges[0] * edges[0];
        }
    }
}
