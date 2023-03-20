// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


void GetSortElements(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if(matrix[rows, k] < matrix[rows, k + 1])
                {
                    int temp = matrix[rows, k + 1];
                    matrix[rows, k + 1] = matrix[rows, k];
                    matrix[rows, k] = temp;
                }
            }
        }
    }
}

void ReverseElements()
{
    int row = GetRows("количество строк");
    int col = GetCols("количество столбцов");
    int[,] matrix = new int[row, col];
    FillArrayRandomIntValues(matrix, -10, 10);
    Console.WriteLine("Изначальный массив");
    PrintIntMatrix(matrix);
    GetSortElements(matrix);
    Console.WriteLine("Упорядоченный массив");
    PrintIntMatrix(matrix);
}
ReverseElements();