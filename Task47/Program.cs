// 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

void InputMatrix(double[, ] matrix)
{
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[double.Parse(numbers[0]), double.Parse(numbers[1])];
InputMatrix(matrix);