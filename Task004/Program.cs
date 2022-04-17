using System;
Console.Clear();

int a, b, c;

int max;
 
Console.WriteLine ("Введите числа: ");
 
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

max=a;

if (b>max)
{
        max = b;
}
if (c>max)
    {
        max = c;    
    }


Console.WriteLine($"max  {max}");