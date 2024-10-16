public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    public int getTop(){
        return _top;
    }
    public void setTop(int set){
        _top = set;
    }
    public int getBottom(){
        return _bottom;
    }
    public void setBottom(int set){
        _bottom = set;
    }

    public string getFractionString(){
        return $"{_top}/{_bottom}";
    }
    public double getDecimalValue(){
        // double doubleTop = Convert.ToDouble(_top);
        // double doubleBottom = Convert.ToDouble(_bottom);
        return (double)_top/(double)_bottom;
    }
}