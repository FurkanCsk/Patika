internal class Program
{
    private static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
        string degisken2 = "CSharp";


        // Length; String değişkenin uzunluğunu kaç harften oluştuğunu gösterir.
        Console.WriteLine(degisken.Length);

        // ToUpper, ToLower; Değişkenin harflerini büyük harf ve küçük harfe çevirir.
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat; Değişkenle verilen ifadeyi birleştirir.
        Console.WriteLine(String.Concat(degisken," Merhaba "));

        //Compare, CompareTo

        Console.WriteLine(degisken.CompareTo(degisken2));   //CompareTo birinci değişken ikinci değişkenin harf sayısına göre değer alır.  -1,0,1 değerlerini alır.
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));   // Birinci değişken içinde ikinci değişkeni içeriyor mu
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));   // Değişken Hoşgeldiniz ifadesi ile bitiyor mu
        Console.WriteLine(degisken.StartsWith("Merhaba!"));     // Değişen Merhaba ifadesi ile başlıyor mu

        //IndexOf
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.LastIndexOf("i"));

        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba! "));

        //PadLeft, PadRight
        Console.WriteLine(degisken + degisken2.PadLeft(30));
        Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));

        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

        //Remove
        Console.WriteLine(degisken.Remove(10));   //10.indexten sonrasını siler
        Console.WriteLine(degisken.Remove(5,3));  // 5.indexten sonra 3 index siler
        Console.WriteLine(degisken.Remove(0,1));  // İlk harfi siler.

        //Replace
        Console.WriteLine(degisken.Replace("Csharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);

        //SubString
        Console.WriteLine(degisken.Substring(4));  //4.indexten sonrasını getirir.
        Console.WriteLine(degisken.Substring(4,6)); // 4.indexten başlayarak 6 karakter getirir.
    }
}