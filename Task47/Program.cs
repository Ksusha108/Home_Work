// 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

void InputMatrix(double[, ] matrix)
{
    for (double i = 0; i < matrix.GetLength(0); i++)
    {
        for (double j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); 
            Console.Write(Math.Sqrt(matrix[i, j]));
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[, ] matrix = new double[size[0], size[1]];
InputMatrix(matrix);