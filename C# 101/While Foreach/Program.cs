﻿using System.Collections.ObjectModel;
using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        //While
        // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
        Console.WriteLine("Lütfen bir sayı giriniz.");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }

        Console.WriteLine(toplam/sayi);

        //  'a' dan 'z' ye kadar tüm harfleri console a yazdır.

        char character = 'a';
        while(character <= 'z')
        {
           Console.Write(character);
           character ++;
        } 
        
        
        // *******Foreach********
        string[] arabalar = {"BMW","Ford","Toyota","Peugeot"};
        foreach(var araba in arabalar)
        {
           Console.WriteLine(araba);
        }
    }
}