//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
using System.Collections;

Random random = new Random();
int n = random.Next(1, 20);
int[] array = new int[n];
array = fillArray(array);
printArray(array);
Console.WriteLine(" -> " + sumSomeNumbers(array));




int[] fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write(" ]");
}

int sumSomeNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;

}



