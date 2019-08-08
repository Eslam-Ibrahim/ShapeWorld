using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq;
using System;
namespace ShapeWorld.Domain.Collections
{
    public class ShapeArray{

      public void DimensionalArray(){
        // 1-D
        Shape [] shaped = new Shape [3];
        Shape [] shaped2 = new Shape [] {new Square(4), new Rectangle(3,2)};
        System.Console.WriteLine(shaped2[0].Preimeter());
        System.Console.WriteLine(shaped2[0].Volume());
        // 2-D
        Shape [,] shaped3 = new Shape[2,2];
        Shape [,] shaped4 = new Shape [,] {{new Square(3), new Circle(1.5)} , {new Square(6), new Circle(2.5)}};
        // 3-D
        Shape [,,] shaped5 = new Shape [2,2,2];
        // Jagged Array
        Shape [][] shaped7 = new Shape[3][];
        Shape [][] shaped8 = new Shape [][]{
          new Rectangle[4],
          new Circle[]{new Circle(1.4), new Circle(2.1)}
        };
      }

      public void MyList(){
        List <Shape> shaped = new List<Shape>();
        System.Console.WriteLine(shaped.Find(e=>e.NumberOfEdges == 4)); // predicate function
        System.Console.WriteLine(shaped.FirstOrDefault(e=>e.NumberOfEdges == 4)); // predicate function
        // Find vs FirstOrDefault ??!
      }

      public void MyDictionary(){
        Dictionary<Guid,Shape> shaped = new Dictionary <Guid,Shape>();
        Guid guid = Guid.NewGuid();
        shaped.Add(guid, new Square(4));
        Console.WriteLine(guid);
        Console.WriteLine(shaped[guid].Preimeter());
      }
    }
}