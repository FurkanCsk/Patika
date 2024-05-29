// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


using System.Collections;
using System.Globalization;
using System.Collections.Generic;

ArrayList asal = new ArrayList();
ArrayList asalolmayan = new ArrayList();
ArrayList sayilar = new ArrayList();
int asalSayaci = 0; int asalOlmayanSayac = 0;
int asalOrtalama = 0; int asalOlmayanOrtalama = 0;
int asalToplam = 0; int asalOlmayanToplam = 0;

Console.WriteLine("Lütfen sayıları giriniz :");
for(int i=0; i<20; i++)
{
    // Girilen sayıların negatif ve numeric kontrolünü burada yapacağız.
    try
    {
       int n = Convert.ToInt32(Console.ReadLine());

       if(n <= 0)
       {
        Console.WriteLine("Lütfen pozitif bir tam sayı giriniz");
       }
       else
       {
        sayilar.Add(n);
       }

    }
    catch(Exception ex)
    {
        Console.WriteLine("Hata : Lütfen girmiş olduğunuz sayının uygunluğunu kontrol ediniz. Gİrilen değer bir sayı olmalıdır.");
    }
}
    // Asal olan ve olmayan sayıları ait olduğu listelere ayıralım.
foreach (var item in sayilar)
{
   if(AsalKontrol(Convert.ToInt32(item)) == true)
   {
    asal.Add(item);
    asalSayaci++;
    asalToplam = asalToplam + Convert.ToInt32(item);
   }
   else
   {
    asalolmayan.Add(item);
    asalOlmayanSayac++;
    asalOlmayanToplam = asalOlmayanToplam + Convert.ToInt32(item);
   }
}
//Sayıların ortalamasını alalım
asalOrtalama = asalToplam / asalSayaci;
asalOlmayanOrtalama = asalToplam / asalOlmayanSayac;

asal.Sort();
asalolmayan.Sort();
asal.Reverse();
asalolmayan.Reverse();

Console.WriteLine("Asal sayıların büyükten küçüğe sıralanması: "); // Asal ArrayList ' i ekrana yazdırma aşaması
foreach (var item in asal)
{
     Console.Write(item +" ");    
}
Console.WriteLine(" ");
Console.WriteLine("Asal listenin eleman sayısı : " + asalSayaci);
Console.WriteLine("Asal listenin sayılarının ortalaması : " + asalOrtalama);

Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralanması: "); // Asal olmayan ArrayList' i ekrana yazdırma aşaması
foreach (var item in asalolmayan)
{
    Console.Write(item + " ");
}
Console.WriteLine(" ");
Console.WriteLine("Asal olmayan listenin eleman sayısı : " + asalOlmayanSayac);
Console.WriteLine("Asal olmayan listedeki sayıların ortalaması : " + asalOlmayanOrtalama);






static bool AsalKontrol(int sayi)
{
 if(sayi <= 1)
 {
 return false;
 }

 for(int i=2; i <= Math.Sqrt(sayi); i++)
 {
      if (sayi % i == 0)
      {
        return false;
      }
 }
  return true;
}