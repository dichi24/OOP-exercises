using System;
using System.IO;

public class Matrix
{
    // 1. Object attribute 'data' of type double[][]
    private double[][] data;

    // 2. Constructor that loads data from a file
    public Matrix(string filename)
    {
        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filename);
            // Initialize data based on the number of lines (rows)
            data = new double[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                // Split each line into parts
                string[] values = lines[i].Split(' ');
                data[i] = new double[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    // Parse and assign each value to the data array
                    data[i][j] = double.Parse(values[j]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }

    // 3. Constructor that initializes a 2D array with specified size, filled with zeros
    public Matrix(int rows, int columns)
    {
        data = new double[rows][];
        for (int i = 0; i < rows; i++)
        {
            data[i] = new double[columns];
            for (int j = 0; j < columns; j++)
            {
                data[i][j] = 0.0; // Initialize each cell with 0
            }
        }
    }

    // 4. Get and Set methods for accessing elements in the matrix
    public double GetValue(int row, int column)
    {
        return data[row][column];
    }

    public void SetValue(int row, int column, double value)
    {
        data[row][column] = value;
    }

    // 5. Save method that writes the matrix data to a file
    public void Save(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (double[] row in data)
                {
                    // Join the row elements with a space and write to file
                    writer.WriteLine(string.Join(" ", row));
                }
            }
            Console.WriteLine("Matrix saved to " + filename);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file: " + ex.Message);
        }
    }
}



