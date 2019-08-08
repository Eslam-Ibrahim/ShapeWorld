namespace ShapeWorld.Domain.Models
{
   public abstract class Shape
  {
    // Fileds
    // Properties
    public int NumberOfEdges{get;}
    // Methods
    public abstract double Preimeter();
    // Controllers
    public Shape(int edges){
      NumberOfEdges = edges;
    }
     
    }
  }
