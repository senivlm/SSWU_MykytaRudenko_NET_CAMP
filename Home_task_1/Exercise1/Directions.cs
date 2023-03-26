namespace Exercise1;

public class Directions
{
    private int[] _array = new int[4]{0, 1, 0, -1};
    public int[] Array { get; }

    private int _index;
    public int Current { get { return _array[_index]; } }
    // TODO: create ctor for array initialization 
    // public Directions(int[] directionVariables)
    // {
    //     _array = directionVariables;
    // }
    public void Next()
    {
        if (_index + 1 == _array.GetLength(0))
        {
            _index = 0;
            return ;
        }
        _index++;
    }
}