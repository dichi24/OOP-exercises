class Adder
{
    

    public static string Solve(int a, int b)
    { 
        int sum = a + b;
        return $"{a} + {b} = {sum}";
    }

    public static string Solve(double value1, double value2)
    {
        double summ = value1 + value2;
        return $"{value1} + {value2} = {summ}";
    }

}