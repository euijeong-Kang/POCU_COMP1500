using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{

    public static class Canvas
    {
        public enum EShape
        {
            Rectangle,
            IsoscelesRightTriangle,
            IsoscelesTriangle,
            Circle
        }
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            if (width == 0 || height == 0)
            {
                width = 0;
                height = 0;
            }

            char[,] result = new char[width, height];

            

            return result;
        }
    }
}
