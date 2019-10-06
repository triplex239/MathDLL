using System.Runtime.InteropServices;

namespace MathDLL
{
    public class MyMath
    {
        public double Square(double x, double y, double z)
        {
            return Math.Sqrt(Perimeter(x, y, z) * (Perimeter(x, y, z) - x) * (Perimeter(x, y, z) - y) * (Perimeter(x, y, z) - z));
        }
        public double Square(double b)
        {
            return b * b * Math.PI;
        }
        public double Perimeter(double x, double y, double z)
        {
            return (x + y + z) / 2;
        }
        public double Perimeter(double r)
        {
            return r * Math.PI;
        }
        public bool Rectangular(double x, double y, double z)
        {

            return ((x * x == y * y + z * z) || (z * z == x * x + y * y) || (y * y == z * z + x * x));
        }
        public double ArrayCoordinates(double[] arrayX, double[] arrayY)
        {
            double RS;
            double S = 0;
            int n;
            n = arrayX.Length;
            for (int k = 0; k < n - 1; k++)
            {
                S += arrayX[k] * arrayY[k + 1] - arrayX[k + 1] * arrayY[k];
            }
            RS = (S + arrayX[n - 1] * arrayY[0] - arrayX[0] * arrayY[n - 1]) / 2;
            return Math.Abs(RS);
        }
    }
}

/* question 9
select prod.product, cat.category 
from prod left join cat 
on prod.cat_id = cat.id
*/
