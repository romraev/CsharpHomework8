﻿// Подготовил Раевский Р.Ю.

// Task 52. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* int[,] CreateRandom2dArray()
{
    Console.Write("Введите число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);

    return array;
}

void Write2dArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = 0; count < array.GetLength(1) - 1; count++) // Честно пытался попробовать другие способы, но они показались уж слишком мудрёными
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
SortArray(myArray);
Write2dArray(myArray);
*/

// Task 58. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* int[,] CreateRandom2dArray()
{
    Console.Write("Введите число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);

    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinRowSum(int[,] array)
{
    int row = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if(sum < min || i == 0) 
        {
            min = sum;
            row = i;
        }    
    }
    return row;    
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
Console.WriteLine($"Строка с наименьшей суммой элементов под номером - {FindMinRowSum(myArray)+1}");
*/

// 