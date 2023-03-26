using System.Text;
using Exercise1;
using Microsoft.VisualBasic;

SpiralSnakeArray snakeArray = new SpiralSnakeArray(3, 4);
snakeArray.CreateSnake();
Console.WriteLine(snakeArray.ToString());
SpiralSnakeArray secondVariatArray = new SpiralSnakeArray();
secondVariatArray.SecondVariantCreateSnake();
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine(secondVariatArray.ToString());