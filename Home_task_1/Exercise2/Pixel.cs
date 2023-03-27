namespace Exercise2;

public class Pixel
{
    private int _x;
    public int X
    {
        get { return _x; }
    }
    private int _y;

    public int Y
    {
        get
        {
            return _y;
        }
    }

    private int _color;
    private const int MAX_COLOR = 16;
    public int Color
    {
        get { return _color; }
    }

    public Pixel(int y, int x)
    {
        Random rand = new Random();
        _x = x;
        _y = y;
        _color = rand.Next(MAX_COLOR + 1);
    }
}