namespace Exercise1;

public class Directions
{
    private int[] _directionsArray;
    public int[] Array { get; }

    private int _index;
    public int Current { get { return _directionsArray[_index]; } }
    public Directions()
    {
        _directionsArray = new int[4]{0, 1, 0, -1};
    }
    public void Next()
    {
        if (_index + 1 == _directionsArray.GetLength(0))
        {
            _index = 0;
            return ;
        }
        _index++;
    }
}