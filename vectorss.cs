using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Vectors
    { 
    
        public double Xcoordinate { get; set; }

        public double Ycoordinate { get; set; }

        public static Vectors operator + (Vectors vector1, Vectors vector2)
        {
            return new Vectors(vector1.Xcoordinate + vector2.Xcoordinate, vector1.Ycoordinate + vector2.Ycoordinate);
            
        }

        public static Vectors operator - (Vectors vector1, Vectors vector2)
        {
            return new Vectors(vector1.Xcoordinate - vector2.Xcoordinate, vector1.Ycoordinate - vector2.Ycoordinate);

        }

        public static bool operator == (Vectors vector1, Vectors vector2)
        {
            return vector1.Xcoordinate == vector2.Xcoordinate && vector1.Ycoordinate == vector2.Ycoordinate;

        }

        public static bool operator != (Vectors vector1, Vectors vector2)
        {
            return vector1.Xcoordinate != vector2.Xcoordinate | vector1.Ycoordinate != vector2.Ycoordinate;

        }

        public static Vectors operator -- (Vectors vector1)
        {
            vector1.Xcoordinate = -vector1.Xcoordinate;
            vector1.Ycoordinate = -vector1.Ycoordinate;
            return vector1;

        }

        public static Vectors operator ++ (Vectors vector1)
        {
            return vector1;

        }


        public Vectors(double x, double y)
        {
            Xcoordinate = x;
            Ycoordinate = y;
        }

        public double ShowCoordsx()
        {
            return Xcoordinate;
        }

        public double ShowCoordsy()
        {
            return Ycoordinate;
        }
    }
}
