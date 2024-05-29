internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd")); //24
        Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
        Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

        Console.WriteLine(DateTime.Now.ToString("MM")); //05
        Console.WriteLine(DateTime.Now.ToString("MMM")); //May
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // Mayıs

        Console.WriteLine(DateTime.Now.ToString("yy")); //24
        Console.WriteLine(DateTime.Now.ToString("yyyy")); //2024

        //Math Kütüphanesi
        Console.WriteLine("*********Math Kütüphanesi*********");
        Console.WriteLine(Math.Abs(-25)); // Mutlak değer
        Console.WriteLine(Math.Sin(10)); // Sinüs hesabı
        Console.WriteLine(Math.Cos(10)); // Cos hesabı
        Console.WriteLine(Math.Tan(10)); // Tan hesabı

        Console.WriteLine(Math.Ceiling(22.3)); // 22.3 ten büyük en küçük tam sayıyı getirir (23)
        Console.WriteLine(Math.Round(22.3));  // En yakın sayıya yuvarlar
        Console.WriteLine(Math.Floor(22.7));  // 22.7 den küçük en büyük sayıyı getirir. (22)

        Console.WriteLine(Math.Max(2,6));
        Console.WriteLine(Math.Min(2,6));

        Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir. 81. üs alma işlemidir.
        Console.WriteLine(Math.Sqrt(9)); // Karekök işlemidir. 3
        Console.WriteLine(Math.Log(9)); // Logaritma işlemi. 9 un e tabanındaki logaritmik karşılığını verir.
        Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir.
        Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığını verir.



    }
}