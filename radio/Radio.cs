using System;

public class Radio
{
    private bool päällä;
    private int äänenvoimakkuus;
    private double taajuus;

    public Radio()
    {
        päällä = false;
        äänenvoimakkuus = 5;
        taajuus = 88.0;
    }

    public void Käynnistä()
    {
        if (!päällä)
        {
            Console.WriteLine("Radio käynnistetty.");
            päällä = true;
        }
        else
        {
            Console.WriteLine("Radio on jo päällä.");
        }
    }

    public void Sammuta()
    {
        if (päällä)
        {
            Console.WriteLine("Radio sammutettu.");
            päällä = false;
        }
        else
        {
            Console.WriteLine("Radio ei ole päällä.");
        }
    }

    public void AsetaÄänenvoimakkuus(int uusiÄänenvoimakkuus)
    {
        if (uusiÄänenvoimakkuus >= 0 && uusiÄänenvoimakkuus <= 9)
        {
            äänenvoimakkuus = uusiÄänenvoimakkuus;
            Console.WriteLine($"Äänenvoimakkuus asetettu: {äänenvoimakkuus}");
        }
        else
        {
            Console.WriteLine("Virhe: Äänenvoimakkuuden on oltava välillä 0-9.");
        }
    }

    public void AsetaTaajuus(double uusiTaajuus)
    {
        if (uusiTaajuus >= 88.0 && uusiTaajuus <= 107.9)
        {
            taajuus = uusiTaajuus;
            Console.WriteLine($"Taajuus asetettu: {taajuus}");
        }
        else
        {
            Console.WriteLine("Virhe: Taajuuden on oltava välillä 88.0-107.9.");
        }
    }
}

