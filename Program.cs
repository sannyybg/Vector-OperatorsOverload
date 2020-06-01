using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vectors(4, 6);
            var vector2 = new Vectors(-1, 3);

            var vector3 = vector1 + vector2;
            var vector4 = vector1 - vector2;

            Console.WriteLine("vectorebi tolia Tu ara : " + (vector1 == vector3));


            // მიმართულების შეცვლა

            var vector5 = --vector1;




            // გასატესტად 
            Console.WriteLine("X coord: " + vector5.ShowCoordsx() + " Y coord: " + vector5.ShowCoordsy());
            
            Console.ReadKey();


        }
    }
}
