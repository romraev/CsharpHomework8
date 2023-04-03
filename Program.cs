// Подготовил Раевский Р.Ю.

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

// Task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray()
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
            Console.Write("  ");
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }
    for (int j = 0; j < array.GetLength(1) * 3 - 1; j++)
        Console.Write("__");

    Console.WriteLine();
}

void Write2dArray2(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
            Console.Write(array1[i, j] + " ");

        Console.Write("|");
        for (int j = 0; j < array2.GetLength(1); j++)
            if (array2[i, j] < 10) Console.Write(array2[i, j] + "  ");
            else Console.Write(array2[i, j] + " ");

        Console.WriteLine();
    }
    //Console.WriteLine();
}

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
                result[i, j] += array1[i, k] * array2[k, j];
    return result;
}

int[,] myArray1 = CreateRandom2dArray();
int[,] myArray2 = CreateRandom2dArray();
if (myArray1.GetLength(1) != myArray2.GetLength(0)) Console.WriteLine("Эти матрицы нельзя перемножить!");
else
{
    int[,] multipliedArray = MultiplyMatrix(myArray1, myArray2);
    Write2dArray(myArray2);
    Write2dArray2(myArray1, multipliedArray);
}