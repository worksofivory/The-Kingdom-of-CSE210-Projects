public class Rectangle:Shape{
    double _length;
    double _width;

    public Rectangle(double length, double width, string color): base(color){
        _length = length;
        _width = width;
    }
    public override double getArea()
    {
        return _length*_width;
    }
}