using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayWithShape();
        }

        static void PlayWithShape(){
            Shape a = new Cube(12,10);
            Console.WriteLine(a.Volume());
            Cube b = new Cube (12,6);
            Console.WriteLine(b.Volume());
            Square c = new Cube (12,5);
            Console.WriteLine(c.Volume());
        }
    }
}
