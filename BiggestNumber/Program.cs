

int BiggestNumber(int[] talListe){
	int biggestNumber = 0;
	int index = 0;
	
	for (int i = 0; i<talListe.Length; i++){
		if (talListe[i] > biggestNumber){
			biggestNumber = talListe[i];
			index = i;
		}
	}
	return index;
}
	
int[] liste = {2,5,1,7,4};

Console.WriteLine(BiggestNumber(liste));
Console.WriteLine(liste[BiggestNumber(liste)]);

void MultiplicationTabel(){
	int size;
	size = 20;
	int[] liste;
	liste = new int[25];
	
	for (int i = 0; i<liste.Length; i++) {
		liste[i] = i*3; 
	} 
	for (int i = 0; i<liste.Length; i++) {
		Console.WriteLine(liste[i]);
	} 
}

MultiplicationTabel();