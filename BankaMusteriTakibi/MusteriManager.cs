using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaMusteriTakibi
{
    public class MusteriManager
    {
        ArrayList musteriler = new ArrayList();
        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Tebrikler"+ " "+ musteri.Name + " " + musteri.Surname + " "+ "isimli müşteri eklendi !");
        }
        public void Listele()
        {
            foreach (Musteri musteri in musteriler)
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
        }
        public void Silme(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Tebrikler" + " " + musteri.Name + " " + musteri.Surname + " "+ "isimli müşteri silindi !");
        }
    }
}
