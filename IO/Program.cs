using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            DosyaIslemleri();
            KlasorIslemleri();

            Console.ReadLine();
        }

        static void KlasorIslemleri()
        {
            //C: dizini altına Yeni Klasör isminde bir klasör oluşturur.
            Directory.CreateDirectory(@"C:\Yeni Klasör");

            //Belirtilen klasörün oluşturulduğu tarih ve zamanı gösterir.
            DateTime olusturmaZamani = Directory.GetCreationTime(@"C:\Yeni Klasör");
            Console.WriteLine(olusturmaZamani.ToString());

            //Klasöre en son erişim sağlandığı zamanın bilgisini döndürür.
            DateTime sonErisimZamani = Directory.GetLastAccessTime(@"C:\Yeni Klasör");
            Console.WriteLine(sonErisimZamani.ToString());

            //Klasöre en son veri yazıldığı zamanın bilgisini döndürür.
            DateTime sonYazimZamani = Directory.GetLastWriteTime(@"C:\Yeni Klasör");
            Console.WriteLine(sonYazimZamani.ToString());

            //klasör içerisindeki dosyaları döndürür.
            var dosyalar = Directory.GetFiles(@"C:\Yeni Klasör");
            foreach (var dosya in dosyalar)
            {
                Console.WriteLine(dosya);
            }

            //Klasörü birinci parametredeki dizinden alıp, ikinci parametredeki dizine taşır.
            Directory.Move(@"C:\Yeni Klasör", @"D:\Yeni Klasör");

            //Belirtilen klasörün belirtilen yolda var olup olmadığını kontrol eder.
            if (Directory.Exists(@"C:\Yeni Klasör"))
                Console.WriteLine("Evet var");
            else
                Console.WriteLine("Hayır yok");

            //C: dizini altındaki içerisi boş olan Yeni Klasör’ü siler.
            Directory.Delete(@"C:\Yeni Klasör");

            //C: dizini altındaki içerisi boş veya dolu fark etmez Yeni Klasör’ü siler.
            Directory.Delete(@"C:\Yeni Klasör", true);

        }

        static void DosyaIslemleri()
        {
            // Demo yapabilmek için test ve test2 klasörlerini c dizinine ekliyoruz
            Directory.CreateDirectory(@"C:\Test");
            Directory.CreateDirectory(@"C:\Test2");

            //C: dizinindeki Test klasörünün içerisine metinbelgesi isminde bir metin dosyası oluşturur.
            FileStream fs = File.Create(@"C:\Test\metinbelgesi.txt");

            //Create ile bir dosya oluşturulduğunda Filestream nesnesi döndürülür.
            //FileStream akışı kapatılmadan dosya kopyalama ve taşıma işlemleri yapılamaz.
            fs.Close();

            //1.parametrede adı geçen dosya, ikinci parametrede belirtilen adrese taşınır.
            File.Move(@"C:\Test\metinbelgesi.txt", @"C:\Test2\metinbelgesi.txt");

            //1.parametrede adı geçen dosya, ikinci parametrede belirtilen adrese kopyalanır.
            File.Copy(@"C:\Test2\metinbelgesi.txt", @"C:\Test\metinbelgesi.txt");

            // belirtilen yolda belirtilen dosyanın var olup olmadığını kontrol eder
            if (File.Exists(@"C:\Test2\metinbelgesi.txt"))
                Console.WriteLine("Dosya bulundu.");
            else
                Console.WriteLine("Dosya mevcut değil.");

            //Belirtilen dosyayı siler.
            File.Delete(@"C:\Test2\metinbelgesi.txt");

        }
    }
}