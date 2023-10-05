using System;

class Kiuas
{
    // Kiuas-luokan ominaisuudet
    private bool isOn;
    private int temperature;
    private int humidity;

    // Kiuas-luokan konstruktori
    public Kiuas()
    {
        isOn = false;
        temperature = 20; // Oletuslämpötila
        humidity = 50; // Oletuskosteus
    }

    // Metodi kiukaan päälle laittamiseksi
    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine("Kiuas on nyt päällä.");
    }

    // Metodi kiukaan pois laittamiseksi
    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Kiuas on nyt pois päältä.");
    }

    // Metodi lämpötilan säätämiseksi
    public void SetTemperature(int temp)
    {
        temperature = temp;
        Console.WriteLine($"Lämpötila asetettu: {temperature} astetta.");
    }

    // Metodi kosteuden säätämiseksi
    public void SetHumidity(int hum)
    {
        humidity = hum;
        Console.WriteLine($"Kosteus asetettu: {humidity}%.");
    }

    // Metodi palauttaa kiuasolion tilan merkkijonona
    public override string ToString()
    {
        return $"Kiuas: {(isOn ? "Päällä" : "Pois päältä")}, Lämpötila: {temperature} astetta, Kosteus: {humidity}%";
    }
}

