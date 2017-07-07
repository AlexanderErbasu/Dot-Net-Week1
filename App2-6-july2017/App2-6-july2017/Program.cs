using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2_6_july2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareDecorator = new ShapeDecorator<Square>();
            var rectangleDecorator = new ShapeDecorator<Rectangle>();

            //squareDecorator.Shape.
            //rectangleDecorator.Shape.

            List<ShapeDecorator<Square>> list = new List<ShapeDecorator<Square>>();
            list.Add(new ShapeDecorator<Square>());
            foreach(var decorator in list)
            {
                //decorator.Shape.Area;
            }
        }
    }
}
