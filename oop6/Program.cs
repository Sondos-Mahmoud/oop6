namespace oop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3D point
            _3D_Point P1 = _3D_Point.ReadPoint();
            _3D_Point P2 = _3D_Point.ReadPoint();
            Console.WriteLine($"P1: {P1}");
            Console.WriteLine($"P2: {P2}");
            Console.WriteLine($"P1 == P2: {P1 == P2}");
            _3D_Point P1Clone = (_3D_Point)P1.Clone();
            Console.WriteLine($"Cloned P1: {P1Clone}");

            // Sorting an array of points
            _3D_Point[] points = { new _3D_Point(3, 2, 1), new _3D_Point(1, 5, 2), new _3D_Point(2, 3, 4), new _3D_Point(1, 2, 3) };
            Array.Sort(points);

            Console.WriteLine("\nSorted Points:");
            foreach (var point in points) Console.WriteLine(point);

            #endregion
            #region Calling Math Functions

            int num1 = 10, num2 = 5;

            Console.WriteLine($"Add: {Math.Add(num1, num2)}");
            Console.WriteLine($"Subtract: {Math.Subtract(num1, num2)}");
            Console.WriteLine($"Multiply: {Math.Multiply(num1, num2)}");
            Console.WriteLine($"Divide: {Math.Divide(num1, num2)}");
            
            #endregion

        }
    }
}