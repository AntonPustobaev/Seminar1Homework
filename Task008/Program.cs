using System;
Console.Clear();

Console.WriteLine ("Введите число n: ");

int n = int.Parse(Console.ReadLine());

int x = 1; //начало

while(x <= n)
    {
        if(x % 2 == 0)
        {
            Console.WriteLine(x);
        }
        x++;
    }