using System;

abstract class Henkilö
{
    public string Nimi { get; set; }
    public string Työpaikka { get; set; }
    public double Palkka { get; set; }

    public Henkilö(string nimi, string työpaikka, double palkka)
    {
        Nimi = nimi;
        Työpaikka = työpaikka;
        Palkka = palkka;
    }

    public abstract double LaskePalkka();
}
