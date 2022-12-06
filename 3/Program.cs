//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


using System.Collections;

Random random = new Random();
int n = random.Next(1, 20);
double[] array = new double[n];
array = fillArray(array);
printArray(array);
Console.Write(" -> " + Math.Round(findMinMax(array), 2));

double[] fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 10;
    }
    return array;
}

void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(Math.Round(array[i], 2) + ", ");
    }
    Console.Write(Math.Round(array[array.Length - 1], 2));
    Console.Write(" ]");
}

double findMinMax(double[] array)
{

    double min = array[0];
    double max = min;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
        else if (array[i] < min) { min = array[i]; }
    }

    return max - min;
}