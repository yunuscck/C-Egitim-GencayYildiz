using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Egitim
{
    internal class AlgoritmaSorulari
    {
        static void main(string[] args)
        {
            #region Ornek 1
            // 2 sayının toplamını veren prog

            // Cozum1
            //int a = 20;
            //int b = 10;
            //int toplam = a + b;
            //Console.WriteLine(toplam);

            // Cozum2
            //int a2 = 20, b2 = 10, toplam2 = a2 + b2;
            //Console.WriteLine(toplam2); // Console.WriteLine(a2+b2);

            // Cozum3
            // Kullanıcının girdigi deger ile 
            //try
            //{
            //    Console.WriteLine("1.sayiyi giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2.sayiyi giriniz");
            //    int sayi2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(sayi2 + sayi1);

            //}
            //catch 
            //{
            //    Console.WriteLine("lütfen dogru bi sayı girin");
            //}
            #endregion

            #region Ornek 2
            //try
            //{
            //    // Cozum1
            //    //Console.WriteLine("1.sayiyi giriniz");
            //    //int sayi1 = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("2.sayiyi giriniz");
            //    //int sayi2 = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("2 sayının kareleri toplamı : " + (sayi1 * sayi1) + (sayi2 * sayi2)); 

            //    // Cozum2
            //    //double k1 = Math.Sqrt(sayi1);
            //    //double k2 = Math.Sqrt(sayi2);
            //    //Console.WriteLine("2 sayının Math fonk ile karelerinin toplamı : " + (k1 + k2));

            //    //double sonuc = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);
            //    //Console.WriteLine("sonuc : " + Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2));

            //    // Cozum4
            //    Console.WriteLine("1. ve 2. sayiyi giriniz...");
            //    Console.WriteLine("Sonuc = " + (Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2)));
            //}
            //catch
            //{
            //    Console.WriteLine("dogru sayı giriniz");
            //}
            #endregion

            #region Ornek 3
            // 1'den 10'a kadar olan sayilarin küplerinin toplamını bulan prog
            //double top = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(Math.Pow(i,3));
            //    top += Math.Pow(i,3);
            //}
            //Console.WriteLine("toplam : " + top);

            // Cozum2
            //double top = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //    top += Math.Pow(i, 3);
            //    i++;
            //}
            //Console.WriteLine("toplam : " + top);

            // Cozum3
            //double top = 0;
            //int i = 1;
            //do
            //{
            //    top += Math.Pow(i, 3);
            //    i++;
            //}
            //while (i <= 10);
            //Console.WriteLine(top);

            // Gorsel Anlatımla Cozum - 1
            //double top = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"{i}'nin kübü : " + Math.Pow(i, 3));
            //    top += Math.Pow(i, 3);
            //    i++;
            //}
            //Console.WriteLine("toplam : " + top);

            // Gorsel Anlatımla Cozum - 2
            //double top = 0;
            //int i = 1;
            //string sonuc = "";
            //while (i <= 10)
            //{
            //    top += Math.Pow(i, 3);
            //    if (i != 10)
            //        sonuc += $"{i}³ + ";
            //    else
            //        sonuc += $"{i} ³ = {top}";
            //    i++;
            //}
            //Console.WriteLine(sonuc);



            #endregion

            #region Ornek 4 
            // Dogum tarihi girilen kisinin Yasını hesaplayan prog

            // Cozum1
            //Console.WriteLine("Dogum tarihinizi giriniz");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //TimeSpan sonuc = DateTime.Now - dogumTarihi;
            //Console.WriteLine("dogum tarihi : " + (sonuc.Days / 365));

            // Cozum2
            //Console.WriteLine("Dogum tarihinizi giriniz");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //DateTime bugun = DateTime.Now;
            //int yas = bugun.Year - dogumTarihi.Year;
            //if (dogumTarihi > bugun.AddYears(-yas))
            //    yas--;
            //Console.WriteLine(yas);

            // Cozum3        
            //Console.WriteLine("Dogum tarihinizi giriniz");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //int gun = (DateTime.Now - dogumTarihi).Days;
            //int yas = gun / 365;
            //int kalan = gun % 365; // bir sonraki yasına kac gün var hesaplar
            //Console.WriteLine($"Yas : {yas} | {yas + 1} yasiniza kalan gun : {365 + (yas * 1 / 4) - kalan}");
            #endregion

            #region Ornek 5
            // Girilen sayinin faktoriyelini hesaplayan prog

            // FOR
            //Console.WriteLine("sayiyi girin...");
            //int sayi = int.Parse(Console.ReadLine());
            //int top = 1;
            //for (int i = sayi; i > 0; i--)
            //{
            //    top *= i;
            //}
            //Console.WriteLine("! - fak : " + top);

            // While
            //Console.WriteLine("sayiyi girin...");
            //int sayi = int.Parse(Console.ReadLine());
            //int top = 1;
            //while (sayi > 0)
            //{
            //    top*= sayi;
            //    sayi--;
            //}
            //Console.WriteLine(top);

            // Do-While
            //Console.WriteLine("sayiyi girin...");
            //int sayi = int.Parse(Console.ReadLine()), top = 1;
            //do
            //{
            //    top *= sayi;
            //    sayi--;
            //} while (sayi>0);
            //Console.WriteLine("sonuc : " + top);

            // Gorsel anlatım ile cozum
            //Console.WriteLine("sayiyi girin...");
            //int sayi = int.Parse(Console.ReadLine()), top = 1;
            //string sonuc = "";
            //while (sayi > 0)
            //{
            //    top *= sayi;

            //    if (sayi != 1)
            //        sonuc += $"{sayi} x ";
            //    else
            //        sonuc += $"{sayi} = {top}";
            //    sayi--;

            //}
            //Console.WriteLine(sonuc);

            // Recursive Ozellıgı ile 
            //Console.WriteLine("sayi girin...");
            //int sayi = int.Parse(Console.ReadLine());
            //Console.WriteLine(Faktoriyel(sayi));
            // Recursive metot
            //static int Faktoriyel(int sayi)
            //{
            //    if (sayi > 1)
            //        return sayi * Faktoriyel(--sayi);
            //    return sayi;
            //}

            #endregion

            #region Ornek 6
            // Pozitif sayılarda carpma islemini toplama kullanarak bulan uygulama

            // Cozum1
            //Console.WriteLine("1.sayiyi girin...");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayiyi girin...");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int carpmaSonucu = 0;
            //if (sayi1 > 0 && sayi2 > 0)
            //{
            //    for (int i = 0; i < sayi1; i++)
            //    {
            //        carpmaSonucu += sayi2;
            //    }

            //}
            //Console.WriteLine($"{sayi1} x {sayi2} = {carpmaSonucu}");

            // Cozum2
            //Console.WriteLine("1.sayiyi girin...");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayiyi girin...");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int carpmaSonucu = 0;
            //int sayac = sayi2;
            //while (sayac > 0)
            //{
            //    carpmaSonucu += sayi1;
            //    sayac--;
            //}
            //Console.WriteLine($"{sayi1} x {sayi2} = {carpmaSonucu}");

            // Cozum3
            //Console.WriteLine("1.sayiyi girin...");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayiyi girin...");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int carpmaSonucu = 0;
            //int sayac = sayi2;
            //do
            //{
            //    carpmaSonucu += sayi1;
            //    sayac--;
            //} while (sayac > 0);
            //Console.WriteLine($"{sayi1} x {sayi2} = {carpmaSonucu}");

            // Cozum4
            //Console.WriteLine("1.sayiyi girin...");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayiyi girin...");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Topla(sayi1, sayi2));

            //static int Topla(int sayi1, int sayi2)
            //{
            //    if (sayi2 > 1)
            //        return sayi1 + Topla(sayi1, --sayi2);
            //    return sayi1;
            //}

            #endregion

            #region Ornek 7
            // Pozitif sayilarda bolme islemini cıkarma kullanarak yapan uygulama

            // Cozum1
            //Console.WriteLine("Lutfen bolmek istediginiz sayiyi girin..");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lutfen bolen sayiyi girin..");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int _sayi1 = sayi1;

            //int sonuc = 0;
            //int kalan = 0;
            //for (int i = 0; i < _sayi1; i++)
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;

            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc}   |   Kalan : {kalan}");

            // Cozum2
            //Console.WriteLine("Lutfen bolmek istediginiz sayiyi girin..");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lutfen bolen sayiyi girin..");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int _sayi1 = sayi1;
            //int sonuc = 0;
            //int kalan = 0;
            //while (true)
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;
            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }
            //}
            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc}   |   kalan : {kalan}");

            // Cozum3
            //Console.WriteLine("Lutfen bolmek istediginiz sayiyi girin..");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lutfen bolen sayiyi girin..");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int _sayi1 = sayi1;
            //int sonuc = 0;
            //int kalan = 0;
            //do
            //{
            //    sayi1 -= sayi2;
            //    sonuc++;
            //    if (sayi1 < sayi2)
            //    {
            //        kalan = sayi1;
            //        break;
            //    }
            //} while (true);
            //Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc}   |   kalan : {kalan}");

            // Cozum4
            //Console.WriteLine("Lutfen bolmek istediginiz sayiyi girin..");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lutfen bolen sayiyi girin..");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{sayi1} / {sayi2} = {Bol(sayi1, sayi2)}  |  kalan : {Kalan(sayi1, sayi2)}");

            //static int Bol(int sayi1, int sayi2)
            //{
            //    sayi1 -= sayi2;
            //    if (sayi1 >= sayi2)
            //        return 1 + Bol(sayi1, sayi2);
            //    return 1;
            //}
            //static int Kalan(int sayi1, int sayi2)
            //{
            //    sayi1 -= sayi2;
            //    if (sayi1 >= sayi2)
            //        return Kalan(sayi1, sayi2);
            //    return sayi1;
            //}

            #endregion

            #region Ornek 8
            // Girilen pozitif sayının kac basamaklı oldugunu soyleyen uygulamayı yazınız

            // Kendi Cozumum
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //int sayi= int.Parse(Console.ReadLine());
            //string a = sayi.ToString();
            //Console.WriteLine($"girilen sayı {a.Length} basamaklı");

            // Cozum1
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //float sayi = float.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (; sayi >= 10;)
            //{
            //    sayi /= 10;
            //    sayac++;
            //}
            //sayac++;
            //Console.WriteLine($"{sayi} sayısının basamak degeri {sayac}");

            // Cozum2
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //int sayi = int.Parse(Console.ReadLine());
            //int _sayi = sayi;
            //int sonuc = 0;
            //for (; ; )
            //{
            //    sayi /= 10;
            //    sonuc++;
            //    if (sayi < 10)
            //        break;
            //}
            //sonuc++;
            //Console.WriteLine($"{_sayi} sayısının basamak degeri {sonuc}");

            // Cozum3
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //int sayi = int.Parse(Console.ReadLine());
            //int _sayi = sayi;
            //int sonuc = 0; // 1'den baslarsa asagıda sonuc++ yapmak zorunda olmayız
            //while (true)
            //{
            //    sayi /= 10;
            //    sonuc++;
            //    if (sayi < 10)
            //        break;
            //}
            //sonuc++; // 1'den baslarsa asagıda sonuc++ yapmak zorunda olmayız
            //Console.WriteLine($"{_sayi} sayısının basamak degeri {sonuc}");

            // Cozum4
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //int sayi = int.Parse(Console.ReadLine());
            //int _sayi = sayi;
            //int sonuc = 0; // 1'den baslarsa asagıda sonuc++ yapmak zorunda olmayız
            //while (sayi >= 10)
            //{
            //    sayi /= 10;
            //    sonuc++;
            //}
            //sonuc++; // 1'den baslarsa asagıda sonuc++ yapmak zorunda olmayız
            //Console.WriteLine($"{_sayi} sayısının basamak degeri {sonuc}");

            // Cozum5
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //int sayi = int.Parse(Console.ReadLine());
            //int _sayi = sayi;
            //int sonuc = 0; // 1'den baslarsa asagıda sonuc++ yapmak zorunda olmayız
            //do
            //{
            //    sayi /= 10;
            //    sonuc++;
            //} while (sayi >= 10);
            //Console.WriteLine($"{_sayi} sayısının basamak degeri {++sonuc}'tür.");

            // Cozum6
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = Basamak(sayi);
            //Console.WriteLine($"{sayi} sayısının basamak degeri {sonuc}");
            //static int Basamak(int sayi)
            //{
            //    sayi /= 10;
            //    if (sayi > 10)
            //        return 1 + Basamak(sayi);
            //    return 2;
            //}





            #endregion

            #region Ornek 9
            // Kendi Cozumum
            //Console.WriteLine("lutfen bir sayi giriniz...");
            //string sayi = Console.ReadLine();
            //int _sayi = 0;
            //double top = 0;
            //if (sayi.Length == 3)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        _sayi = Convert.ToInt32(sayi[i].ToString());
            //        top += Math.Pow(_sayi, 3);
            //    }
            //    if (top == int.Parse(sayi))
            //        Console.WriteLine($"{sayi} sayısının basamaklarının küpleri toplamı sayının kendisine esittir.. {sayi} = {top}");
            //    else
            //        Console.WriteLine($"{top} esit degil {sayi}'e");
            //}
            //else
            //{
            //    Console.WriteLine("Lutfen 3 haneli bir sayi girin");
            //}

            // Cozum1
            //Console.WriteLine("lütfen bir sayi girin");
            //int sayi = int.Parse(Console.ReadLine());
            //// bool durum = Basamak(sayi);
            //if (Basamak(sayi)) // if (durum)
            //{
            //    int _sayi = sayi;
            //    double kupToplam = 0;
            //    while (true)
            //    {
            //        int basamak = _sayi % 10;
            //        _sayi /= 10;

            //        kupToplam += Math.Pow(basamak, 3);
            //        if (_sayi < 10)
            //        {
            //            basamak = _sayi % 10;
            //            kupToplam += Math.Pow(basamak, 3);
            //            break;
            //        }
            //    }
            //    if (kupToplam == sayi)
            //        Console.WriteLine("esittir");
            //    else
            //        Console.WriteLine("esit degildir");
            //}
            //else
            //{
            //    Console.WriteLine("lutfn sadece 3 basamaklı sayı girin");
            //}

            //static bool Basamak(int sayi)
            //{
            //    // while (sayi >= 10)
            //    int basamakSayisi = 1;
            //    while (true)
            //    {
            //        basamakSayisi++;
            //        sayi /= 10;
            //        if (sayi < 10)
            //            break;
            //    }
            //    //if (basamakSayisi == 3)
            //    //    return true;
            //    //return false;
            //    return basamakSayisi == 3 ? true : false;
            //}
            #endregion

        }







    }






}

