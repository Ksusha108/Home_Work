// Напишите программу, которая задаёт массив из 8 элементов, 
//предоставить возможность пользователю ввести числа и вывести их на экран.

Console.Clear();
int n = 8;
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элементы массива: ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
