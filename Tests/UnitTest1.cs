using TestApp;
using Xunit;

namespace Tests
{
    public class KlasaTests
    {
        [Fact]
        public void TestDodawania()
        {
            // Przygotowanie
            Klasa klasa = new Klasa();

            // Wywo³anie metody, któr¹ chcemy przetestowaæ
            int wynik = klasa.Dodaj(2, 3);

            // Sprawdzenie wyniku
            int oczekiwanyWynik = 5;
            Assert.Equals(oczekiwanyWynik, wynik);
        }
    }
}