using System;

namespace C__Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DİZİLERDE VERİSEL PERFORMANS NEDİR
            // bir dizi aralıgında calısmak istedigimizde o aralık yeni dizi olarak atanır ve bellekte yeni bir alan tutarak maliyete sebep olur
            //int[] dizi = new int[9] { 0, 5, 4, 7, 8, 9, 6, 3, 2 };
            //int[] dizi2 = dizi[2..6];

            #region ArraySegment 
            // Bir dizinin bütününden ziyade belirli bir kısmına yahut parcasına ihtiyac dahilinde ilgili diziyi kopyalamak yerine (ki gorece oldukca maliyetli bir operasyondur)
            // --bagımsız bir referans ile erişmemizi ve boylece salt bir sekilde temsil etmemizi saglayan bir yapıdır.
            #endregion

            #region ArraySegment İle Dizinin Belli Bir Alanını Referans Etmek
            //ArraySegment<int> segment1 = new ArraySegment<int>(dizi); // dizinin tüm elemanlarını temsil eder
            //ArraySegment<int> segment2 = new ArraySegment<int>(dizi, 2, 5); // 2.indexten, 5.adede kadar olan aralıgı tut

            // referansları aynı oldugu icin  yapılan degisiklikler birbirini etkiler
            //segment1[0] *= 10;
            //segment2[0] *= 10;

            #endregion

            #region ArraySegment Slicing(Dilimleme) Ozelligi
            // Bir dizi uzrınde bırden fazla parca uzerınde calısılacaksa eger herbır parcayı ayrı bır ArraySegment olarak tanımlayabiliriz
            // Bu tanımlamların dısında diziyi tek bir arraysegment ile referans edip ilgili parcaları o segment uzerınden talep edebilriz. Yani ilgili diziyi
            // --tek bir segment uzerınden daha rahat bir sekilde parcalayabiliriz. Bu durumda bize yazılımsal acıdan efektiflik kazandırmıs olacaktır.

            //ArraySegment<int> segment = new ArraySegment<int>(dizi);
            //ArraySegment<int> segment1 = segment.Slice(0, 3);
            //ArraySegment<int> segment2 = segment.Slice(3, 5);
            //ArraySegment<int> segment3 = segment.Slice(2, 6);

            #endregion

            #region StringSegment Nedir
            // ArraySegment'in string degerler nezdindeki bir muadilidir.
            // Esasında metınsel degerlerdeki bircok analitik opersayonlardan bizleri kurtarmakta ve Substring vs. gibi
            // --fonksiyonlar yerine string degerde hedefe kesit uzerınde ıslem yapmamızı saglayan bir turdur.
            // string text = "Ölümle gidelim dedin de mazot mu yok dedik.";

            #region StringSegment ile Dizinin Belli Bir Alanını Referans Etmek
            // StringSegment turunu kullanabilmek ıcın uygulamaya Microsoft.Extensions.Primitives paketinin yüklenmesi gerekmektedir.
            //StringSegment textSegment = new StringSegment(text);
            //StringSegment textSegment2 = new StringSegment(text, 3, 5);
            //Console.WriteLine(textSegment2);

            #endregion

            #region StringBuilder Sınıfı
            // String birlestırme operasyonlarında + operatorunue nazaran arkaplanda yuksek maliyeti absorbe edebilmek icin
            // --stringsegment algoritmasını kullanan ve bu algoritma ile bizlere ilgili degerleri olabilecek en az maliyetle birlestirip donduren bir sınıftır.
            //string isim = "Yunus";
            //string soyisim = "Cicek";

            //StringBuilder builder = new StringBuilder();
            //builder.Append(isim);
            //builder.Append(" ");
            //builder.Append(soyisim);

            //Console.WriteLine(builder.ToString());

            #endregion

            #endregion

            #endregion

            #region SPAN, ReadyOnlySpan, MEMORY ve ReadOnlyMemory TURLERİ
            //SPAN
            //int[] sayilar = {10,20,30,40,50,60,70,80,90,100};
            //Span<int> span = new Span<int>(sayilar);
            //Span<int> span2 = sayilar;
            //Span<int> span3 = new Span<int>(sayilar, 3, 5); // 3.indexten basla 5 tane deger al

            //Span<int> sapn4 = sayilar.AsSpan();
            //Span<int> sapn5 = sayilar.AsSpan(3, 5);

            //string text = "Sen kalbimde batan güneş, ben yollarda çilekeş";
            //ReadOnlySpan<char> readOnlySpan = text.AsSpan();
            //ReadOnlySpan<char> span6 = text;

            #endregion

            #region REGULAR EXPRESSIONS (DUZENLİ İFADELER)
            // ^ operatoru :





            #endregion

            #region KOLEKSİYONLAR
            // Dizilerin aynısı fakat programlamada daha kolaylık saglar. dizilere göre daha maliyetlidir ama kolaylığı bunu dengeler.
            #region ArrayList
            // Diziler tanımlanırken kac eleman tutacakları bildirilmek zorundadır.

            // --- Tanımlama ---
            //int[] yaslar = new int[17]; // dizi
            //ArrayList _yaslar = new ArrayList(); // koleksiyon arraylist

            // --- Deger Atama ---
            //yaslar[5] = 123; // dizi
            //_yaslar.Add(123); // index muhabbeti olmadıgı ıcın direk eleman add fonk ile eklenebilir
            // -------------------------
            //for (int i = 0; i < 17; i++)
            //{
            //    yaslar[i] = i + 10;
            //    _yaslar.Add(i + 10);
            //}

            // --- Tanımlanmıs Koleksiyondan Deger Okuma ---
            // Diziler
            //Console.WriteLine(yaslar[5]);
            // Koleksiyonlar
            //Console.WriteLine(_yaslar[5]);

            #region ArrayList Boxing - Unboxing Durumları
            // ArrayList, verilen datayı boxing islemine tabi tutar.
            // ArrayList icerisindeki herhangi bir veriyi talep ettğimizde, o veri object olarak gelecektir.
            // --Dolayısıyla kendi turunde islem yapabilmek icin unboxing yapmamız gerekecektir.

            //int top = 0;
            //for (int i = 0; i < _yaslar.Count; i++) // count koleksiyonlarda eleman sayısı verir. dizilerde lenght idi.
            //{
            //    top += (int)_yaslar[i]; // (int) cast operatoru ile int'e cevirme
            //}

            #endregion

            #region ArrayList Collection Initializers (Koleksiyon İlklendirici) ile Deger Ekleme
            //ArrayList arrayList = new ArrayList() { "ahmet", 123, 'a', true }; // koleksiyonlar object turunde calıstıgı ıcın tum turlerde deger tutabilirler.

            // --Boyle bir durumda matematiksel islem yapılacagı zaman kontol mekanizması eklenmeli koda
            //int top = 0;
            //for (int i = 0; i < arrayList.Count; i++) 
            //{
            //    if (arrayList[i] is int) // arrayList'in i.indexi int ise sartı 
            //    {
            //        top += (int)arrayList[i];
            //    }
            //}

            #endregion

            #endregion

            #endregion

            #region ITERASYON (Foreach İterasyonu)
            // Mantıksal acıdan her tahminin altında bir iterasyon mantigi vardir.

            #region İterasyon vs Döngü
            //    Console.WriteLine(sayilar[i]);
            // !!! -  Foreach(İterasyon) BİR DÖNGÜ DEGİLDİR  - !!!

            //int[] sayilar= {1,2,3,4,5,6,7,8};

            //for (int i = 0; i < sayilar.Length; i++)   // donguler belli bir kominasyona baglıdır. kombinasyon bitene kadar islem yapar.
            //{
            //}

            //foreach (int item in sayilar) // foreach dizinin eleman sayısı kadar islem yapar
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Foreach İterasyonu

            //ArrayList sayilar = new ArrayList { 12, 23, 34, 45, 56, 67, 78, 87 };
            //foreach(object item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            // foreach calısırken sayilar dizisinde degisklik vs yapılamaz.
            // foreach kullanılırken kaynak degistirelemez bu yapılacaksa dongulerle calısmak tavsiye edilir.
            //foreach (object item in sayilar)
            //{
            //    sayilar.Add(123);
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region C#'da HAZIR SINIFLAR ve FONKSİYONLAR

            #region Math
            //Math.
            #region Abs
            // Mutlak deger islemi yapan fonk
            // Absolute Value
            //int i = Math.Abs(-5);
            #endregion

            #region Ceiling
            // yukarıya dogru yuvarlama islemi yapar.
            //Console.WriteLine(Math.Ceiling(3.14)); // normalde yakın tarafa yuvarlama yapılır ama bu fonk'da yukarı dogru yani 3.14 => 4 
            #endregion

            #region Floor
            // asagıya dogru yuvarlama islemi yapar.
            //Console.WriteLine(Math.Floor(3.14)); // 3.14 => 3
            #endregion

            #region Round
            // kendisine en yakın tam sayıya yuvarlar
            //Console.WriteLine(Math.Round(3.14)); // 3'e yuvarlar
            //Console.WriteLine(Math.Round(3.5)); // 4'e yuvarlar
            //Console.WriteLine(Math.Round(3.65)); // 4'e yuvarlar
            #endregion

            #region Pow
            // elimizdeki degerin üssünü alır örn 3'ün 7.kuvveti gibi
            //Console.WriteLine(Math.Pow(3,7)); // virgülden önceki taban sonraki üssü olarak alır
            #endregion

            #region Sqrt
            // elimizdeki degerlerin 2.dereceden kökünü alır yani karekökünü alır
            //Console.WriteLine(Math.Sqrt(4));  // 2
            //Console.WriteLine(Math.Sqrt(16)); // 4
            //Console.WriteLine(Math.Sqrt(55)); // 7,416198487095663
            #endregion

            #region Truncate
            // Elimizdeki ondalık degerin tam sayı olan kısmın almamızı saglar
            //Console.WriteLine(Math.Truncate(3.14)); // 0.14'lük kısmı atıp 3 degerini dondurecektır
            #endregion

            #endregion

            #region DateTime Struct'ı
            // Now
            //Console.WriteLine(DateTime.Now); // o anki tarih ve zamanı gosterir

            // Today
            //Console.WriteLine(DateTime.Today); // o anki sadece tarihi gosterir

            // Compare (2 tarihi karsılastırma)
            //DateTime tarih1 = new DateTime(2021, 01, 02);
            //DateTime tarih2 = new DateTime(2022, 02, 01);
            //int result = DateTime.Compare(tarih1,tarih2);
            //if (result<0)
            //{
            //    Console.WriteLine($"{tarih1} kücüktür {tarih2}");
            //}
            //else if (result==0)
            //{
            //    Console.WriteLine($"{tarih1} esittir {tarih2}");
            //}
            //else if (result>1)
            //{
            //    Console.WriteLine($"{tarih1} buyukyur {tarih2}");
            //}

            // AddDays / AddHours / AddMonths / AddYears / AddMiliseconds
            //Console.WriteLine(DateTime.Now.AddDays(999));
            //Console.WriteLine(DateTime.Now.AddHours(999));
            //Console.WriteLine(DateTime.Now.AddMonths(999));
            //Console.WriteLine(DateTime.Now.AddYears(999));
            //Console.WriteLine(DateTime.Now.AddMinutes(999));
            //Console.WriteLine(DateTime.Now.AddSeconds(999));
            //Console.WriteLine(DateTime.Now.AddMilliseconds(999));

            #endregion

            #region TimeSpan Struct'ı
            // iki datetime arası farkı alır
            //DateTime t1 = DateTime.Now;
            //DateTime t2 = new DateTime(2000, 1, 1);
            //TimeSpan span = t1 - t2;
            //Console.WriteLine(span.Days);
            //Console.WriteLine(span.Minutes);

            #endregion

            #region Random Sınıfı
            //Random random = new Random();
            // NEXT Fonksiyonu
            // Belirli bir deger aralıgında rastgele sayı tutmak istenirse kullanılır. Negatif bi sonuc elde etmek istenilirse eger sonuc -1 ile carpılabilir.
            //Console.WriteLine(random.Next()); // 0 - ..... // int deger aralıgında 0'dan buyuk herhangı bır sayı tutar
            //Console.WriteLine(random.Next(100)); // 0 - 100
            //Console.WriteLine(random.Next(50,100)); // 50 - 100

            // NEXTDOUBLE Fonksiyonu
            // 0 ile 1 arasında rastgele bir sayi üretir.
            //while (true) // sonsuz dongude 0 - 1 arasında rastgele degerler atayacak
            //{
            //    Console.WriteLine(random.NextDouble());
            //}

            #endregion

            #endregion

            #region METOTLAR
            // Yazılımda gerceklestirdigimiz, fiili olarak gerceklestirdigimiz tum operasyonlar bir metottur. 
            // Metot Prosedürel programlamanin temel elemanidir
            // Bir is/fiiliyat/operasyon yapan en kucuk program parcaciklaridir.
            // Property ozunde, compiler seviyesinde bir metotdur.
            // Kod icindeki tekrar eden kodlardan kurtulmamızı saglar

            // [Erisim Belirleyicileri] [Geri Donus Degeri] [Metot Adi] (.....)
            // {
            //      .............
            // }
            //      Seklinde tanımlanır

            // -- Erisim Belirleyicileri -- ileride gorecegimiz Access Modifier yapılaridir. 
            // Olusturulmus olan bir yapının disaridan erisilip erisilmeyecegini belirlememizi saglayan komutlardir.
            // public - dısardan erisim var
            // private - gizli/erisilemez

            //  -- Geriye Donus Degeri -- Metotlar yaptıkları operasyonlar/algoritmalar/islemler neticesinde geriye degerler donebilmektedir.
            // Bu deger kodun icerisinde yakalanabilir ve programatik olarak islemlere tabii tutulabilir. Geri donus degerini ekran ciktisiyla karistirmamak gerekmektedir.

            // -- ( ) -- Metot dedigimiz bu yapılanmalar dis dunyadan parametreler alabilmekte ve bu parametrelerdeki degerler üzreinde islemler gerceklestirebilmektedir.
            // İste bu parametreleri parantez icerisinden alabilmekteyiz. Bir metot parametre almak zorunda degildir. (int sayi1) - (int sayi1, int sayi2) { islemler }

            // Yapılacak islemlere göre 4 farklı turde/varyasyonda metot uyguluyabiliriz.
            // 1 - Geriye Deger Dondurmeyen, Parametre Almayan
            // 2 - Geriye Deger Dondurmeyen, Parametre Alan
            // 3 - Geriye Deger Donduren, Parametre Almayan
            // 4 - Geriye Deger Donduren, Parametre Alan

            #region Metodun Geriye Deger Dondurmesi Ne Demektir?
            // Metodun geriye dondurdugu deger algoritmanin akisinda kullanılabilen degerlerdir.
            //int sonuc = Topla(3,5);
            //if (sonuc>10)
            //{
            //    Console.WriteLine("sonuc 10'dan buyuktur");
            //}

            //bool sonuc = PersonelEkle("yunus","cicek",27);
            //if (sonuc==true)
            //{
            //}
            //else
            //{
            //}

            #endregion

            #region Optional Parameters (İstege Bagli Parametreler)
            // Parametreli bir metot cagırılırken parametrelerin turlerıne uygun degerler gonderilmek zorunludur.
            // Eger ki bir metodun parametrelerine zorunlu bir sekilde deger gondermek istemiyorsak parametreye degeri istegimize göre ya da opsiyonel olarak gondermek istiyorsak
            // --o parmaetrenin  bu durumu karsılayabilecek bir ozellikte olması gerekir. Buna da Opsiyonel Parametre denir.

            //X(6); // main dısında tanımlanan X metodunda b/c degiskeni belirlendigi icin opsiyoneldir artık deger girmesek de olur.
            // Opsiyonellere metodu cagırdıktan sonra istersek yeni deger gonderebilirz
            // Birden fazla parametre durumunda opsiyonel olanlar sag tarafta TANIMLANMALI !!!
            #endregion

            #region Tanımlanmış Metodun Kullanımı
            // Tetikleme = Çagirma = Kullanım
            #region Tanımlandıgı Sınıf İcerisinde Kullanimi
            // Bir metot tanımlandıgı sınıf icerisndeki farklı bir metot icerisnde cagırılacaksa eger tek yapılması gereken sadece isminin cagrılmasıdır
            //X();
            #endregion

            #region Baska Siniflarda Kullanimi
            #region Referans ve Nesne İliskisine Hafiften Temas Edelim
            // Sınıf (Class) = Yeryüzündeki herhangi bir olguyu modellememizi saglayan yapılanmadır.
            // İcerisinde ilgili olguya dair verileri tutacak alanları(field) barındıran ve bu alanlar üzerinde islem yapmamızı saglayacak olan metotları barındıran bir yapıdır

            // Nesne = Class'tan üretilen deger/veri.!!
            //Referans = Class'tan üretilen degeri kullanmamizi saglayan yapi.!!
            //Ornek a = new Ornek();
            // referans      nesne
            #endregion

            //Matematik matematik = new Matematik();
            //int sonuc = matematik.Cikar(5, 6);

            #endregion
            #endregion

            #region Non-Trailing Named Arguments
            //X1(3, 5, "yunus"); // normalde sırayla deger atanmalı bu sekilde
            //X1(c: "sdf", a: 6, b: 3); // ama bu sekilde direkt hedef bazlı isim bazlı atama da yapılabilir
            // bu islemi tum parametreler icin kullanın yoksa karısıklık yasatır

            // Hangi parametreye hangi degerlerin gönderildigini direkt gorebilmek icin bu ozelliği kullanırız?
            // Göreceli bir seiklde cok parametreli fonk'larda hedef parametrelere deger gondermemizi saglayan bir ozelliktir.

            #endregion

            /* About before In-Parameters 
            // 1 - Parametrenin degerini metodun icerisinde herhangi bir yerde cagırıp kullanabiliriz
            // 2 - Metot icerisinde üretilen herhangi bir degeri tutacak degisken olusturmaktansa parametre üzerinde bu degeri
            // --tutabiliriz. Yani parametrenin degerini degistirebiliriz.(Cünkü parametreler ozunde bir degiskendir) */
            #region In Parameters
            // In komutu sayesinde parametreye verilen degeri sabit tutabilmekteyiz.
            // In komutu metodun parametresını readonly(sadece okunabilir) hale getirir.
            // In komutunun kullanıldıgı parametrelerde eger ki metot icersinde farklı bir assign söz konusu olursa derleyici hata verir.
            #endregion

            #region Local Functions
            // Bir metot icerisinde tanımlanmıs olan metotlardır.
            // C#'da metotlar sadece ve sadece class icersinde tanımlanır demistik fakat OOP'de gorecegimiz struct, abstract class,
            // --interface, record yapılanmalarında da metotlar tanımlanmaktadır. Metotlar bu saydıklarımızın dısında kesinlikle baska bir yerde tanımlanamaz!!
            // Metotlar, C# 7.0'da gelen Local Function ozelligi ile metot icerisnde de tanımlayabiliriz.
            #region Tanımlama Kuralları
            // 1 - Erisim belirleyicisi (Access Modifier) yazılmaz
            // 2 - Local Function olarak tanımlanan fonksiyon adı, tanımlandıgı fonksiyonun adından farklı olmalıdır! aksi takdirde derleyici hatası VERMEZ !!!
            #endregion
            #region Kullanım Kuralları
            // 1 - Bir Local Function sadece tanımlandıgı metot icerisnde kullanılabilir
            // 2 - Local Functionlar tanımlandıgı metot icerisinde her yerden erişebilir. Degiskenlerin aksine tanımlandıktan sonra veya onceki satırlarda cagrılabilir, kullanılabilir.
            // 3 - 
            #endregion
            #region Amacı
            // Bir metot sadece tek bir metotda tekrarlı bir sekilde kullanılacak algoritmayı/kod parcacığını/islemi o metotda ozel bir sekilde tek seferlik tanımlamamızı ve kullanmamızı saglamaktadır.
            #endregion
            #region Muadilleri
            // Anonim, Delegate, Func
            #endregion
            #region Static Local Functions (Metot İcerisinde Tanımlanabilir Statik Yerel Metotlar)
            //
            #endregion


            #endregion

            #region Method Overloading (Coklu Yukleme)
            // Bir sınıfın icerisinde birden fazla aynı isimde metot tanımlanamaz. Belirli kuralları uygulandıgı taktirde tanımlanabilir ancak
            // Bir Class'ta birden fazla metot tanımlanmıssa eger(belirli kurallar cercevesinde) o isime overloading yapılmıstır.

            // Bir Class icerisinde belirli kurallar cervcevesinde aynı isimde birden fazla metot olusturmaya Method Overloading denir.

            #region Overloading Kuralları
            // Method Overloading islemini yapabilmek icin metotların isimleri aynı olmalıdır.
            // Bu metotlar icerisinde fark yaratmamız gerekmektedir.
            // Bu fark bizzat metot imzalarında olmalıdır.
            // Metotlar arasında farkı yaratırken erişim berlirleyicileri ve geri donus degerleri aktif rol oynamaz,
            // --parametre sayıları veya turler farklı OLMALIDIR.
            #endregion
            // Overloading islemine tabii tutulmus metotlardan istedigimizi kullananbilmek icin o metodun imzasına uygun parametreleri tetiklememiz
            // --Ya da bir baska deyişle o imzadaki metodu kullanmamız yeterli olacaktır. 
            //Matematik2 matematik2 = new Matematik2();
            //matematik2.Topla(3, 4, 5);
            //matematik2.Topla(2, 3);
            //matematik2.Topla(13, (double)4); // dogrudan double olan metota yonlendirildi
            //matematik2.Topla(1, 999999999999);
            //matematik2.Topla(3, 4, 5, 6);

            #endregion

            #region Recursive (Tekrarlamalı/Ozyinelemeli) Metotlar
            // Kendi icerisnde kendisini cagıran/tetikleyen fonksiyonlardır
            // Recursive Fonksiyon bir yaklaşımdır.
            // Anlasılması, kullanması ve anlatılması zordur.

            // AMACI
            // Ongurelemeyen, derinligi tahmin edilemeyen, sonu bilinmeyen durumlarda tercih edilebilir.

            // Dongulerin kullanıldıgı her noktada Recursive Fonk'lar kullanabilir fakat
            // --Recursive Fonk'ların kullanıldıgı her yer de donguleri kullanamazsın

            #region Ornek 1
            // Belirli bir deger aralıgındaki 5'in katı olan tüm sayıları toplayan rec. fonk. programı
            //int X(int sayi1, int sayi2)
            //{
            //    if (sayi1 % 5 == 0)
            //        return sayi1 + X(++sayi1, sayi2);
            //    if (sayi1 < sayi2)
            //        return X(++sayi1, sayi2);
            //    return 0;
            //}
            //X(10, 20);
            #endregion

            #region Ornek 2

            //List<FileInfo> files = DosyaYazdir("C:/Users/fener/OneDrive/Masaüstü/YUNUS KAMP/kampIntro");
            //foreach (FileInfo file in files)
            //    Console.WriteLine(file.Name);

            //List<FileInfo> DosyaYazdir(string path)
            //{
            //    List<FileInfo> fileInfos = new(); 
            //    DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            //    if (directoryInfos.Any())
            //        foreach (DirectoryInfo directory in directoryInfos)
            //            fileInfos.AddRange(DosyaYazdir(directory.FullName));
            //    else
            //        fileInfos.AddRange(directoryInfo.GetFiles());
            //    return fileInfos;
            //}

            #endregion

            //void X(int a = 1)
            //{
            //    Console.WriteLine("merhaba");
            //    if (a<7)
            //    {               // 7 defa metoda girip merhaba yazdırdı sonra geri cıktıgı her metot icin kodun devamını dondurdu
            //        X(++a);     // --bu sayede dünya yazısını da 7 defa yazabildi
            //    }
            //    Console.WriteLine("dünya");
            //}

            //void X(int a=1)
            //{
            //    Console.WriteLine("merhaba");
            //    if (a < 3) // a, 3'ten kucuk oldugu sürece
            //    {
            //        X(++a); // a'yı 1 arttırıp X fonk'nu yeniden cagıracak ve tekrarlayacak ta kii a, 3 olana kadar...
            //                // Fakat X(++a) yerine X(a++) yazılmıs olsaydı eger ilk islem olarak X(a) komutunu gerceklestirip metodu tekralyacaktı..
            //                // --Bu sonsuz donguye girecekti. cünkü hic bir zaman 2.islem olan a'yı 1 arttırmadan X(a) metodunu calıstıracak
            //    }
            //}

            //void X() // Recursive Metotlar
            //{
            //    Console.WriteLine("merhaba");
            //    X();                   // sürekli kendini tetikledigi icin sonsuz merhaba yazacak 
            //    Console.WriteLine("dünya");  // dünyaya gecemeyecek
            //}
            //X();
            #endregion

            #endregion

            #region REF KEYWORD
            // Ref keywordu referanstan gelmektedir.
            // Referans, OOP kavramıdır.
            // OOP'de nesneler(object) RAM'de Heap bölgesinde tutulmaktadır.
            // OOP'de Referanslar = operatoruyle ile iletişime gecebilirler. Bir referans, İşaretledigi herhangi bir nesneyi = operatoru sayesinde farklı bir referansa işaretletebilir
            // Yani, referanslar = operatoru neticesinde herhangi bir verisel/nesnesel türeme soz konusu olmamakta, işaretlenmis nesne diger referans tarafından isaretlenmektedir.
            // Ref Kewywordu, deger turlu degiskenlerde referans operasyonları yapmamızı saglayan keyworddur. Deger turlu degiskenlerin referanslarını cagırmamızı/kullanmamızı saglayan keyworddur.
            #region Ornek 1
            //int a = 1;
            //ref int b = ref a;
            //Console.WriteLine(a +" - "+ b);
            //a *= 15;
            //Console.WriteLine(b); // a'yı referans aldıgı icin a'daki herhangi bir degisiklik b'yi de etkiler.
            #endregion
            #region Ornek 2
            //int y = 10;
            //X(y);
            //Console.WriteLine(y);
            //void X(int a)
            //{
            //    a = 25;
            //}
            //// -- REF --
            //int y2 = 10;
            //X2(ref y2);
            //Console.WriteLine(y2);
            //void X2(ref int a)
            //{
            //    a = 25;
            //}
            #endregion

            // Deger turlu degiskenlerde referans calısması yapmak istiyorsak eger ref keywordu kullanılır.
            // Ref Kwywordu, deger turlu degiskenlerin referams turlu degiskenler gibi calısmasını saglayan bir komuttur.
            // Deger Turlu degiskenlerde Shallow Copy (yüzeysel kopyalama) yapmamızı saglayan bir keyworddur.

            #endregion

            #region REF RETURNS OZELLIGI
            // Ref Returns ozelligi sadece metotlarda gecerlidir.
            // Metotlar geriye deger dondurebilen yapılardır, ayrıca metotlarda geriye nesnelerde dondurebiliriz.
            // Ayrıca ref returns ozelligi sayesinde deger türlü degiskenlerin referanslarınıda geriye dondurebilmekteyiz.
            #region Ornek 1
            //int a = 5;
            //int b = X(a);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int X(int y)
            //{
            //    y = 24;
            //    return y;
            //}
            //// -- REF --
            //int a2 = 5;
            //int b2 = X2(ref a2);
            //Console.WriteLine(a2);
            //Console.WriteLine(b2);

            //ref int X2(ref int y)
            //{
            //    y = 24;
            //    return ref y;
            //}

            #endregion

            #endregion

            #region OUT KEYWORD
            // Metodun parametreleri üzerinden dısarıya veri gonderen keyworddur.
            // Bir metodun parametreleri varsayilan olarak INPUT'tur. Haliyle metotlarda tanımlanmıs parametreler direkt olarak iceriye deger almaya odaklanır.
            // Egerki bir metodun parametreleri dısarıya deger cıkaracaksa o parametrenin out keyworduyle işaretlenmesi gerekmektedir.

            // Output parametreleri barındıran bir metodu kullanırken, out parametrelerden gelecek olan degerleri karsılayacak olan degiskenler tanımlanmalıdır.
            //int _b = 0;
            //string _d = "";
            //int a = X(out _b, 123, out _d);

            //  2. KULLANIMI
            //int a = X(out int b, 123, out string d);

            //int X(out int b, int c, out string d)
            //{
            //    b = 3;
            //    d = "hello";
            //    // Bir metot out parametre(ler) barındırıyosa o parametrelere kendi icerisinde deger atanması gerekmektedir. Aksi taktirde derleyici hatası alırız.
            //    return 0;
            //}

            #region TRYPARSE
            //string a = "123";

            //if (int.TryParse(a, out int r))
            //{

            //}
            //else
            //{

            //}
            #endregion

            #endregion

          











        }

        #region METOTLAR
        // Yapılacak islemlere göre 4 farklı turde/varyasyonda metot uyguluyabiliriz.
        #region Geriye Deger Dondurmeyen, Parametre Almayan
        //   - bir metot geriye deger dondurmuyorsa void almalı
        //private void Metot1() // void metot() {}
        //{
        //    Console.WriteLine("Geriye Deger Dondurmeyen, Parametre Almayan Metot Olusturuldu");
        //}
        #endregion

        #region Geriye Deger Dondurmeyen, Parametre Alan
        //public void Metot2(int a) 
        //{ 

        //}
        //public void Metot3(int a, bool b)
        //{

        //}
        //public void Metot4(int a, bool b, char c)
        //{

        //}
        #endregion

        #region Geriye Deger Donduren, Parametre Almayan
        // Egerki bir metot geriye herhangi bir turde deger dondurecegini ifade ediyorsa kesinlikle o turde deger dondurmelidir aksi takdirde hata verir.
        //private char metot5()  // char metot5() {}
        //{
        //    // geriye deger donduren fonk'larda, bildirilen turde bir turde deger dondurebilmek ıcın return keywordunu kullanmamiz gerekmektedir.
        //    // return : nerede tetiklenir islenirse orada ilgili fonksiyondan metotdan cikilir.
        //    return 'a';
        //}
        //private int metot6() 
        //{
        //    if (DateTime.Now.Second>10) // bu tarz durumlarda her turlu duruma gore belirtmeliyiz else durumu da olmalı
        //        return 5;
        //    return 123;
        //}
        #endregion

        #region Geriye Deger Donduren, Parametre Alan
        //public bool Metot7(int x)
        //{
        //    return true || false;
        //}
        //public int Metot8(int x)
        //{
        //    return DateTime.Now.Year > 2000 ? 1 : 0;
        //}
        #endregion

        //static public void X(int a, int b = 3, int c = 0)
        //{
        //}

        /* static public bool PersonelEkle(string adi, string soyadi, int yas) 
   {
       if (yas>=20)
       {
           return true;
       }
       else
       {
           Console.WriteLine("personel 20'den kucuk olamaz");
           return false;
       }           
   }*/

        /* static public int Topla(int sayi1,int sayi2) 
           {
               int sonuc = sayi1 + sayi2;
               Console.WriteLine(sonuc);
               return sonuc;
           }*/
        static void X() 
        {

        } // non-trailing'e kadar olan kısım
        static void X1(int a, int b, string c)
        {

        } // Non-Trailing Named Arguments
        static void X2(in int a, int b, in char c)
        {
            // a = 23; // a in komutu aldıgı icin degistirelemez
            //b = 233; // fakat b degistirilebilir
            //c = 'a';
        } // In parameters
        public static int X3() // local function
        { 
            Y();
            void Y()
            {
                System.Console.WriteLine("sfsdf"); // y fonk 2 defa cagırıldıgı ıcın 2 defa ekrana yazacak
            }
            Y();
            return 0;
        }
        public void X4 (int a) // static local function
        {
            int b = 0;

            static void Y(int a, int b) // Static ile isaretlenince local functionda ana parametrelere ulasamıyoruz maliyet ortadan kalkıyor
            {                           // tekrar aynı parametreleri local functionda tanımlarız
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            Y(a,b);

        }
        public void X5() // Recursive Metotlar
        {
            Console.WriteLine("merhaba");
            X5();
        }
        #endregion

    }
    #region METOTLAR İCİN OLUSTURULAN CLASSLAR
    class Matematik2 // Method Overloading
    {
        public int Topla(int a, byte b)
        {
            return a + b;
        }
        public int Topla(int a, double b)
        {
            return (int)(a + b); // bilincli tur donusumu double sonucu int'e cevirdi
        }
        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Topla(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

    }
    class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public int Cikar(int a, int b)
        {
            return a - b;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Bol(int a, int b)
        {
            return a / b;
        }
    }
    class Ornek
    {
        public void A()
        {
            B();
        }
        public void B()
        {
            C(5);
        }
        private int C(int a = 0)
        {
            return a;
        }

    }
    #endregion
}
