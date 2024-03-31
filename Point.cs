using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Point
    {
        public int x;
        public int y;

        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"X = {X}; Y = {Y}");
        }
    }
}
