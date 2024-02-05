// 1. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
    Console.WriteLine("Lütfen kaç tane sayı gireceğinizi yazınız.");

        int SayiAdeti = int.Parse(Console.ReadLine());
        int[] SayiDizisi = new int[SayiAdeti];
        
        for (int i = 0; i < SayiAdeti; i++)
        {
            Console.WriteLine("Lütfen {0}.Sayıyı giriniz", i+1);
            SayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int cift = 0;

        for (int i = 0; i < SayiAdeti; i++)
        {
            if(SayiDizisi[i] % 2 == 0)
            {
                cift++;
                Console.WriteLine(SayiDizisi[i] + " ");
            }

        }

// 2. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

     Console.WriteLine("Kaç adet pozitif sayı gireceğinizi yazınız.");
     int n = int.Parse(Console.ReadLine());
     int[] SayiDizisi = new int[n];
     
     for(int i=0; i<n; i++){

     Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i+1);
     SayiDizisi[i] = int.Parse(Console.ReadLine());

     }

     Console.WriteLine("Hangi sayıya eşit ya da tam bölünmesini istiyorsunuz?");
     int m = int.Parse(Console.ReadLine());

    for(int i=0; i<n; i++)
    {
        if(SayiDizisi[i] % m == 0)
        {
            Console.WriteLine(SayiDizisi[i]);
        }
    }


// 3. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

     Console.WriteLine("Lütfen kaç adet kelime gireceğinizi belirtiniz");
     int n = int.Parse(Console.ReadLine());
     string[] KelimeDizisi = new string[n];

     for (int i = 0; i < n; i++)
     {
        Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz.", i+1);
        KelimeDizisi[i] = Console.ReadLine();
     }
     Array.Reverse(KelimeDizisi);
     Console.WriteLine("Girmiş Olduğunuz Kelimelerin Ters Sıralanması: ");
     foreach (var kelime in KelimeDizisi)
     {
        Console.WriteLine(kelime);
     }



// 4. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


Console.WriteLine("Lütfen kelime ve harf sayısını öğrenmek istediğiniz cümleyi giriniz.");
string cumle = Console.ReadLine();

int harfsayisi = HarfSayisiBul(cumle);
int KelimeSayisi = KelimeSayisiBul(cumle);

Console.WriteLine($"Cümledeki kelime sayısı : {KelimeSayisi}");
Console.WriteLine($"Cümledeki harf sayısı : {harfsayisi}");


static int KelimeSayisiBul(string cumle)
{
    int KelimeSayisi = 0;
    bool KelimeBaslangici = true;

    foreach (char karakter in cumle)
    {
        if(char.IsWhiteSpace(karakter) || char.IsPunctuation(karakter) || char.IsSeparator(karakter))
        {
            KelimeBaslangici = true;
        }
        else if (KelimeBaslangici)
        {
           KelimeSayisi++;
           KelimeBaslangici = false;
        }
    }
  return KelimeSayisi;

}

static int HarfSayisiBul(string cumle)
{
    int harfsayisi = 0;

    foreach (char karakter in cumle)
    {
        if(char.IsLetter(karakter))
        {
            harfsayisi++;
        }
    }
    return harfsayisi;
}


