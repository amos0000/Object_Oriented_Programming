using System;

class Pomo : Henkilö
{
    public double Bonus { get; set; }
    public string Auto { get; set; }

    private static bool OnJohtajaOlemassa = false;

    public Pomo(string nimi, string työpaikka, double palkka, double bonus, string auto)
        : base(nimi, työpaikka, palkka)
    {
        if (OnJohtajaOlemassa)
        {
            throw new InvalidOperationException("Vain yksi johtaja sallittu.");
        }

        OnJohtajaOlemassa = true;
        Bonus = bonus;
        Auto = auto;
    }

    public override double LaskePalkka()
    {
        return Palkka + Bonus;
    }
}
