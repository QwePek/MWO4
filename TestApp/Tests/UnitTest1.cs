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

            // Wywo�anie metody, kt�r� chcemy przetestowa�
            int wynik = klasa.Dodaj(2, 3);

            // Sprawdzenie wyniku
            int oczekiwanyWynik = 5;
            Assert.Equals(oczekiwanyWynik, wynik);
        }
    }
}