﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern_DP_T04
{
    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;
        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }
        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        } 

    }
}
