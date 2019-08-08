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
          Shape a = new Square(4);
          Shape b = new Rectangle(3,4);
         // a.setEdges(10);
         // a.setEdges(100);
          Console.WriteLine(b.Preimeter());
        }
    }
}
