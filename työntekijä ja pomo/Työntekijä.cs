using System;

class Työntekijä : Henkilö
{
    public double Viikkotunnit { get; set; }

    public Työntekijä(string nimi, string työpaikka, double palkka, double viikkotunnit)
        : base(nimi, työpaikka, palkka)
    {
        Viikkotunnit = viikkotunnit;
    }

    public override double LaskePalkka()
    {
        return Palkka * (Viikkotunnit / 40); // Oletetaan tässä 40 työtuntia viikossa
    }
}
