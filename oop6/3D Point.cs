using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class _3D_Point: ICloneable, IComparable<_3D_Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public _3D_Point()  
        {
            X = 0;
            Y = 0;  
            Z = 0;
        }


        public _3D_Point(int x)
        {
        X=x; Y = 0;Z = 0;
        }

        public _3D_Point(int x, int y) 
        {
            X = x;
            Y=y;
            Z = 0;
        }
        public _3D_Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $" “Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object obj)
        {
            if (obj is _3D_Point other)
                return X == other.X && Y == other.Y && Z == other.Z;
            return false;
        }
        public static bool operator ==(_3D_Point p1, _3D_Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(_3D_Point p1, _3D_Point p2)
        {
            return !p1.Equals(p2);
        }
        public object Clone()
        {
            return new _3D_Point(X,Y,Z); 

        }

        public int CompareTo(_3D_Point? other)
        {
            if (X != other.X)
                return X.CompareTo(other.X);
            return Y.CompareTo(other.Y); 
        }
        public static _3D_Point ReadPoint()
        {
            int x = ReadInt("Enter X: ");
            int y = ReadInt("Enter Y: ");
            int z = ReadInt("Enter Z: ");
            return new _3D_Point(x, y, z);
        }
        private static int ReadInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out value)) return value;

               
            }
        }
    }


}
