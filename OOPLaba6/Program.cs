using System;
using System.Text;

namespace OOPLaba6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var romb1 = new Romb();
            var romb2 = new Romb(4, 9);
            var romb3 = new Romb(6, 3);
            var romb4 = new Romb(4, 7);

            Romb[] romb = { romb1, romb2, romb3, romb4 };

            Array.ForEach(romb, Console.WriteLine);

            Console.WriteLine();

            Array.Sort(romb, (x, y) => x.GetArea().CompareTo(y.GetArea()));

            Array.ForEach(romb, Console.WriteLine);

            Console.ReadLine();
        }

        public interface IRomb
        {
            double GetArea();
            void print_sqrt();
        }
        
        class Romb : IRomb
        {
            private double _a;
            private double _diagonalA;
            private double _diagonalB;
            private double _area;

            public Romb()
            {
                _a = _diagonalA = _diagonalB = 0.0;
            }

            public Romb(double x, double y)
            {
                _a = x;
                _diagonalB = y;
                _diagonalA = Math.Sqrt(4 * Math.Pow(_a, 2) - _diagonalB);
            }

            public double GetArea()
            {
                _area = 1.0 / 2.0 * _diagonalA * _diagonalB;
                return _area;
            }
            public void print_sqrt()
            {
                Console.WriteLine($"Площа - {GetArea()}");
            }

            public override string ToString()
            {
                return "A = " + _a + ", diagonalA = " + _diagonalA + ", diagonalB = " + _diagonalB + ", area = " + GetArea();
            }
        }
    }
}
