namespace BankaMusteriTakibi
{
    public class Program
    {
        static void Main(string[] args)
        {
            MusteriManager metotlar = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNum = "123";
            musteri1.Name = "Mehmet";
            musteri1.Surname = "Yalçınkaya";
            musteri1.PhoneNum = 123;
            musteri1.Adress = "abc";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNum = "456";
            musteri2.Name = "Buse";
            musteri2.Surname = "Özmen";
            musteri2.PhoneNum = 456;
            musteri2.Adress = "def";
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcNum = "789";
            musteri3.Name = "Ebubekir";
            musteri3.Surname = "Işık";
            musteri3.PhoneNum = 789;
            musteri3.Adress = "ghj";
            metotlar.Ekle(musteri1);
            metotlar.Ekle(musteri2);
            metotlar.Ekle(musteri3);
            metotlar.Listele();
            metotlar.Silme(musteri2);
            metotlar.Listele();
        }
    }
}