using System.Text;
using Exercise1;

SpiralSnakeArray snakeArray = new SpiralSnakeArray(3, 4);
Console.WriteLine(snakeArray.ToString());

// the second variant of SpiralSnakeArray initialization
int[,] matrix = new int[3, 4];
int value = 1;
int direction = 1;

for (int i = 0, j = 0, k = 0; k < matrix.GetLength(0) * matrix.GetLength(1); i += direction, j += 1 - direction)
{
    matrix[i, j] = value++;
    if (i + direction == matrix.GetLength(0) || i - direction == -1 || j + 1 - direction == matrix.GetLength(1) || matrix[i + direction, j + 1 - direction] != 0)
    {
        direction = -direction;
    }
}

StringBuilder sb = new StringBuilder();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sb.Append("\n");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sb.Append(matrix[i,j] + "\t");
    }
}
Console.WriteLine(sb.ToString());