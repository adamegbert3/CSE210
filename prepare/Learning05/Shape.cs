abstract class Shape
{
    public Shape(string color)
    {
        _color = color;
    }
    
    private string _color;


    public string GetColor()
        {
            return _color;
        }

    public void SetColor(string newColor)
    {
        _color = newColor;
    }

    public abstract double GetArea();
    // {
    //     return 0;
    // }

}