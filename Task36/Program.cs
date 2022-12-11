// 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 21); 
}


int ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        sum = sum + array[i];    
    return sum++;
}



Console.Clear();
int n = 9;
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Наальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов чётных позиций: {ReleaseArray(array)}");