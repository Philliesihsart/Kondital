namespace Kondital;

class Program
{
    public static void Main()
    {
        Console.Write("Indtast din max puls i heltal slag i minuttet: ");
        int maxpuls = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.Write("Indtast din hvilepuls i heltal slag i minuttet: ");
        int hvilepuls = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.Write("Indtast din vægt (kg): ");
        double vægt = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Dit kondital er: " + Kondital.BeregnKondital(maxpuls, hvilepuls) + " ml/kg/min");
    }

}

class Kondital
{
    public static double BeregnKondital(int MaxPuls, int HvilePuls)
    {
        double intKondi = Math.Round((double)MaxPuls / HvilePuls * 15.3);
        return intKondi;
    }
}