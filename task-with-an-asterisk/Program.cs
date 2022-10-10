/* 
Задача *. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
*/

Console.Clear();
Console.Write("Введите число для подсчета фибоначчи: ");
int number = int.Parse(Console.ReadLine()!);

double[] array = new double[number]; 
double[] fib = Fibonacci(number, array);
PrintArray(fib);

double[] Fibonacci(int number, double[] array)
{
    for (int i = 0; i < number; i++) 
    {
        if (i == 0) array[0] = 0;
        else if (i == 1) array[1] = 1;
        else {
            array[i] = array[i-1] + array[i-2];
        }
    }  
    return array;
}

void PrintArray(double[] array) {
    for (int i = 0; i < array.Length; i++)
    {   
        if (i == array.Length - 1) {
            Console.Write($"{array[i]}"); 
        }
        else {
            Console.Write($"{array[i]}, "); 
        }
    }
}

