using System;

namespace FacadePattern_DP_T04
{
    class FacadePatternDemo
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
            Console.ReadLine();
        }
    }
}
