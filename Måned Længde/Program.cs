class Program
{
    static void Main()
    {
        int[] månedsdage = {30, 31, 28, 30, 31, 31, 30, 31, 30, 31, 30, 31};
        Console.WriteLine("Write month's  number:");
        int måned = int.Parse(Console.ReadLine());
        
        if ( måned < 1 || måned > 12)
        {
            Console.WriteLine("Invalid number. Write another one:");
            return;
        }

        else 
        {
            Console.WriteLine($"The numbers of dage in month {måned} is: {månedsdage[måned - 1]}");
        }
    }
}
