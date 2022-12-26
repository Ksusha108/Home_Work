// 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

int rec(int n, int m)
{
    
    if (n == m)
        return m;
    return rec(n, m + 1) + m;
}

Console.Clear();
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));