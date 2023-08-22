namespace RastgeleSayiDependencyInjection.Services
{
    public class RastgeleBirSayi
    {
        public int Deger { get; } = new Random().Next(1, 101);
    }
}
