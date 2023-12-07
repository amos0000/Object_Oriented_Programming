using System;
using System.Collections.Generic;

// Korttipeli-luokka sisältää korttipakan toiminnot
class Korttipeli
{
    // Korttipakan sisältö tallennetaan tähän listaan
    private List<string> kortit = new List<string>();

    // Metodi lisää kortin korttipakkaan
    public void LisaaKortti(string kortti)
    {
        kortit.Add(kortti);
    }

    // Metodi tulostaa korttipakan sisällön konsoliin
    public void TulostaKorttipakka()
    {
        Console.WriteLine("Korttipakka:");
        foreach (var kortti in kortit)
        {
            Console.WriteLine(kortti);
        }
    }

    // Metodi sekoittaa kortit korttipakassa
    public void SekoitaKortit()
    {
       
        Random random = new Random();
        int n = kortit.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = kortit[k];
            kortit[k] = kortit[n];
            kortit[n] = value;
        }
        Console.WriteLine("Kortit on sekoitettu.");
    }
}
