using System.Text;

namespace Exercise1;

public class SpiralSnakeArray
{
    private int _sizeX;
    private int _sizeY;
    private int[,] _array;

    public int SizeX { get; }
    public int SizeY { get; }
    public int[,] Array { get; set; }

    public SpiralSnakeArray(int sizeY = 3, int sizeX = 4)
    {
        _sizeX = sizeX;
        _sizeY = sizeY;
        _array = new int[sizeY,sizeX];
        CreateSpiral();
    }
    public void CreateSpiral()
    {
        int value = 1;
        int counter = 0;
        int rowEnd = _sizeY - 1;
        int colEnd = _sizeX - 1;
        int col = 0;
        int row = 0;
        Directions verticalDirection = new Directions();
        Directions horizontalDirection = new Directions();
        verticalDirection.Next();
        
        while (counter < _sizeX * _sizeY)
        {
            _array[row, col] = value++;
            if((col == colEnd && row == 0) || (col == colEnd && row == rowEnd) || (row == rowEnd && col == 0) || (_array[row + verticalDirection.Current, col + horizontalDirection.Current] != 0))
            {
                verticalDirection.Next();
                horizontalDirection.Next();
            }
            row += verticalDirection.Current;
            col += horizontalDirection.Current;
            counter++;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < _sizeY; i++)
        {
            sb.Append("\n");
            for (int j = 0; j < _sizeX; j++)
            {
                sb.Append(_array[i,j] + "\t");
            }
        }
        return sb.ToString();
    }
}