using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public abstract class Shape
    {
        protected int _area;
        protected String _color;
        protected int _perimeter;
        public Shape() { }
        public Shape(int _area, String _color, int _perimeter)
        {
            this._area = _area;
            this._color = _color;
            this._perimeter = _perimeter;
        }
        public abstract void calculateArea();
        public abstract void calculatePerimeter();

    }
}
