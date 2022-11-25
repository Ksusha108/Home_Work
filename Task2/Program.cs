Console.Clear();
Console.WriteLine("Введите 1-е число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число ");
int m = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if ( n > m ) 
{
    max = n; min = m;
}
 else 
 {
    max = m; min = n;
 }
Console.Write("max = ");
Console.WriteLine(max);
 Console.Write("min = ");
 Console.Write(min);
    


    
