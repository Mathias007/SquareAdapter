using System;

namespace SquareAdapter
{
    public interface ITarget
    {
        string GetRequest();
    }

    public class Square
    {
        private double side;

        public Square(double sideLength)
        {
            side = sideLength;
        }

        public double GetArea()
        {
            return side * side;
        }
    }

    public class SquareAdapter : ITarget
    {
        private readonly Square _square;

        public SquareAdapter(Square square)
        {
            _square = square;
        }

        public string GetRequest()
        {
            double area = _square.GetArea();
            return $"Area of the square is {area}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);

            ITarget target = new SquareAdapter(square);

            Console.WriteLine("Adapting Square class to ITarget interface:");
            Console.WriteLine(target.GetRequest());
        }
    }
}
