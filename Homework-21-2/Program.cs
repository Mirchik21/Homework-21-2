namespace Homework_21_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(10);
            Square square2 = new Square(12);
            DoubleSquare doubleSquare = new DoubleSquare();
            doubleSquare.BuildDoubleSquare(square1, square2);
            Console.WriteLine("Ploshad doubleSquare = {0}", doubleSquare.GetArea());

        }
    }

    class Square : ISquare
    {
        double _sidesLength;

        public Square(double sidesLength)
        {
            _sidesLength = sidesLength;
        }
        public double GetSide()
        {
            return _sidesLength;
        }
    }

    class DoubleSquare : AbstractDoubleSquare
    {
        double _sidesLength;
        protected double area;
        

        public DoubleSquare()
        {
            
        }

        public override void BuildDoubleSquare(ISquare square1, ISquare square2)
        {
            _sidesLength = square1.GetSide();
            area = square2.GetSide();

        }


        protected override double CalculateArea()
        {
            return _sidesLength + area;
        }
        

        public double GetArea()
        {
            return Math.Pow(_sidesLength, 2) + Math.Pow(area, 2);
        }

    }

    


}