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
            ((IDrawable)myCircle).Draw();

            // Display information about the rectangle
            myRectangle.DisplayInfo();
            Console.WriteLine($"Area: {myRectangle.CalculateArea()}");
            ((IDrawable)myRectangle).Draw();
        }
    }
    
}
