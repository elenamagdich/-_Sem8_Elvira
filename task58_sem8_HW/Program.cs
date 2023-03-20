// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


void MultyMatrix(int[,] matrixA, int[,] matrixB)
{
   int rowsA = matrixA.GetLength(0);
   int colsB = matrixB.GetLength(1);
   int [,] result = new int [rowsA, colsB];
    if(matrixA.GetLength(1) == matrixB.GetLength(0))
    {
       for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int tmp = 0; tmp < matrixA.GetLength(1); tmp++)
                {
                    result[i,j] += matrixA[i,tmp] * matrixB[tmp,j];
                }
            }
        }
    }
 }

void MultyMatrixResult()
{
    int[,] matrixA = new int[3,3];
    FillArrayRandomIntValues(matrixA, 1, 5);
    Console.WriteLine($"Первая матрица: ");
    PrintIntMatrix(matrixA);
    int[,] matrixB = new int[3,3];
    FillArrayRandomIntValues(matrixB, 1, 5);
    Console.WriteLine($"Вторая матрица: ");
    PrintIntMatrix(matrixB);
    MultyMatrix(matrixA, matrixB);
   }
MultyMatrixResult();