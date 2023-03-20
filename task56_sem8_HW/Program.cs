// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


string UserMessage(string message)
{
    return $"Введите {message} >>> ";
}

int GetRows(string message)
{
    Console.Write($"{UserMessage(message)}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols(string message)
{
    Console.Write($"{UserMessage(message)}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}

int[,] FillArrayRandomIntValues(int[,] matrix, int first, int last)
{
    int[,] newMatrix = matrix;
    for (int rows = 0; rows < newMatrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < newMatrix.GetLength(1); cols++)
        {
            newMatrix[rows,cols] = new Random().Next(first, last);

        }    
    }
    return newMatrix;
}

void PrintIntMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows,cols]} ");
        }
        Console.WriteLine();
    }
}


int[] GetSumElements(int[,] matrix)
{
    int[] sumElements = new int[matrix.GetLength(0)];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        int sum = 0;
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            sum = sum + matrix[rows, cols];
        }
        sumElements[rows] = sum;
    }
    return sumElements;
}
int GetMinRows(int[] array)
{
    int min = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min= array[i];
            row = i;
        }
    }
    return row;
}

void MinNumbersRows()
{
    int[,] matrix = new int[4,4];
    FillArrayRandomIntValues(matrix, -10, 10);
    PrintIntMatrix(matrix);
    int[] array = GetSumElements(matrix);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetMinRows(array) +1} строка");
}
MinNumbersRows();