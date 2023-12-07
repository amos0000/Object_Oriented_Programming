using System;
using System.Collections.Generic;

class Kappale
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public int Kesto { get; set; }

    public Kappale(string nimi, string artisti, int kesto)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kesto = kesto;
    }

    public override string ToString()
    {
        return $"{Nimi} - {Artisti} ({Kesto} s)";
    }
}

class Albumi
{
    public string Nimi { get; set; }
    public string Artisti { get; set; }
    public List<Kappale> Kappaleet { get; set; }

    public Albumi(string nimi, string artisti)
    {
        Nimi = nimi;
        Artisti = artisti;
        Kappaleet = new List<Kappale>();
    }

    public void LisaaKappale(Kappale kappale)
    {
        Kappaleet.Add(kappale);
    }

    public void TulostaAlbuminTiedot()
    {
        Console.WriteLine($"Albumi: {Nimi} - {Artisti}");
        Console.WriteLine("Kappaleet:");
        foreach (var kappale in Kappaleet)
        {
            Console.WriteLine($"  {kappale}");
        }
    }
}
