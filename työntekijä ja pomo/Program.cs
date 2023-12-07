using System;

class Program
{
    static void Main()
    {
        Työntekijä työntekijä = new Työntekijä("Matti", "Ohjelmoija", 50000, 35);
        Console.WriteLine($"Työntekijän palkka: {työntekijä.LaskePalkka()}");

        Pomo pomo = new Pomo("Seppo", "Johtaja", 80000, 10000, "Mercedes");
        Console.WriteLine($"Pomon palkka: {pomo.LaskePalkka()}");

        // Yritetään luoda toinen johtaja - tämä aiheuttaa poikkeuksen
        try
        {
            Pomo toinenPomo = new Pomo("Toinen", "Toinen Johtaja", 90000, 12000, "BMW");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Virhe: {ex.Message}");
        }

        Console.ReadLine();
    }
}
