using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity5_3
{
    class Rectangle : Shape
    {
        // Auto-implemented properties
        public double Width { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// Constructor for rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>

        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        public override double CalculateArea()
        {
            // returns the area of the rectangle
            return Width * Height;
        }

        /// <summary>
        /// Implements Draw() method for a rectangle
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
