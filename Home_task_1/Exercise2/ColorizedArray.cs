using System.Text;

namespace Exercise2;

public class ColorizedArray
{
    private int _sizeX;
    private int _sizeY;
    private Pixel[,] _array;
    
    public ColorizedArray(int sizeY = 5, int sizeX = 8)
    {
        _sizeX = sizeX;
        _sizeY = sizeY;
        _array = new Pixel[sizeY,sizeX];
        Colorize();
    }

    private void Colorize()
    {
        for (int i = 0; i < _sizeY; i++)
        {
            for (int j = 0; j < _sizeX; j++)
            {
                _array[i,j] = new Pixel(i, j);
            }
        }
    }
    public string LongestLineAnalysis()
    {
        StringBuilder sb = new StringBuilder();
        List<Pixel> longestLine = FindLongestLine();
        int lineLenght = longestLine.Count;
        Pixel firstLineElement = longestLine[0];
        int lineColor = firstLineElement.Color;
        sb.Append("Line color: " + lineColor + "\n");
        sb.Append("First element indexes: " + firstLineElement.Y + ", " + firstLineElement.X + '\n');
        Pixel lastLineElement = longestLine[lineLenght - 1];
        sb.Append("Last element indexes: " + lastLineElement.Y + ", " + lastLineElement.X + '\n');
        sb.Append("Lenght: " + lineLenght);
        return sb.ToString();
    }
    private List<Pixel> FindLongestLine()
    {
        List<Pixel> longestLine = new List<Pixel>();
        List<Pixel> tempLine = new List<Pixel>();
        for (int row = 0; row < _sizeY; row++)
        {
            tempLine.Add(_array[row, 0]);

            for (int col = 1; col < _sizeX; col++)
            {
                Pixel currentPixel = _array[row, col];

                if (currentPixel.Color == tempLine[0].Color)
                {
                    tempLine.Add(currentPixel);
                    continue;
                }
                if (tempLine.Count > longestLine.Count)
                { 
                    longestLine = new List<Pixel>(tempLine);
                }
                tempLine.Clear(); 
                tempLine.Add(currentPixel);
            }
            tempLine.Clear();
        }

        if (tempLine.Count > longestLine.Count)
        {
            longestLine = new List<Pixel>(tempLine);
        }

        return longestLine;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < _sizeY; i++)
        {
            sb.Append("\n");
            for (int j = 0; j < _sizeX; j++)
            {
                sb.Append(_array[i,j].Color + "\t");
            }
        }
        return sb.ToString();
    }
}