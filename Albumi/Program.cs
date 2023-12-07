class Program
{
    static void Main()
    {
        // Luo Albumi-olio
        Albumi albumi = new Albumi("evolve", "imagine dragons");

        // Lisää Kappale-olioita Albumiin
        albumi.LisaaKappale(new Kappale("Kappale 1", "Artisti 1", 180));
        albumi.LisaaKappale(new Kappale("Kappale 2", "Artisti 2", 200));
        albumi.LisaaKappale(new Kappale("Kappale 3", "Artisti 3", 160));

        // Tulosta Albumin tiedot
        albumi.TulostaAlbuminTiedot();
    }
}

