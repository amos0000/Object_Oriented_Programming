// Program-luokka sisältää ohjelman pääkoodin
class Program
{
    static void Main()
    {
        
        Korttipeli korttipeli = new Korttipeli();

       
        korttipeli.LisaaKortti("Hertta 2");
        korttipeli.LisaaKortti("Ruutu Kuningas");
        korttipeli.LisaaKortti("Pata 7");
        korttipeli.LisaaKortti("Risti Ässä");

        
        korttipeli.TulostaKorttipakka();

       
        korttipeli.SekoitaKortit();

        
        korttipeli.TulostaKorttipakka();
    }
}
