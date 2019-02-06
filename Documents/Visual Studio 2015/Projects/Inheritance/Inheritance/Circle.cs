using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle : Shape
    {
        private int _radius;
        double pi = 3.14;
        public Circle(int _radius)
        {
            this._radius = _radius;
        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of Circle :" + pi * _radius * _radius);

        }
        public override void calculatePerimeter()
        {
            Console.WriteLine("Perimeter of Circle : " + 2 * pi * _radius);
        }
        public void ThisShape()
        {
            Console.WriteLine("This is Circle");
        }

    }
}


