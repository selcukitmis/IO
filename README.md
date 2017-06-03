# C# IO İşlemleri

Klasör ve Dosya işlemlerini içerir

# Klasör İşlemleri

* Klasör oluşturma

 `Directory.CreateDirectory(@"C:\Yeni Klasör");`
 
 * Klasörün oluşturma zamanı

 `DateTime olusturmaZamani = Directory.GetCreationTime(@"C:\Yeni Klasör");`

* Klasöre son erişim zamanı

`DateTime sonErisimZamani = Directory.GetLastAccessTime(@"C:\Yeni Klasör");`

* Klasöre son veri yazıldığı zaman

` DateTime sonYazimZamani = Directory.GetLastWriteTime(@"C:\Yeni Klasör");`

* Klasör içerisindeki dosyalar

`var dosyalar = Directory.GetFiles(@"C:\Yeni Klasör");`

* Klasör taşıma

`Directory.Move(@"C:\Yeni Klasör", @"D:\Yeni Klasör");`

* Klasörün olup olmadığının kontrolü

```
if (Directory.Exists(@"C:\Yeni Klasör"))
                Console.WriteLine("Evet var");
            else
                Console.WriteLine("Hayır yok");
```

* Boş klasör silme

`Directory.Delete(@"C:\Yeni Klasör");`

* Klasörü içi dolu olsa bile silme

`Directory.Delete(@"C:\Yeni Klasör", true);`

# Dosya İşlemleri

* Dosya oluşturma

 `File.Create(@"C:\Test\metinbelgesi.txt");`
 
 * Dosya taşıma

 `File.Move(@"C:\Test\metinbelgesi.txt", @"C:\Test2\metinbelgesi.txt");`
 
  * Dosya kopyalama

 `File.Copy(@"C:\Test2\metinbelgesi.txt", @"C:\Test\metinbelgesi.txt");`
 
 * Dosyanın olup olmadığının kontrolü

```
if (File.Exists(@"C:\Test2\metinbelgesi.txt"))
                Console.WriteLine("Dosya bulundu.");
            else
                Console.WriteLine("Dosya mevcut değil.");
```
 
   * Dosya Silme

 `File.Delete(@"C:\Test2\metinbelgesi.txt");`
