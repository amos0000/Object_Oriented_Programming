using System;
using System.Collections.Generic;

class Pelaaja
{
    public string Etunimi { get; set; }
    public string Sukunimi { get; set; }
    public int PelaajaNumero { get; set; }
}

class Joukkue
{
    public string Nimi { get; set; }
    public string Kotikaupunki { get; set; }
    private Dictionary<int, Pelaaja> Pelaajat { get; set; } = new Dictionary<int, Pelaaja>();

    public Pelaaja HaePelaaja(int pelaajaNumero)
    {
        try
        {
            return Pelaajat[pelaajaNumero];
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Pelaajaa numerolla {pelaajaNumero} ei löytynyt.");
            return null;
        }
    }

    public void LisaaPelaaja(Pelaaja pelaaja)
    {
        try
        {
            Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
            Console.WriteLine($"Pelaaja {pelaaja.Etunimi} {pelaaja.Sukunimi} lisätty joukkueeseen.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine($"Pelaaja numerolla {pelaaja.PelaajaNumero} on jo joukkueessa.");
        }
    }

    public void PoistaPelaaja(int pelaajaNumero)
    {
        try
        {
            Pelaajat.Remove(pelaajaNumero);
            Console.WriteLine($"Pelaaja numerolla {pelaajaNumero} poistettu joukkueesta.");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Pelaajaa numerolla {pelaajaNumero} ei löytynyt joukkueesta.");
        }
    }

    public List<Pelaaja> HaePelaajat()
    {
        return new List<Pelaaja>(Pelaajat.Values);
    }
}

class Program
{
    static void Main()
    {
        Joukkue joukkue = new Joukkue
        {
            Nimi = "KalPa",
            Kotikaupunki = "Kuopio"
        };

        Pelaaja pelaaja1 = new Pelaaja { Etunimi = "Mika", Sukunimi = "Metso", PelaajaNumero = 1 };
        Pelaaja pelaaja2 = new Pelaaja { Etunimi = "Mikko", Sukunimi = "joki", PelaajaNumero = 2 };
        Pelaaja pelaaja3 = new Pelaaja { Etunimi = "Seppo", Sukunimi = "Simonen", PelaajaNumero = 3 };

        joukkue.LisaaPelaaja(pelaaja1);
        joukkue.LisaaPelaaja(pelaaja2);
        joukkue.LisaaPelaaja(pelaaja3);

        Console.WriteLine("Joukkueen pelaajat:");
        List<Pelaaja> pelaajat = joukkue.HaePelaajat();
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine($"{pelaaja.PelaajaNumero}: {pelaaja.Etunimi} {pelaaja.Sukunimi}");
        }

        joukkue.PoistaPelaaja(2);

        Console.WriteLine("\nPäivitetty pelaajalista:");
        pelaajat = joukkue.HaePelaajat();
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine($"{pelaaja.PelaajaNumero}: {pelaaja.Etunimi} {pelaaja.Sukunimi}");
        }
    }
}
