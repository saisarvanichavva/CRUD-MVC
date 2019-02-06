using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectangle : Shape
    {
        private int _height;
        private int _width;
        public Rectangle(int _height, int _width)
        {
            this._height = _height;
            this._width = _width;
        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of Rectangle :" + _height * _width);

        }
        public override void calculatePerimeter()
        {
            Console.WriteLine("Perimeter of Rectangle : " + 2 * (_height + _width));
        }
        public void thisShape()
        {
            Console.WriteLine("This is Rectangle");
        }
    }
}
