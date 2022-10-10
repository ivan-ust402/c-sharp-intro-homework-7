/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] averageArray = new double[n];


FindAverageOfMatrixColumnElements(array, averageArray);
PrintOneDimentialArray(averageArray);

void PrintOneDimentialArray(double [] array) {
    Console.WriteLine("");
    for (int i = 0; i < array.Length; i++)
    {   
        if (i < array.Length - 1) {
            Console.Write($"{array[i]}, ");
        }
        else {
            Console.Write($"{array[i]}");
        }
    }
}

void FindAverageOfMatrixColumnElements(int[,] array, double[] averageArray){
    for (int i = 0; i < averageArray.Length; i++)
    {   double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if(i == k) {
                    sum = sum + array[j, k];
                }
            }
        }
        int round = (int)Math.Round(sum / array.GetLength(0) * 10, 5);
        double result = Convert.ToDouble(round) / 10;
        averageArray[i] = result;
    }
}

void FillArray(int[,] array)
{
    Random randomGen = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomGen.Next(-10, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}
