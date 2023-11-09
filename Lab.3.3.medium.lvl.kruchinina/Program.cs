//24 var

try
{
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    double n = double.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0)
            s += Math.Pow(x + 1, 2 * i) / i;
        else
            s -= Math.Pow(-1, i) / i;
    }
} catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}