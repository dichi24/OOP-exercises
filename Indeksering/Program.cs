int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};

for (int i = 0; i < iterationer; i++)
{ try
   {
    array[i]++;
   }

   catch (IndexOutOfRangeException)
   {
    Console.WriteLine("invalid index");
   }
}

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

 
