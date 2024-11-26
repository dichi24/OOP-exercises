using System.Runtime.Serialization;

class AvgGrageError
{
   public static int[] grades = {4, 7, 02, 00, 10, 4, 12};

    public static int GetGrade(int courseid)
    {
        if (courseid < 0 || courseid >= grades.Length)
        {
            throw new IndexOutOfRangeException("Invalid course id");
        }

        int grade = grades[courseid];

        if (grade > 0)
        {
            return grade;
        }

        else 
        {
            throw new Exception("Grade not passing.");
        }
     
      
    }
  public static void Main()
    {
        int count = 0;
        int sum = 0;

        for( int courseid = 0; courseid < grades.Length; courseid++ )
        {
            try {
                int grade = GetGrade(courseid);
                sum += grade;
                count++;
            }

            catch ( Exception e)
            {
                Console.WriteLine($"Error with course id {courseid}: {e.Message}");
            }
        }

    if (count > 0)
{
    double average = (double) sum / count;
    Console.WriteLine($"Average of passing gardes: {average}");
}

    else 
{
    Console.WriteLine("No passing gardes found.");
}

    }
}


