using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    class circle
    {
        double radius;
        //const double PI = 3.143;
        public void setRadius(double radius)
        {
            this.radius = radius;

        }
        public double GetRadius()
        {
            return radius;

        }
        public double CalcDiameter()
        {
            return 2 * radius;

        }
        public double Calcarea()
        {
            return Math.PI * radius * radius;

        }

        class circletest
        {
            public static void Main()
            {
                circle c1 = new circle();
                c1.setRadius(2);
                Console.WriteLine(c1.GetRadius());
                Console.WriteLine(c1.CalcDiameter());
                Console.WriteLine(c1.Calcarea());

                c1.setRadius(4);
                Console.WriteLine(c1.GetRadius());
                Console.WriteLine(c1.CalcDiameter());
                Console.WriteLine(c1.Calcarea());
            }
        }


    }
}

