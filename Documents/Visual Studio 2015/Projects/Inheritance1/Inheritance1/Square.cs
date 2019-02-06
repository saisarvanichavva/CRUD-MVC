using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Square : Shape
    {
        private int _side;
        public Square(int _side)
        {
            this._side = _side;
        }
        public override void calculateArea()
        {
            Console.WriteLine("Area of square : " + _side * _side);
        }
        public override void calculatePerimeter()
        {
            Console.WriteLine("Perimeter of square : " + 4 * _side);
        }
        public void ThisShape()
        {
            Console.WriteLine("This is square");
        }
    }
}
