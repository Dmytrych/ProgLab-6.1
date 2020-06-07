using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._1
{
    abstract class Shape
    {
        public double[] edges { get; protected set; }
        protected virtual double GetPerimeter()
        {
            throw new NotImplementedException();
        }
        protected virtual double GetSurface()
        {
            throw new NotImplementedException();
        }
    }
}
