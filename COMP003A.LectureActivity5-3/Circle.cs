using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity5_3
{
    class Circle : Shape
    {
        // Auto-implemented property
        public double Radius { get; set; }

        /// <summary>
        /// Constructor for Circle
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle
        /// </summary>
        public override double CalculateArea()
        {
            // returns the area of the circle
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Implements Draw() method for a circle
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
}
