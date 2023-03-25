﻿using System.Text;

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
        CreateSnake();
    }

    public void CreateSnake()
    {
        int value = 1;
        int rowStart = 0;
        int colStart = 0;
        int rowEnd = _sizeY - 1;
        int colEnd = _sizeX - 1;
        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (int row = rowStart; row <= rowEnd; row++)
            {
                _array[row, colStart] = value++;
            }

            for (int col = colStart + 1; col <= colEnd; col++)
            {
                _array[rowEnd, col] = value++;
            }
            if (colStart < colEnd && rowStart < rowEnd)
            {
                for (int row = rowEnd - 1; row > colStart; row--)
                {
                    _array[row, colEnd] = value++;
                }
            
                for (int col = colEnd; col > rowStart; col--)
                {
                    _array[rowStart, col] = value++;
                }
            }
            rowStart++;
            rowEnd--;
            colStart++;
            colEnd--;
        }
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
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