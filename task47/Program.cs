/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Clear();
Console.WriteLine("Введите размерность массива");
Console.WriteLine("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("n = ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m, n];
FillArray(array);

void FillArray(double[,] array) {
    Random randomGen = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomGen.Next(0, 10) + randomGen.NextDouble();
        }
    }
}
