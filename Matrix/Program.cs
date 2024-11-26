class Program
{ static void Main()
    {
    Matrix matrix = new Matrix(4, 6);
        
        // Print the initial matrix (optional)
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(matrix.GetValue(i, j) + " ");
            }
            Console.WriteLine();
        }

        // Save the matrix to a file
      matrix.Save("matrix.txt");
    }
}
