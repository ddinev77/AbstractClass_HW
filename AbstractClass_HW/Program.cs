namespace AbstractClass_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            char symbol = char.Parse(Console.ReadLine());

            while (symbol == 'c' || symbol == 'q' || symbol == 's') 
            {
                if (symbol == 'c')
                {
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape circle = new Circle(radius);
                    shapes.Add(circle);
                }
                else if (symbol == 'q')
                {
                    Console.Write("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    Shape square = new Square(side);
                    shapes.Add(square);
                }
                else if (symbol == 's')
                {
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape sphere = new Sphere(radius);
                    shapes.Add(sphere);
                }
                symbol = char.Parse(Console.ReadLine());
            }
            
            foreach (Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}