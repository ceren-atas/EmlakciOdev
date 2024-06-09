using EmlakciUygLib;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
namespace EmlakciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ev> evList= new List<Ev>();
            string SEvYolu = @"C:\Users\Pc\OneDrive\Masaüstü\satilik.txt";
            string KEvYolu = @"C:\Users\Pc\OneDrive\Masaüstü\kiralik.txt";

            Console.Write("1-Satılık Ev \n2-Kiralık Ev \nSeçiniz: ");
            string cevap = Console.ReadLine();
            if (cevap == "1")
            {
                Console.WriteLine("a-Yeni Ev Girişi \nb-Kayıtlı Ev Görüntüleme ");
                string cevap2 = Console.ReadLine();
                if (cevap2 == "a".ToLower())
                {
                    SatilikEvEkle(SEvYolu,evList);

                }
                else if (cevap2 == "b".ToLower())
                {
                    EvleriGoruntule(SEvYolu);
                }
            }
            else if (cevap == "2")
            {
                Console.WriteLine("a-Yeni Ev Girisi \nb-Kayitli Ev Goruntuleme ");
                string cevap2 = Console.ReadLine();
                if (cevap2 == "a".ToLower())
                {
                    KiralikEvEkle(KEvYolu, evList);
                }
                else if (cevap2 == "b".ToLower())
                {
                    EvleriGoruntule(KEvYolu);
                }
            }
            else
            {
                Console.WriteLine("Yanlis Secim!");
            }

        }

        public static void SatilikEvEkle(string path , List<Ev> list )
        {
            string cevap;
            int sayac = 0;
            do
            {
                sayac++;
                using (StreamWriter ekle = new StreamWriter(path, true))
                {
                    Console.Write($"{sayac}. Evin Fiyati: ");
                    int fiyat = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Depozitosu: ");
                    int depozito = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Oda Sayisi: ");
                    int odasayisi = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Katno: ");
                    int katno = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Alani: ");
                    int alan = int.Parse(Console.ReadLine());

                    SatilikEv Sev = new SatilikEv(fiyat, depozito, odasayisi, katno, alan);
                    list.Add(Sev);
                    ekle.WriteLine($"{sayac}. Evin Fiyati: {fiyat} \n{sayac}. Evin Depozitosu: {depozito} \n{sayac}. Evin Oda Sayisi: {odasayisi} \n{sayac}. Evin Kat No: {katno} \n{sayac}. Evin Alani: {alan}");
                    ekle.WriteLine("*******************************");
                    Console.WriteLine("Tamam/Devam? ");
                    cevap = Console.ReadLine();
                }
            } while (cevap == "d".ToLower());
            Console.WriteLine("KAYDINIZ BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR!");

          
        }

        public static void KiralikEvEkle(string path , List<Ev> list)
        {
            string cvp;
            int sayac = 0;
            do
            {
                sayac++;
                using (StreamWriter ekle = new StreamWriter(path, true))
                {
                   
                    Console.Write($"{sayac}. Evin Kirasi: ");
                    int kira = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Depozitosu: ");
                    int depozito = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Oda Sayisi: ");
                    int odasayi = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Katno: ");
                    int katno = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Alani: ");
                    int alan = int.Parse(Console.ReadLine());

                    KiralikEv Kev = new KiralikEv(kira, depozito, odasayi, katno, alan);
                    list.Add(Kev);
                    ekle.WriteLine($"{sayac}. Evin Fiyati: {kira} \n{sayac}. Evin Depozitosu: {depozito} \n{sayac}. Evin Oda Sayisi: {odasayi} \n{sayac}. Evin Kat No: {katno} \n{sayac}.Evin Alani {alan}");
                    ekle.WriteLine("*******************************");
                    Console.WriteLine("Tamam / Dewam? ");
                    cvp = Console.ReadLine();
                }
            } while (cvp == "d".ToLower());
            Console.WriteLine("KAYDINIZ BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR");
        }
        public static void EvleriGoruntule(string path)
        {
            using (StreamReader read = new StreamReader(path))
            {            
                string okunanVeri = read.ReadToEnd();
                if (okunanVeri=="")
                {
                    Console.WriteLine("Kayitli Ev Bulunamadi!");
                }
                else
                {
                    Console.WriteLine(okunanVeri);
                }

            }

        }
    }
}
