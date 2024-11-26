int[] talRække = {3, 5, 6, 3, 2, 3, 7, 6, 5, 3};
int Sum ( int[] talRække) 
{
	int rækkesum = 0;
	for (int i = 0; i < talRække.Length; i++)
	{
		rækkesum = rækkesum + talRække[i];
	
	}
	return rækkesum; 
}
//Console.WriteLine(Sum(talRække));

/*

i++
i = i + 1

*/
 
 //Console.WriteLine(Math.Pow(2, 2));
 
 int a = 2;
 int b = 3;
 
 int Pow ( int A, int B) 
 {
	 int result = A;
	 for ( int i = 1; i < B; i++)
	 {
		 result = result * A;
	 }
	 return result;
 }
 Console.WriteLine(Pow(a,b));
 