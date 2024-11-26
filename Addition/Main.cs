class Program
{
    static void Main()
    {
      string result = Adder.Solve(3,5);
      Console.WriteLine($"Int result is {result}");

      string result2 = Adder.Solve(3.4, 2.6);
      Console.WriteLine($"Double result is {result2}");
    }
}