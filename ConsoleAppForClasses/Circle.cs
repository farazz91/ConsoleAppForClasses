using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClasses
{
    class Circle
    {
        static float pi;
        float radius;

        public Circle(int radius)
        {
            pi = 3.142F;
            this.radius = radius;
        }

        public float calculateRadius()
        {
            return (pi * radius * radius);
        }
    }
}
