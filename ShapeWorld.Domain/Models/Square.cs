namespace ShapeWorld.Domain.Models{

public class Square : Rectangle {


    // Backing Filed
    private int _edgeLenght;
    // Properties
    public override int Len{
      get{
        return _edgeLenght;
      }
      set{
        _edgeLenght = value;
      }
    }
      public override int Width{
      get{
        return _edgeLenght;
      }
      set{
        _edgeLenght = value;
      }
    }

    // Controllers
    public Square(int edgeLength) : base(edgeLength,edgeLength){
      _edgeLenght = edgeLength;
    }

    // Methods
    public override double Preimeter(){
      return _edgeLenght*4;
    }
  
 }

}