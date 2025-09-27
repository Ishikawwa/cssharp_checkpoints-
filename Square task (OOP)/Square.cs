using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_task__OOP_
{
    internal class Square
    {
        public double Width;
        public double Height;


        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CountingArea()
        {
            return Width * Height;
        }

        public void WidthScaling()
        {
            Width = Width * 0.5;
        }
        public void HeightScaling()
        {
            Height = Height * 2.5;
        }
    }
}