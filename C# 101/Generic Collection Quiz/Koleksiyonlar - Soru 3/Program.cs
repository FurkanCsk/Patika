// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

char[] sesliharf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };        // Sesli harflerden bir dizi oluşturuyoruz.

Console.WriteLine("Lütfen bir cümle giriniz");
string cumle = Console.ReadLine().ToLower();                       // Kullanıcıdan cümleyi alıyoruz.

List<char> eslesenUnluler = new List<char>();           // Eşleşen sesli harfler için bir liste oluşturuyoruz

foreach (char karakter in cumle)
{
    if (Array.Exists(sesliharf, unlu => unlu == karakter) && !eslesenUnluler.Contains(karakter))                          // Burada eşleşen harfleri bulup daha önce eklenmediyse listemize ekliyoruz.
    {
        eslesenUnluler.Add(karakter);
    }

}

if (eslesenUnluler.Count > 0)
{
    Console.WriteLine("Cümlenizde bulunan sesli harfler : ");
    foreach (var item in eslesenUnluler)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Cümlenizde eşleşen herhangi bir sesli harf yok");
}
