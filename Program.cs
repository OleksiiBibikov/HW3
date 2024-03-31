namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber<int> complexNumber = new ComplexNumber<int>(6, 7);
            complexNumber.Print();

            Point point = new Point(1, 2);
            point.PrintPoint();
        }
    }
}
