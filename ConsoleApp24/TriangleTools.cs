// track

namespace ConsoleApp24
{
    internal class TriangleTools
    {

        public static double GetSquare (double a , double b , double c )
        {
            bool f = IsTryTriangle(a, b, c);
            if (f == false)
            {
                return 0;
            }
            double p = (a + b + c ) / 2.0;
            double s1 = p * (p-a ) *  (p-b) * (p-c); // нодо  взять  корень
            double sTriang = Math.Sqrt( s1 );
            return sTriang;
        }

        private static bool IsTryTriangle(double a, double b, double c)
        {
            return true;  // todo это не дописанно
        }
    }
}
