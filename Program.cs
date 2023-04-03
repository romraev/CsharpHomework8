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

// Task 56. Задайте прямоугольный двумерный массив. 
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
    Console.WriteLine();
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

Console.WriteLine("Введите данные для 1-ой матрицы..");
int[,] myArray1 = CreateRandom2dArray();
Console.WriteLine("Введите данные для 2-ой матрицы..");
int[,] myArray2 = CreateRandom2dArray();
if (myArray1.GetLength(1) != myArray2.GetLength(0)) Console.WriteLine("Эти матрицы нельзя перемножить!");
else
{
    int[,] multipliedArray = MultiplyMatrix(myArray1, myArray2);
    Write2dArray(myArray2);
    Write2dArray2(myArray1, multipliedArray);
}
*/

// Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/* int[,,] CreateRandom3dArray(int row, int column, int level)
{
    int[,,] array = new int[row, column, level];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            for (int k = 0; k < level; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                for (int l = 0; l < array.GetLength(0); l++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                        for (int n = 0; n < array.GetLength(2); n++)
                        {
                            if (l == i && m == j && n == k) break;
                            else if (array[i, j, k] == array[l, m, n])
                            {
                                array[i, j, k] = new Random().Next(10, 100);
                                l = 0;
                                m = 0;
                                n = 0;
                            }
                        }
                }
            }
    return array;
}

void Write3dArray(int[,,] array) // Жду доп. балл за старания с выводом
{
    for (int s = 1; s <= array.GetLength(1); s++)
        Console.Write("  ");
    for (int c = 1; c <= array.GetLength(1); c++)
        Console.Write("/" + c + " ");

    Console.WriteLine();

    for (int l = 1; l <= array.GetLength(1) * 2 - 1; l++)
        Console.Write("___");

    Console.WriteLine();

    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int sp = 1; sp <= array.GetLength(1) * 2 - i - 3; sp++)
                Console.Write(" ");

            Console.Write(i + 1 + "/ ");

            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j, k] + " ");

            Console.WriteLine();
        }
        for (int l = 1; l <= array.GetLength(1) * 2 - 1; l++)
            Console.Write("___");
        Console.Write(k + 1 + " ");
        Console.WriteLine();
    }

}

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число этажей: ");
int levels = Convert.ToInt32(Console.ReadLine());

if (rows * columns * levels > 100) Console.WriteLine("Слишком большой массив!");
else
{
    int[,,] myArray = CreateRandom3dArray(rows, columns, levels);
    Write3dArray(myArray);
}
*/