namespace ShapeWorld.Domain.Models
{
   public abstract class Shape
  {
    // Fileds
    // Properties
    public int NumberOfEdges{get;}
    // Methods
    public abstract double Preimeter();
    public double Volume(){
      return 0;
    }
    // Controllers
    public Shape(int edges){
      NumberOfEdges = edges;
    }
    
    public override string ToString(){
      return $"{this.GetType().Name} {NumberOfEdges} edges";
    }     
  }
  }
