namespace Exercise2;

public class Pixel
{
    private int _x;
    public int X { get { return _x; } }
    
    private int _y;
    public int Y { get { return _y; } }
    
    private int _color;
    public int Color { get { return _color; } }
    
    private const int MAX_COLOR = 16;

    public Pixel(int y, int x)
    {
        _x = x;
        _y = y;
        _color = RandomColor();
    }

    private int RandomColor()
    {
        Random rand = new Random();
        return rand.Next(MAX_COLOR + 1);
    }
}