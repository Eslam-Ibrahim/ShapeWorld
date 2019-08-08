namespace ShapeWorld.Domain.Models{

public class Rectangle : Shape {

    // Properties
    public virtual int Len { get; set; }
    public virtual int Width { get; set; }

    // Controllers
    public Rectangle(int len, int width) : base(4){
      Len = len;
      Width = width;
    }
    // Methods
    public override double Preimeter(){
      return (Len + Width) * 2;
    } 
 }

}