//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
//(Array sınıfını kullanarak yazınız.)


int[] enkucuk = new int[3];
int[] enbuyuk = new int[3];
int[] sayilar = new int[20];
int kucuktoplam = 0;
int buyuktoplam = 0;
double kucukortalama = 0;
double buyukortalama = 0;
double ortalamatoplam = 0;

Console.WriteLine("Lütfen sayı girişlerini yapınız");
for(int i = 0; i < 20; i++)
{
    sayilar[i] = Convert.ToInt32(Console.ReadLine());    // Kullanıcıdan 20 sayıyı aldığımız kısım
}

Array.Sort(sayilar);                                          // Sayıları sıralıyoruz

Array.Copy(sayilar, enkucuk, 3);
Array.Copy(sayilar, 17, enbuyuk,0,3);                    // Bu alanda en büyük ve en küçük üç değeri ayrı ayrı arraylere ayırdık. Buraya 17 yerine sayilar.length - 3 yazılarakta devam edilebilir.

Console.WriteLine("Girilen sayılardan en küçük 3 tanesi : ");
foreach (var item in enkucuk)
{
    Console.WriteLine(item);
    kucuktoplam += item;
}
Console.WriteLine("Girilen sayılardan en büyük 3 tanesi : ");
foreach (var item in enbuyuk)
{
    Console.WriteLine(item);
    buyuktoplam += item;
}

kucukortalama = kucuktoplam / 3;
buyukortalama = buyuktoplam / 3;
ortalamatoplam = kucukortalama + buyukortalama;

Console.WriteLine("Küçük sayıların ortalaması : "+ kucukortalama);
Console.WriteLine("Büyük sayıların ortalaması : "+ buyukortalama);
Console.WriteLine("İki ortalamanın toplamı : "+ ortalamatoplam);
