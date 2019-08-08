using ShapeWorld.Domain.Interfaces;
namespace ShapeWorld.Domain.Models
{
  public class Cube : Square, IThreeD
  {
   

    public override int Len { get => base.Len; set => base.Len = value; }
    public override int Width { get => base.Width; set => base.Width = value; }
    public double Height {get;}

    public new double Volume (){
     return Height * Height * Height;
    }
    public Cube(int edgeLength , int Height) : base(edgeLength){
        this.Height = Height;
    }
    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override double Preimeter()
    {
      return base.Preimeter();
    }

    public override string ToString()
    {
      return base.ToString();
    }
  }
}