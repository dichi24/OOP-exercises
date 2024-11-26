int Tal()
{
	Random random = new Random();
	
		int a = random.Next(1,101);
		return a;
}


void over50(int b)
{
	if ( b > 50)
	{
		Console.WriteLine("Tallet er over 50");
		
	}
	else if (b < 50)
	{
		Console.WriteLine("Tallet er under 50");
	}
	else 
	{
		Console.WriteLine("Tallet er 50");
	}
	if ( b % 2 == 0) 
	{
		Console.WriteLine("Lige tal");
	}
	else 
	{
		Console.WriteLine("Ikke lige tal");
	}
}
for (int i = 0; i < 10; i++)
	{ 	
		int tal = Tal();
		Console.WriteLine(tal);
		over50(tal);
	}