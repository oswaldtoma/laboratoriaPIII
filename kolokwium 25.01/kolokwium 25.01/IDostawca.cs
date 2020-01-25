namespace kolokwium_25._01
{
    public interface IDostawca
    {
        Produkt Wyszukaj(string nazwa);
        void Zamow(Produkt produkt);
    }
}