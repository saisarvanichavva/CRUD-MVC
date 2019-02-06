using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Square squareobject = new Square(10);
                squareobject.calculateArea();
                squareobject.calculatePerimeter();
                squareobject.ThisShape();
                Circle circleObject = new Circle(10);
                circleObject.calculateArea();
                circleObject.calculatePerimeter();
                circleObject.ThisShape();
                Rectangle rectangleObject = new Rectangle(10, 20);
                rectangleObject.calculateArea();
                rectangleObject.calculatePerimeter();
                rectangleObject.thisShape();




            
        }
    }
}
