using System;
class Program
{
    static void Main()
    {
        double pi = 3.14;
        double radius1, radius2, radius3;
        radius1 = 1;
        radius2 = 3;
        radius3 = 5;
        double omkredsen1 = 2 * pi * radius1;
        double omkredsen2 = 2 * pi * radius2;
        double omkredsen3 = 2 * pi * radius3; 
        double sum = omkredsen1 + omkredsen2 + omkredsen3;
        Console.WriteLine(sum);


    }
}
