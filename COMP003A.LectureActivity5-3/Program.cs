namespace COMP003A.LectureActivity5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a circle
            Shape myCircle = new Circle(5);
            // Create a rectangle
            Shape myRectangle = new Rectangle(4, 6);

            // Display information about the circle
            myCircle.DisplayInfo();
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            ((Idrawable)myCircle).Draw();

            // Display information about the rectangle
            myRectangle.DisplayInfo();
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            ((Idrawable)myCircle).Draw();
        }
    }
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
    class Circle : Shape
    {
        // Auto-implemented property
        public double Radius { get; set;}

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
    interface Idrawable
    {
        /// <summary>
        /// Draws the object
        /// </summary>
        void Draw();
    }
}
