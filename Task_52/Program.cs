/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("] ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++) //for (int i = 0; i < array.GetLength(0); i++) 
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++) //for (int j = 0; j < array.GetLength(1); j++)

            sum += array[j, i]; // если оставить [i, j] то будет считать среднюю строк но только в квадратном массиве.
            // 

        averageArray[i] = sum / array.GetLength(0);
    }
    Console.WriteLine("Среднее арифмитическое столбцов: ");
    Console.Write("[ ");
    for (int i = 0; i < averageArray.Length; i++)
        Console.Write(averageArray[i] + " ");
    Console.Write("]");
}



int[,] myArray = CreateRandomArray();
PrintArray(myArray);
Average(myArray);
