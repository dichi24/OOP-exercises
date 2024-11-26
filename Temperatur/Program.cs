class Program 
{
    static void Main()
    {
        double[] dagligetemperatur = {21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9};
        string[] dage = {"Mandag,", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag"};
        
        for (int i=0; i < dagligetemperatur.Length; i++)
        {
             
        double difference = Math.Abs (dagligetemperatur[i] - dagligetemperatur[i - 1]);
          Console.WriteLine($"Temperaturdifferencen mellem {dage[i]}  og {dage[i - 1]}: {difference}");
        
        }
    }
}