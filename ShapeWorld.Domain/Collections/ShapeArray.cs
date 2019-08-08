using ShapeWorld.Domain.Models;
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
      }
    }
}