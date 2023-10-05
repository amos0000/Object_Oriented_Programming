class Program
{
    static void Main()
    {
        // Luo kiuasolio käyttäen Kiuas-luokkaa
        Kiuas kiuas = new Kiuas();

        // Käytä kiuasta erilaisilla arvoilla
        kiuas.TurnOn();
        kiuas.SetTemperature(75);
        kiuas.SetHumidity(60);

        // Tulosta kiuasolion tila konsoliin
        Console.WriteLine(kiuas);

        kiuas.TurnOff();

        // Pysäytä ohjelma, jotta näet tulosteet ennen kuin ikkuna sulkeutuu
        Console.ReadLine();
    }
}
