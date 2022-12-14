// 41 task
Console.Clear();

Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0)
        count++;
}
Console.WriteLine(count);
