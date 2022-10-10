/* 
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1
7 -> такого числа в массиве нет
*/

Console.Clear();
Console.WriteLine("Введите желаемую размерность массива.");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

Console.WriteLine("Введите позицию искомого элемента.");
Console.Write("i = ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("j = ");
int j = int.Parse(Console.ReadLine()!);



void FillArray(int[,] array) {
    Random randomGen = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomGen.Next(-10, 10);
        }
    }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

