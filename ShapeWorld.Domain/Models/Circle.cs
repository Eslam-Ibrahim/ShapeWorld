namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
        // Property
        public double r { get;}
        public override double Preimeter(){
            return 2* System.Math.PI * r;
        }
        // Controller
        public Circle(double r) : base(int.MaxValue){
            this.r = r;
        }
    }
}