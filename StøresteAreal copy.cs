double længdeA = 5.4;
double breddeA = 1.4;
double længdeB = 3.2;
double breddeB = 1.5;

double arealA = længdeA * breddeA;
double arealB = længdeB * breddeB;

double StørsteAreal ( double A, double B)
{ 
	if (A > B)
	{
	Console.WriteLine("Største areal firekenten A");
	return A;
	}
	else
	{
	 Console.WriteLine("Støreste areal firekenten B");
	 return B;
	}
}  
/*Console.WriteLine(StørsteAreal(arealA , arealB)); */

double[] FirekentA = {5.4, 1.4};
double[] FirekentB = new double[2];
FirekentB[0] = 3.2;
FirekentB[1] = 1.5;

double SAreal ( double [] FirekentA, double[] FirekentB)
{
	double arealA = FirekentA[0] * FirekentA[1];
	double arealB = FirekentB[0] * FirekentB[1];
	
	if (arealA > arealB) 
	{
		Console.WriteLine("FirekentA");
		return arealA;
	}
	else 
	{
		Console.WriteLine("FirekentB");
		return arealB;
	}
}
// Console.WriteLine(SAreal(FirekentA, FirekentB)); 

double[,] firekanter = new double[2,2];
firekanter[0, 0] = FirekentA[0];
firekanter[0, 1] = FirekentA[1];
firekanter[1, 0] = FirekentB[0];
firekanter[1, 1] = FirekentB[1]; 

