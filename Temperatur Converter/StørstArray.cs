class Program
{
    static void Main()
    {
        int[] numbers = {1, 5, 7, 4};
        int biggestnumber = numbers[0];
        int index = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > biggestnumber)
            {
                biggestnumber = numbers[i];
                index = i;
            }
        }
        Console.WriteLine($"The biggest number is {biggestnumber} ved index {index}");
    }
}
    //syntaks for hvor mange elementer der skal være plads til: int[] numbers = new int[4];