class Program
{
    static void Main()
    {
        Radio radio = new Radio();

        while (true)
        {
            Console.WriteLine("\nValitse toiminto:");
            Console.WriteLine("1. Käynnistä radio");
            Console.WriteLine("2. Sammuta radio");
            Console.WriteLine("3. Aseta äänenvoimakkuus");
            Console.WriteLine("4. Aseta taajuus");
            Console.WriteLine("5. Poistu");

            int valinta = Convert.ToInt32(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    radio.Käynnistä();
                    break;
                case 2:
                    radio.Sammuta();
                    break;
                case 3:
                    Console.Write("Anna uusi äänenvoimakkuus (0-9): ");
                    int uusiÄänenvoimakkuus = Convert.ToInt32(Console.ReadLine());
                    radio.AsetaÄänenvoimakkuus(uusiÄänenvoimakkuus);
                    break;
                case 4:
                    Console.Write("Anna uusi taajuus (88.0-107.9): ");
                    double uusiTaajuus = Convert.ToDouble(Console.ReadLine());
                    radio.AsetaTaajuus(uusiTaajuus);
                    break;
                case 5:
                    Console.WriteLine("Poistutaan ohjelmasta.");
                    return;
                default:
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                    break;
            }
        }
    }
}
