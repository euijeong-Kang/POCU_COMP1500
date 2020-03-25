using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Rectangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }
        
        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            double perimeter = (Width + Height) * 2;
            return perimeter;
        }
        public double GetArea()
        {
            double area = Width * Height;
            return area;
        }
    }
    class RightTriangle
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }

        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            double thirdSide = Math.Sqrt(Width * Width + Height * Height);
            double perimeter = (int)((Width + Height + thirdSide) * 1000 + 0.5) / 1000.0;
            return perimeter;
        }
        public double GetArea()
        {
            double area = Width * Height / 2;
            return area;
        }
    }
    class Circle
    {
        public uint Radius { get; private set; }
        public uint Diameter { get; private set; }
        public Circle(uint radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }

        public double GetCircumference()
        {
            double circumference = Diameter * Math.PI;
            return (int)(circumference * 1000 + 0.5) / 1000.0;
        }
        public double GetArea()
        {
            double area = Radius * Radius * Math.PI;
            return (int)(area * 1000 + 0.5) / 1000.0;
        }
    }

    

}

