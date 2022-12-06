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

        Console.WriteLine("maxpuls: {0}\nHvilepuls: {1}\nVægt: {2}", maxpuls, hvilepuls, vægt);
    }

}

class Kondital
{

}