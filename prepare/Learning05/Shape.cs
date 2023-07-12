public class Shape
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Shape(string color) //Initializing color variable
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        // This method will be overridden by derived classes
        return 0;
    }
}
