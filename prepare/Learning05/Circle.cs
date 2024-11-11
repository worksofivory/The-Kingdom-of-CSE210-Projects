public class Circle:Shape{
    double _radius;

    public Circle(double radius, string color): base(color){
        _radius = radius;
    }
    public override double getArea()
    {
        double pi = Math.PI;
        return pi*(_radius*_radius);
    }
}