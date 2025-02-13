using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity5_3
{
    abstract class Shape
    {
        // Auto-implemented property
        public string Name { get; set; }

        /// <summary>
        /// Abstract method to calculate area.
        /// </summary>
        public abstract double CalculateArea();

        /// <summary>
        /// Displays the shape's name
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
      
    }
}
