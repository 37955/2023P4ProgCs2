using System;

namespace EnumOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Colors myMainThemeColor = Colors.Purple;

            if (myMainThemeColor == Colors.Purple)
            {
                Console.WriteLine("Dat is mijn kleur!");
            }

            Colors[] allColors = (Colors[])Enum.GetValues(typeof(Colors));
            foreach (Colors color in allColors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Voer een kleur in (Purple, Red, Blue, Green):");
            string value = Console.ReadLine();
            Colors parsedColor;
            if (Enum.TryParse(value, true, out parsedColor))
            {
                Console.WriteLine($"Je hebt {parsedColor} gekozen.");
            }
            else
            {
                Console.WriteLine("Ongeldige kleur ingevoerd.");
            }
        }
    }
}
