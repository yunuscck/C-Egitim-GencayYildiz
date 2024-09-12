using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Egitim
{
    public class CSharpEgitim1
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine(args[0]);

        // {} = Süslü parantezlere scope denir


        //todo astvagandha
        //todo burada 1'den 10'a kadar yazılmalıdır.
        //todo2 yunus cicek

        /* Yukarıdaki gibi todo yazılınca view>task list'ten 
           yüzlerce kod arasında yazdıgımız acıklama satırlarını bulabiliriz.
           Ama todo tek başına yazılmalıdır yoksa işe yaramaz. */

        //Console.WriteLine("hi yunus");

        #region DEGİSKENLER
        #region Degisken Tanimlama
        // degisken_turu degisken_adi; (noktalı virgül kod konseptini kapatmak anlamına gelir)
        //string adi; // gibi
        //int yasi;

        #endregion
        #region Degiskenler Ramde Nasıl Tutulur?
        //int yas;
        //string adi;
        //string soyadi;
        // FIFO first in first out ilk giren ilk cıkar

        #endregion
        #region Degisken tanımlama kuralları
        // 1.anlamlı isimlendirme
        //int yas;
        //int x;

        // 2.Ozel karakter olmamalı
        // ' . , gibi karakterler olamaz
        // _ karkateri istisnadır
        // 3. Sayısal ifadeler
        // degisken isimleri sayısal ifadelerle baslayamaz lakin barındırabilir 
        //int sayi1;
        //int 1sayi;
        // 4. Bir scope icerisinde aynı isimde birden fazla degisken TANIMLANAMAZ!!

        #endregion
        #region İsimlendirme kuralları (Name Convention)
        /* PASCAL CASE
         * Her kelimenin ilk harfi büyük yazılmalıdır. 
            string AdSoyadi;
            int TckimlikNo;
            int Satislar;
            int DogumTarihi;

        Kısaltma iki harfliyse iki harfte büyük yazılmalıdır
            In/out = IO
            InOutStream = IOStream
        */

        /* CAMEL CASE
            satisDurumu
            personelAdi
            userNamePassword
        */

        /* SNAKE CASE
            kullanici_adi
            isim_soyisim

         */

        #endregion

        #region Degisken isimlerini @ operatörü ile tanımlama

        //string @x;
        /* degisken isimlerinde programatik keyword kullanılamaz! eğer ki bir degisken
        ismide programatik olarak kullanılan bir keywordu vermek istiyorsanız eğer bunu
        @ operatorü ile ezebilir oylece verebilirsiniz
        string static; bu hata verir cunku static bi keyword 
        string @static;
         */

        #endregion
        #region Tanımlanmıs degiskene değer atama
        //int y = 5; // tanımlarken deger atama

        //int A;
        /*
         * varsay ki kodlar var bu alanda
         */

        //A = 1; // tanımlanmıs degere sonradan deger atama
        #endregion

        /* DİKKAT 
            Bir degiskene atanan en son deger gecerlidir

         int a = 5;
         a = 15
         a = 20

            A nın degeri en son 20 oldugu ıcın artık 20dir
         */

        #region Tuple degisken atama


        //(int q, int w, string a) X= (8, 6, "yunus");
        //X.a = "yunus cicek";
        //X = (18, 26, "emre");

        #endregion
        #region Literal Düzenlemeler
        // Komnpleks sayusal ifadeleri _(Alt tire) ile düzenlememizi saglayan ozelliktir
        //int sayi = 1_000_000;
        #endregion
        #region Degisken degerine uygun Default Değer atama
        // degiskenlerin default degerleri
        // default keywordü icerisine verilen türün varsayılan degerini geri dondurur

        //bool b = default(bool);
        //int i = default(int);
        //string s = default(string);
        //char c = default(char);

        // Main icerisinde olusturulan degiskenlerin ilk degerlerini manuel atmaya ozen gosterin
        #endregion
        #region Default Literals (C# 7.1)
        //bool x= default(bool);
        //decimal d = default(decimal);
        #endregion
        #region Scope nedir
        // Faliyet alanı
        // Kapsam
        // Degisken ve fonksiyonların erişilebilirlik sınırlarını belirleyen alandır.
        // Tanımlamalarda ve algoritmik calısmalarda karışıklığı onleyen bir sınır cizer.
        // Bir degisken sade ve sadece tanımlandıgı scope ıcerısnde erişilebilir ve kullanılabilir.
        #endregion
        #region Sabitler/Degismezler/Const
        // Sabitler degismeyen degerleri tutmak icin olusturulmus yapılardır.
        // Sürecte var olan degeri degistirelemez. Degistirlmeye calısıldıgı takdirde compiler tarafından hata verilir.
        // Constant degismeyendir. const yapılanması static yapılanmasıdır
        // Static degiskenler adı uzerinde degiskenlerdir, constlar ise sabittir 
        // Constlar tanımlandıgında değer almak zorundadır.
        // const degisken_tipi degisken_adi;
        // const string ad = "yunus" ;

        #endregion
        #region Global Degiskenler
        // Bir degisken class scope icerisinde tanımlanıyorsa buna global degisken denir
        #endregion
        #region Degisken tanımlama varyasyonları

        // aynı turden olmalı

        // VAR 1
        //  int a = 4;
        //  int b = 6;

        // VAR 2
        //  int a = 5, b=4;


        #endregion
        #region Degiskenler Arası Deger Atama !!!
        // DEEP COPY
        // Deep copy deger türlü degiskelerde varsayılandır 
        // Eldeki veri cogaltılır kopyalanır
        /* a degerini cagırıp b'ye atadıgı ıcın ve a'da yapılan degisikle
           b'yi tekrar degistirmedigi icin buna deep copy denır. heapte referans olarak
           cagırılan bir a olsaydı o zaman b de degısmıs olacaktı.
        */
        //    int a = 5;
        //    int b = a;
        //    a = a * 5;

        //Console.WriteLine(a);
        //Console.WriteLine(b);

        // SHALLOW COPY
        // Shallow copy referans türlü degiskelerde varsayılandır 
        // Stactte bulunan 2 referansın Heapteki 1 degere odaklanması shallow copydır

        #endregion
        #region Object
        /* Object Nedir
            Tum turleri (deger ve referans turleri) karsılayabilen bir turdur.
            Tum turler varsayılan olarak objectten turer.
            object referans turlu bir degiskendir lakin deger turluleri de tutabilir.
            object degiskenler ilgili verileri RAM'de object turde tutarlar lakin
            verinin oz turunude icerisinde bozmadan saklarlar. yani icerisinde
            oz turunde tutulur.
            Bu durum object icerisindeki veriyi kendi turunde tekrar elde edbeliriz anlamına gelmektedir

         */

        #region Boxing
        // object turdeki bir degiskene herhangi bir turdeki degeri gondermek Boxing olarak nitelendirmektedir.
        //int yas = 22;
        //object _yas = 22; // Boxing

        /*Boxing islemi neticesinde ilgili deger objectin icerisinde kendi turuyle
        saklanır. Lakin _yas degiskeni artık 22 degerini bizlere object turde getirecektir
        Burada dikkat ederseniz object turunde elde edilen deger uzerinde turune ozgu
        islemler gerceklestirilemez! Ornegin sayısal bir deger varsa o deger object olarak geleceginden dolayi matematik islemleri yapılamaz.

        Object bir degiskenin icerisndeki deger uzerinde turune ozgu islemler yapabilmek
        icin o objectin icerisinde degeri ozgun turunde elde etmemiz gerek. buna da Unboxig denir. 
        */

        #endregion

        #region Cast Operatoru
        /* Boxing edilmis bir veriyi kenndi turunde elde etmemizi saglayan bir operatordur.
         tur donusumlerinde bilincli tur donusumu konusunda cast opt kullanılır
         kalıtımsal durumlarda da karsımıza cıkar.*/
        /* ()object; cast opt parantezdir. object olan degiskenin solunda o objecti hangi ture unboxing istiyorsak
        parantez icerisinde hedef turu bildirerek kullanılır.

        (T)object;
        */
        //int a = 22;
        //object b = a;
        //(int)b;  // cast opt b degiskeni/objesi icerisindeki degeri bana int olarak ver demektedir.

        #endregion

        #region UnBoxing
        #region casting
        //boxing edilen turu unboxing ederken veriyi aynı turde unboxing etmeliyiz.
        //int yas = (int)_yas; // unboxing islemi
        ////Console.WriteLine(yas * 5);
        #endregion



        #endregion

        #endregion
        #region Var Keyword
        // Tutulacak degerin turune uygun bir degisken tanımlayabilmek ıcın kullanılan keyworddur
        // var keywordu kendisine atanan degerin turune burunur.
        // var medeniHali = true; bool oldugundan dolayı var, bool turune burunecektir.
        // var keywordu compiler tarafından degerin turune gore otomatik burundurulen bir keywordur,
        // Lakin bir tur DEGİLDİR...!
        // Diller arasında entegrasyon ıcın kullanılır.
        /* Turumu bilebildiğimiz verilerin degisken turlerini var ile compilera yaptırmak ufakta olsa
         * bir maliyettir! Bunun ıcın bizler bu maliyetten kacınmak adına bildigimiz turleri belirtmeliyiz.
         */

        //string adi = "yunus";
        //var x = 3.14m; // var decimal gibi davranacak

        /*  1. var keyworduyle tanımlanan degiskenin degeri tanımlanma asamasında verilmelidir. verilmelidir ki
          turu belirleyip direkt ona donusebilen o turde davranıs sergileyebilsin
         *  2. var keyworduyle tanımlanan degiskene ilk deger verildikten sonra o degerin turune buruneceği sonraki
          durumlarda degeri farklı turlerde verilemez.
         *  3. var - object arasındaki fark;
          var bir keyword iken object ise bir turdur. var atanan degerin turune burunurken object atanan degeri
          boxing yaparak objecte donusturur.
         * 
         */


        #endregion
        #region Dynamic Keywordu
        // var derleme asamasında degerin turune burunurken, dynamic ise runtimeda verilen deger turune donusecektir
        /*
        var a = 5;
        dynamic _a = "5";
        Console.WriteLine(_a.GetType());
        Console.WriteLine(_a * 5);

        // Dynamic keywordu runtime'da turu belirleyecek fakat kararlı davranmayacaktır.
        dynamic x = "ahmet";
        Console.WriteLine(x.GetType());
        x = 3.14d;
        Console.WriteLine(x.GetType());
        */
        #endregion
        #endregion

        /* KOD NASIL CALISIR? NASIL ISLENIR?
        2 turlu calısır. Senkron ve Asenkron olarak.
        Yazılımlar varsayılan olarak senkron calısır.
        İleri duzey prog. ile kodumuzu asenkron hale getirebilmekteyiz.
        SENKRON konsept konsept kodu okuyarak ilerler
            int a;, string b="yunus"; 
        Eger satır satır ilerleme olsaydı bu satırda hata olurdu
        int kod konseptini okuyup string kod konseptine gecer.
        Fakat konsepteki kod bitmeden diger konsepteki koda gecmez.. asenkronda bu yoktur.

         */

        #region TUR DONUSUMLERI
        // yazılım surecınde elımızdeki degerlerin turlerini degistirebiliriz
        #region Metinsel İfadelerin Diger İfadelere Donusturulmesi
        // Tur donusumlerınde dıkkat edılmesı gereken tek bır husus vardır
        // donusum yapılacak verının turune uygun bır hedef tur belirlenmelidir

        #region Parse Metodu
        // Parse metodu sadece strıng dataları hedef ture donustururken kullanılır
        // degsken_turu degsken = degsken_turu.Parse(donusturulen degskn)
        /* ORNEK 1
        string x = "123";
        short x2 = short.Parse(x);
        Console.WriteLine(x2 * 5);
        //Console.WriteLine(short.Parse(x) * 5); bu sekilde de yapılabilr
        */
        /*ORNEK 2
        // Tür HATALI
        string a = "Ahmet";
        int a2 = int.Parse(a);
        Console.WriteLine(a2);
        */
        /* ORNEK 3
        string medeniHal = "evli"; // bool degerinde sadece true ve false vardır
        // bu yuzden olması gereken string medeniHal = "true";
        bool medeniHal2 = bool.Parse(medeniHal);
        Console.WriteLine(medeniHal2);
        */

        #endregion

        #region Convert Fonksiyonları
        // tum turler arasında gerceklesir
        /* ORNEK 1
        string x = "25";
        int x2 = Convert.ToInt32 (x);
        */
        /* ORNEK 2 
        string x = "3,14";
        double d = Convert.ToDouble(x);
        Console.WriteLine(d * 5);
        */
        #endregion

        #endregion

        #region Diger Ifadelerin Metinsel İfadelere Donusturulmesi

        #region Convert Fonksiyonu
        //int a = 25;
        //string a2 = Convert.ToString(a);
        #endregion

        #region ToString Fonksiyonu
        // ToString fonksiyonu tum ama tum turlerde mevcuttur.
        //float f = 35;
        //string f2 = f.ToString();

        #endregion

        #endregion

        #region Sayısal Ifadelerin Kendi Aralarında Tur Donusumu

        #region Bilincsiz Tur Donusumu
        // Bir sayısal turun kendisinden daha genis aralıktaki bir baska sayısal ture
        // atanması bilincsiz tur donusumudur
        /* ORNEK 1
        int a = 3000;
        float f = a; // su anda burada bır tur donusumu soz konusudur.
        // lakin buradakı tur donusumu bızım ırademızle kararımızla yaptıgımız bır donusum degildir
        */
        /* ORNEK 2
        short x = 123;
        long y = x;
        */

        #endregion

        #region Bilincli Tur Donusumu
        /* cast operatoru
        bilinci bir tur donusumunde de sayısal turleri kendi aralarında donustururken 
        iradeli sekilde bu islemin yapılmasini saglayan operatordur.
         */
        /* ORNEK 1 
        int x = 3000;
        short y = (short)x;
        byte z = (byte)y;
        */
        /* ORNEK 2 
        int a = 3000;      // intten byte turune bilincli bir donusum yapıldı
        short s = (byte)a;  // byte'tan ise short turune bilincsiz bir donusum yapıldı
        */

        #region Checked
        // Bilincli tur donusumu esnasında bir veri kaybı soz konusu olursa 
        // eger bizleri uyaracak olan bir kontrol mekanizmasıdır
        /* ORNEK 1 
        checked 
        {
            int a = 123;
            byte b = (byte)a;
        }*/
        #endregion

        #region Unchecked
        // Normal bir kod blogu zaten uchecked olur.
        /* ORNEK 2   
        int a = 3000;
        short s = (byte)a;
        */
        #endregion

        #endregion

        #endregion

        #region Bool Turunun Sayısal Ture Donusturme
        // Elimızdekı mantıksal bır degerı herhangı bır sayısal degere convert edersek
        // ılgılı degerin mantıksal karsılıgını elde edebiliriz
        /* ORNEK 1   
        bool b = true; // deger true oldugu ıcın 1 gosterır false ıse 0'dır
        int i = Convert.ToInt32(b);
        long l = Convert.ToInt64(b);
        short s = Convert.ToInt16(b);
        decimal d = Convert.ToDecimal(b);
        Console.WriteLine(i); // deger true oldugu ıcın 1 gosterır false ıse 0'dır
        */

        #endregion

        #region Sayısal Turlerın Bool Turune Donusturulmesi
        // Tur donusumlerınde donusturulecek turun hedef ture uygun olması gerekıyor
        // BURADA BIR ISTISNA VAR
        // Normalde ;
        // 0 -> false
        // 1 -> true
        // Esit olması ve gerı kalanının mumkun olmaması gerekmektedir. Halbuki burada
        // 0'ın dısındaki tum degerler true olarak kabul edilmesi bir istisnadır.
        /* ORNEK 1  
        int i = 123;
        bool b = Convert.ToBoolean(i);
        Console.WriteLine(b);
        */
        #endregion

        #region Char Turunden Sayısal Ture Donusum(ASCII)
        /* ASCII ;
         * Bilgisayardaki her bir karakterin sayisal bir karsılıgı vardır
         Bu sayısal degerlere ASCII kaynak kodu denmekte. */
        //char a = 'A';
        //int _a = (int)a;
        //Console.WriteLine(_a);

        #endregion

        #region Sayısal Turlerden Char Ture Donusum(ASCII)
        /*  
        int oascii = 111;
        int Oascii = 79;
        Console.WriteLine((char)oascii);
        Console.WriteLine((char)Oascii);
        */
        #endregion

        #endregion

        #region OPERATORLER
        // operatorler bnelirli bir sorumlulugu isi operasyonu ustlenen sembolik yada metinsel yapılardır
        // bızım yerimize o sorumlulugu ıcra ederler

        /* OPERATORLER OKUR YAZARLIGI   
        Operatorler genellıkle 2 deger arasında matematıksel mantıksal yahut farklı bır ıslemsel 
        gorev/operasyon yapan yapılardır 
        Operatorler genellikle yaptıkları ıslem neticesinde bir sonuc donerler

        Operatorlerı kullanırken gerıye donus degerlerıne dıkkat edilmesi gerekmektedir */

        #region Aritmetik Operatorler Geriye Donus Degeri
        // Aritmetik opertaorler 2 sayısal deger uzerınde ıslem yapan operatorler oldukları ıcın
        // ıslem netıcesınde gerıye "uygun turde" sonuc donerler

        // Aynı turde olan sayısal degerler uzerınde ıslem yaparken sonuc turu aynı olacaktır
        /* İNCELEME
        decimal sayi1 = 234235;
        decimal sayi2 = 235234;
        decimal sonuc = sayi1 % sayi2;
        */


        #endregion

        #region (int) * (double)
        // 2 farklı turde sayısal deger uzerınde yapılan aritmetik islem neticesinde sonuc buyuk olan turde donecektır.
        /*
        int s1 =10;
        double s2 =50;
        double sonuc = s1 + s2;  // Aritmetık operatorler kucuk olan tur buyuk olan ture bılıncsız bır sekilde donusturukerek o sekilde
        hesap yapılır... O yuzden sonuc o buyuk olan turde elde edilecektir. */

        #endregion

        #region (byte) * (int)
        /*
        int s1 = 30;
        byte s2 = 123;
        int sonuc = s1 - s2;
        */
        #endregion

        #region (byte) * (byte) ( ISTISNA - MULAKAT !!!)
        // Normalde 2 aynı turdekı sayısal deger uzerınde yapılan arıtmetık ıslem netıcesınde sonuc aynı turde donecekken
        // bu 2 deger byte ıse sonuc her daım ınt donecektır...ISTISNADIR !!
        /*
        byte s1 = 10;
        byte s2 = 5;
        int sonuc = s1 - s2;
        */
        #endregion

        #region Matematiksel Islemler(Oncelik Sırası)
        // Normal matematik kuralları ıslem oncelıgı aynı sekılde yazılımda da gecerlidir
        #endregion

        #region Karsılastırma Operatorlerı
        /*
        < (kucukluk)
        > (buyukluk)
        <= (kucuk veya esıtlık)
        >= (buyuk veya esıtlık)
        == (esıtlık)
        */

        #region Karsılastırma Operatorlerının gerıye donus degerleri
        // karsılastırma operatorlerı gerıye her daım bool turde bır deger dondurur.
        #endregion



        #endregion

        #region Mantıksal Operatorler
        // tum sartları degerlendırıp kendıne gore sonuc donduren operatorlerdır
        #region ve && Operatoru
        // ve (&&) operatoru tum sartların yerıne getırılmesını ıster
        #endregion

        #region veya || Operatoru
        // veya (||) operatoru sartlardan en az 1 tanesının yerıne getırılmesını ıster
        #endregion

        #region ya da ^ Operatoru
        // yada (^) operatoru sartlardan kesınlıkle 1 tanesının yerıne getırmesını ıster. aynı anda 2sı true yada false olamaz.
        #endregion

        #region Mantıksal Operatorlerın Kullanım Mantıgı
        // Mantıksal operatorler, mantıksal degerler uzerınde kullanılır
        /*
        bool pat= true, kofte= false;
        bool sonuc = pat && kofte;
        bool sonuc2 = pat || kofte;
        bool sonuc3 = pat ^ kofte;
        Console.WriteLine(sonuc);
        Console.WriteLine(sonuc2);
        Console.WriteLine(sonuc3); */
        // Mantıksal operatorler gerıye bool/mantıksal sonuclar donerler
        #endregion

        #region Mantıksal Operatorlerın gerıye donus degerlerı
        /*
        // ve
        Console.WriteLine(true && true); //true
        Console.WriteLine(true && false); //false
        Console.WriteLine(false && false); //false
        Console.WriteLine(false && true); // false

        // veya
        Console.WriteLine(true || true); //true
        Console.WriteLine(true || false); //true
        Console.WriteLine(false || false); //false
        Console.WriteLine(false || true); // true

        // ya da
        Console.WriteLine(true ^ true); //false
        Console.WriteLine(true ^ false); //true
        Console.WriteLine(false ^ false); //false
        Console.WriteLine(false ^ true); // true
        */
        #endregion

        #endregion

        #region Arttırma(++) Azaltma(--) Operatorleri
        /* ORNEK 1  
        int i = 5;
        //i++; // oncelikle i degerini +1 arttırır, ardından i degerini dondurur
        //++i; // oncelikle i degerini dondurur, sonra +1 arttırır.
        Console.WriteLine(i++); // i'yi ekrana yazıp, +1 arttırdı..cıktısı(5) bellekte(6)
        Console.WriteLine(++i); // i'yi arttırıp ekrana yazdı direkt cıktı 7 cunku yukarda ekrana 5 yazarken 1 arttırıldı zaten
        Console.WriteLine(i);
        */

        /* ORNEK 2   
        int a = 5;
        int b = a++; // b'ye a'nın degerını(5) atadı. sonra a'yı +1 arttırdı
        Console.WriteLine(a); // cıktısı (6)
        Console.WriteLine(b); // cıktısı (5)
        */

        /* ORNEK 3  
        int i1= 1;    
        int i2= ++i1;  // i2'ye i1'i +1 arttırıp atıyor yani i2 artık 2 oldu
        int i3= i1;    // i3, i1 artık 2 oldugu ıcın 2 degerını alıyor
        i2 = ++i2; //++i2;    // i2, +1 arttırılarak degerı once bellekte 3 oluyor.sonra i2'ye 
                       // atanarak,bellekteki 2 degeri ezilip yeni 3 degerı atanıyor 
        Console.WriteLine(i1); // 2
        Console.WriteLine(i2); // 2/3(ezildi) -> 3
        Console.WriteLine(i3); // 2
        */

        #endregion

        #region Uzerine Ekleme/Yıgma Operatorlerı
        // +=    i = i + 3  //  i += 3
        // -=    i = i - 3  //  i -= 3
        // *=    i = i * 3  //  i *= 3
        // /=    i = i / 3  //  i /= 3
        // %=    i = i % 3  //  i %= 3

        #endregion

        #region Metinsel Ifadelerde Operatorler

        #region + Operatoru
        // Metınsel ıfadeler + oepratoruyle yanyana birleştirilebilrler
        //int a = 5; int b = 3;
        //Console.WriteLine(a+ b);

        //string a = "ahmet", b = "hello";
        //Console.WriteLine(a + b); // ahmet+hello cıktı ahmethello

        /*
        int a = 5;
        string b = "hello";
        Console.WriteLine(a+b);   // 5hello
        */

        /* tur donusumlerınde herhangı bır degerı strınge donusturmek ıcın .ToStrıng
         fonksıyonunu kullanıyoruz.ayrıyetten ilgili turu strınge donusturmek ıcın strıng
         bır ıfade ıle + operatorune tabii tutulması yeterlı olacaktır */
        #endregion

        #region += Operatoru

        /*
        string a = "ahmet";
        string b = "mehmet";
        //a = a + b;
        a += b;
        Console.WriteLine(a); // ahmetmehmet
        */

        #endregion

        #region == Operatoru

        /*
        string a = "ahmet";
        string b = "mehmet";

        bool sonuc = a == b;
        // a.Length > b.Length; // karakter sayısına gore buyuk mu kodu
        bool sonuc2 = a != b;
        */






        #endregion

        #endregion

        #region ! Operatoru
        // Mantıksal yapılarda olumsuzluk ıfade eder
        // true ya da false
        // !true -> false
        // !false -> true
        // == (esıtlık)
        // != (esıt degıllık)

        //Console.WriteLine(!true); // cıktı false

        /*
        int i = 3;
        int i2 = 4;
        Console.WriteLine(i!=i2); // true cıktısı
        Console.WriteLine(i==i2); // false cıktısı
        Console.WriteLine(!(i == i2)); // true cıktısı cunku bastaki unlem != esıt degıldır manasına getırdı kodu
        // ! ; != bu operatorun dısında sade ve sadece mantıksal degerlerın yanında kullanılır
        */
        #endregion

        #region Ternary Operatoru ( ? : )
        /* bır degıskene metota property'e deger atarken eger ki bu deger sarta gore fark edecekse
        tek satırda ya da satır bazlı bu sart kontrolunu yaparak duruma gore degerı dondurmemızı
        saglayan bır kalıpsal operatordur. */

        // degs turu...degısken = ...sart/durum...?....true sartı yapılacak...:...false sartı yapılacak.....
        // sart/durum gerıye bır deger donduren karsılastırma yahut
        // mantıksal ıslem netıcesınde bool sonuc olmalı

        // KURAL  -  Donecek degerler aynı turde olmalıdır.

        // EKSTRA BILGI Polimorfizm, kurallarına gore birbirinden turuyen degerlere artık desteklemektedır

        /* ORNEK 1  
        bool medeniHal = false;
        string mesaj = medeniHal == true ? "evlilere kampanya" : "bekarlara kampanya";
        Console.WriteLine(mesaj);
        */

        #region Birden fazla Condition Uygulamak

        /* ORNEK 1  
        int yas = 25;
        // SORU - Yası, 25'den kucuk olanlara A, 25 olanlara B ve 25'den buyuk olanlara
        //C degerını donduren Ternary Operatoru

        string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
        Console.WriteLine(sonuc);
        */

        /* ORNEK 2  
        Kullanıcı tarafından gırılen sayının asagıdaki onergelere
           gore hesabını gerceklestıren kodu gelıstırınız
        sayı < 3                        => sayı * 5
        sayı > 3 && sayı < 9            => sayı * 3
        sayı >= 9 && sayı % 2 == 0      => sayı * 10
        sayı % 2 == 1                   => sayı
        hicbiri degilse                 => -1


        Console.WriteLine("Lutfen bir sayı girin; ");
        int sayi =int.Parse(Console.ReadLine());
        //int _sayi = int.Parse(sayi);
        int sonuc = sayi < 3 ? sayi * 5 : 
            (sayi > 3 && sayi < 9 ? sayi * 3 : 
            (sayi >= 9 && sayi % 2 == 0) ? sayi * 10 : 
            (sayi % 2 == 1 ? sayi : -1));
        Console.WriteLine("Sonuc " + sonuc);
        */

        /* ORNEK 3    
        // hava durumunu tutan strıng degıskenın degerıne gore asagıdakı onergelerı
        // uygulayan program
        // yagmurlu  -  semsıye almalısın
        // guneslı   -  bol bol d vitamini alman dilegiyle
        // kapalı    -  yagmur yağabilir

        Console.WriteLine("hava durumunu gırınız ; ");
        string havaDurumu = Console.ReadLine();

        string sonuc = havaDurumu == "yagmurlu" ? "semsıye alamlısın" : 
            (havaDurumu == "gunesli") ? "bol bol d vitamini alman dilegiyle" : 
            (havaDurumu == "kapalı") ? "yagmur yagabilir" : "hava bıldırımı yok";
        Console.WriteLine(sonuc);
        */

        #endregion



        #endregion

        #region Atama(Assign) Operatoru
        //int a = 5;
        // degisken assign'ın solunda cagrılırsa kendısı, sagında ıse degerı gelir.
        // aynı zamanda referans atama operatorudur.
        #endregion

        #region .(Member Access - Üye Erisim) Operatoru
        // Member access elimizdeki bir degerin turune uygun elemanlarını/fonksiyonlarını
        // metotlarını/propertylerini/ field erismemizi/ calıstırmamızı/ cagırmamızı saglayan bır operatordur.
        // Member access kodun devamını getırır.

        //int i = 5;
        //i.ToString();

        #endregion

        #region Cast Operatoru
        // Genellikle tur donusumlerınde kullanılan bir operatordur
        /* 1. Boxing > Unboxing 
        object x = 123;
        int _x = (int)x; */

        /* 2. Bilincli Tur Donusumu
        int a = 10;
        short b = (short)a;  */

        /* 3. Char Z int | int > char (ASCII)
        int ascii = 93;
        char c = (char)ascii;   */

        // ******** İleride polimorfizm durumunda base class referansıyla isaretlenen bir nesneyi
        // kendi turunde elde edebilmemizi saglamaktadır

        #endregion

        #region sizeof Operatoru
        // Verilen turun bellekte kac bytelık yer kapladıgını interger olarak gerıye dondurur
        /*
        Console.WriteLine("int : " + sizeof(int));
        Console.WriteLine("long : " + sizeof(long));
        Console.WriteLine("decimal : " + sizeof(decimal));
        */
        #endregion

        #region typeof Operatoru
        // typeof Operatoru verilen turun/degerın type'ını/turunu getırır
        // O tur ile ilgili bilgileri edinmek icin kullanılan bir operatordur
        // Ileride (ileri duzey programlamada) reflection dedigimiz bir konuda
        // elimizdeki bir turun reflectiona girmek ıcın kullanıldıgını gorecegız

        /*
        Type t = typeof(int); // int turune ait tum bılgıler t degıskenıne atanmıstır
        Console.WriteLine(t.IsPrimitive);
        Console.WriteLine(t.Name);
        Console.WriteLine(t.IsClass);
        Console.WriteLine(t.IsValueType);
        */

        #endregion

        #region default Operatoru
        // Belirtilen turun default degerını donduren operatordur
        // Default degerler her tur ıcın yazılım tarafından tanımlanmıs varsayılan deger demektır
        // sayısal  - 0
        // bool     - false
        // string   - null
        // char     - \0
        // referans - null
        /*
        Console.WriteLine(default(decimal));
        Console.WriteLine(default(string));
        Console.WriteLine(default(Program));
        Console.WriteLine(default(short));

        int a1 = default;
        int a2 = default(int);
        */

        #endregion

        #region is Operatoru
        // Boxinge tabii tutulmus bır degerın oz turunu ogrenebılmek ıcın kullanılan bır operatordur
        // is operatoru denetleme netıcesınde durumu bool yanı true yada false olarak dondurecektır.
        /*
        object x = true; // boxing
        Console.WriteLine(x is bool);
        Console.WriteLine(x is int);
        Console.WriteLine(x is Program);
        */
        // İleride if yapılanmasında vs. cok tercıh ettıgımız bır operator olacaktır
        // OOP yapılanmasında polimorfizm is operatoruyle kalıtımsal durumdaki nesnelerin turlerınde ogrenebileceğiz

        #endregion

        #region is null Operatoru
        // bır degıskenın degerını null olup olmamasını kontrol eden ve sonuc olarak
        // gerıye bool turde bır deger donduren operatordur

        //string a = null;
        //Console.WriteLine(a is null);

        // is null operatoru sadece null olabilen turlerde kullanılabilir
        //int b = null;
        //Console.WriteLine(b is null); // deger turlu degıskenler null almaz



        #endregion

        #region is not null Operatoru
        // elimizdeki degerin null olup olmamasıyla ilgilenmekte ve geriye bool sonuc dondurur.
        //string a = null;
        //Console.WriteLine(a is not null);
        // sadece null alabilen turlerde kullanılır

        #endregion

        #region as Operatoru
        // Cast operatorunun unboxing ıslemıne alternatıf olarak uretılmıs bır operator.
        // Turune uygun bır sekilde as edilmesi zaruri degildir.. eger tur uygunsa unboxing islemi basarıyla yapılacak
        // eger tur uygun degılse HATA vermeyecek ve Null deger dondurecek
        // Bu durumda programatık olarak yazılımın sonlanmadan akısta kontrol edilmesine musaade edecek ve isleme devam edecektir.
        // Type y = x as Type  as operatoru tur uygun olmadıgı takdırde gerıye null dondurecegı ıcın bu null'u karsılayabilen turlerle calısmak ısteyecektır.
        // halıyle as operatoru deger turlu degıskenlerde kullanılmaz.
        // Referans turlerdeki degiskenlerle calısabilir.

        /* CAST ORNEKLENDIRMESI  
        object x = "ahmet";
        int x2 = (int)x;
        Console.WriteLine(x2);
        */
        /*
        object x = "ahmet";
        Program y= x as Program;
        Console.WriteLine(y);
        */


        #endregion

        #region ?(Nullable) Operatoru
        // C# prog dilinde deger tur degıskenler normal sartlarda null alamazlar (not nullable)
        // bir deger turlu degıskenın null deger alabilmesi icin (yani nullable olabilmesi icin) 
        // ? operatorunu kullanılması gerekmektedir
        // degsken_turu? degısken_adı
        // int? a = null;
        // bool? b = null;

        //Console.WriteLine(a is null);
        //Console.WriteLine(a is );

        // bir deger turlu degısken nullable yapıldıysa eger ; is null, is not null as gibi bull ile calısan
        // operatorleri uzerınde kullanabiliriz

        /* as ORNEK
        object x = 123;
        int? y = x as int?;
        */

        #endregion

        #region ?? (Null Coalescing) Operatoru
        // Eliimzdeik degıskenın degerını null olma durumuna ıstınaden farklı bır degerı
        // gondermemızı saglayan operatordur

        //string a = null;
        //Console.WriteLine(a ?? "merhaba");
        //Console.WriteLine(a == null ? "merhaba" : a); // usttekı bunun kolay halı

        //Console.WriteLine(a ?? 3);
        // Null coalesıng operatorunde her ıkı taraftakı degısken yada degerler aynı turde olmalıdır.

        #endregion

        #region ??= Operatoru (Null-Coalescing Assigment) (C# 8.0)

        /*
        string x = null;
        Console.WriteLine(x ??= "merhaba");
        // x'in degerı null ıse merhaba yazdır ve merhaba degerını x'e ata
        // egerkı null degılse direkt olarak x'in degerını yazdıracaktır.
        Console.WriteLine(x);
        */
        /*
        int? id = null;
        id ??= 1; // id null ıse 1 degerını ata yok degılse degerını koru
        // her 2 deger aynı tur olmalıdır
        */


        #endregion

        #endregion

        #region AKIS KONTROL MEKANIZMALARI
        // Akıs kontrol mekanızmaları surecınde belırlı sartlara gore farlı yonlendırmelerı yapmamızı ve
        // -farklı algorıtmaları/kodları/yapılanmaları calıstırmamızı saglayan mekanızmalardır
        // if-else, switch case
        // Yazılım kodunun akıs surecınde sarta gore yonlendırmesını saglamaktadır
        // algorıtmalarda cıddı manada kullanılan yapılardır. o yuzden yazılımcılar acısından olmazsa olmazdır
        // ıkısı (ıfelse - switch) arasında teknık fark olsa da ısleyıs veya kullanım acısından fark yoktur

        #region Switch Case
        // Switch case kodun aksıında belırlı bı sarta gore yonlendırme yapmamızı(farklı algorıtma calıstırmamızı/farklı operasyon
        // gerceklestırmemızı/tetıklememızı) saglayan yapılanmadır.
        // Switch Case yapılanması sadece bır degıskenın degerını sadece esıtlık durumları kontrol ederken kullanılabılır
        // SADECE esıtlık durumu check edılecek ıse o zaman Switch kullanılır
        // switch case yapılanmasında kontrol edılen deger ıle esıtlık saglayan case varsa dıger caselere bakmaksızın switch blogundan cıkılacaktır
        // switch yapılanmasında amac esıtlık durumuna gore belırlı bır kod blogunu tetıklemektır

        /* SWİTCH CASE YAPISI
        switch(deger) // surecte esıtlık durumu kontrol edılecek olan deger buraya yazılır
        {
            case value1: // switch yapılanmasında verılen degerın esıtlık durumlarını kontrol edecegımız dıger degerlerı case bloklarına bu sekılde yerlestırıyoruz
                           // case value belirdikten somnra : kalıpsal olarak burada kullanılmalıdır.
                break;    // case ile break arasına yazılan kodlar ılgılı case'in dogrulanması surecunde ıslenecek kodlardır

            case value2: 

                break;

            default: // switch case yapılanmasında hıcbır case esıtlık durumunu saglamıyorsa default break arasındakı kodlar calısır
                break;   // default kalıbı zorunlu degıldır

        }
        */

        //string adi = "ahmet";

        /* ORNEK - INCELEME  
        // case bloglarının sıralaması ve defaultun yerlestırıldıgı yer onemlı degıldır.
        switch (adi) // kontrol edılen degerın turu ne ıse case bloglarında da aynı turde degerlerle kontrol edılır
        {            // switch parantezınde kontrol edılen deger bır degısken yahut sabıt/statık bır deger olabılır
            case "mehmnet": // case bloglarındaki degerler kesınlıkle sabit/statık olmak zorundadır. caselerdekı degerler degısken olamaz.
                Console.WriteLine("adı mehmet");
                break;
            case "ahmet":
                Console.WriteLine("adı ahmet");
                break;
            case "hilmi":
                Console.WriteLine("adı hilmi");
                break;
            default:  // case bloglarından hıcnırı eslestırmeye uymuyorsa eger varsa default ıslemlerı yapılır
                Console.WriteLine("hıcbırı degıl");
                break;
        }// esıtlık saglandıgı durumda dıger caselere bakmadan switch blogundan cıkar compiler.
        */

        #region Switch-Case When
        // Switch yapılanmasında sadece elimizdeki degerın esıtlık durumunu kontrol edebilmekteyiz. Bunun dısında bu kontrol esnasında
        // farklı sartlarıda degerlendırmek ıstıyorsak eger when keywordu kullanabilriz.

        /* ORNEK 
        int satisTutari = 1000;
        switch (satisTutari)
        {
            case 1000 when (3==5):
                Console.WriteLine();
                break;

            case 10000 when (3==3):
                Console.WriteLine();
                break;
        } */



        #endregion

        #region Switch-Case goto
        // switch case yapılanmasında sadece esıtlık durumunu ınceleyebıldıgımız ıcın mantıksal bır ıslem gerceklestıremıyoruz
        // Dolayısıyla bazen farklı degerlere esıt olma durumunda aynı operasyonu/kodu/akısı kullanacagımız senaryolarla karsılasabilmekteyız.
        // Farklı esıtlıklerde aynı kodu calıstıracaksak eger kod tekrarına gırmemek ıcın goto keywordu ile su casedekı kodu calıstr dıyeblırız

        /* ORNEK  
        int i = 10;
        switch (i)
        {
            case 5:
                Console.WriteLine(i*10);
                break;
            case 6:
                Console.WriteLine(i/5);
                break;
            case 7:
                // Console.WriteLine(i*10); // bu sekılde kod tekrarında  goto keywordunu kullanabılırız
                goto case 5; // case 5dekı kodu calıstır / break kodu kullanılmaz
            case 10:
                //Console.WriteLine(i*10);
                goto case 5; // goto kwywordu kullanıldıgı case'ın eslestırmesıne bakmaksızın direkt olarak kodu calıstıracaktır

            // bırden fazla goto keywordunun bır case yonlendırılmesı durumunda bu sekılde yapılabılır.
            //case 7:
            //case 10:
              //  goto case 5;
        } */
        #endregion

        #region Switch Expressions
        // Tek satırlık ıslemler ıcın malıyet dusurucu ve kullanıslı semantıklerdır
        /* ESKI YONTEM ILE  
        string isim = "";
        int i = 10;
        switch (i)
        {
            case 5:
                isim = "hilmi";
                break;
            case 7:
                isim = "rıfkı";
                break;
            case 8:
                isim = "gencay";
                break;
        } */

        /* YENI YONTEM ILE
        int i = 10;
        string isim = i switch
        {
            5 => "hilmi",
            7 => "rıfkı",
            10 => "gencay"
        }; */


        /*  ---  WHEN SARTI  ---

        int i = 10;
        string isim = i switch
        {
            5 when 3 == 3 => "hilmi",
            int x when x == 7 && x % 2 == 1 => "rıfkı",
            10 => "gencay",
            var x => "hıcbırı" // default: hıcbırının  olmadıgı durumda default tanımlamasına karsılık gelecektır 
        }; 
        */

        #region Tuple Patterns

        //int s1 = 10;
        //int s2 = 20;
        //string mesaj = "";
        //switch (s1, s2)
        //{
        //    case (5, 10):
        //        mesaj = "5 ile 10 degerleri";
        //        break;
        //    case (10, 20):
        //        mesaj = "10 ile 20 degerleri";
        //        break;
        //}
        //Console.WriteLine(mesaj);

        //string mesaj = (s1, s2) switch
        //{
        //    (5,10) => "5 ile 10 degerlerı",
        //    (10,20) => "10 ile 20 degerlerı"
        //};

        /*   -----  WHEN SARTI  -----
        string mesaj = (s1, s2) switch
        { 
            (5,10) when (true) => "5 ile 10 degerlerı",
            var x when x.s1 % 2 == 1 || x.s2 == 10 => "10 ile 20 degerlerı"
        };
        */

        #endregion

        #region Positional Patterns
        // ILERDE DAHA IYI ANLAYACAZ
        #endregion

        #region Property Patterns
        // ILERDE DAHA DETAYLI GORECEZ
        #endregion

        #endregion

        #endregion

        #region If
        // If Yapılanması, elımızdekı bır verının esıtlık durumu dahıl tum kıyaslamaları
        // karsılastırmaları yapmamızı saglayan ve sonuca gore akısı yonlendırmemızı saglayan bır yapılanmadır

        // if(  sart  )  // egerkı bu sart dogru ıse 
        // {
        //    // buradakı kodlar calısır
        // }
        // else // degılse
        // {
        //    // buradakı kodlar
        // }

        // if ( sart ) -> Sart her daım bool olmalıdır
        // karsılastırma ve mantıksal operatorlerın hepsı burada kullanılabılır

        /* ORNEK   
        bool medeniHal = true;
        if (medeniHal== true)
        {
            Console.WriteLine("Allah tek yastıkta kocatsın");
        }
        // ıf yapılanması tek basına kullanılıyosa sadece sarta baglı  calısacak koda odaklanır.
        */

        // KRITIK 1 - ıf yapılanmasında ılla kı else kullanmak zorunda degılız
        //int i = 10;
        //if (i != 10)
        //{
        //    Console.WriteLine("merhaba");
        //}
        //Console.WriteLine("dunya");

        // KRITIK 2 - bool turdekı degıskenlerın degerlerı zaten bool olacagından dolayı karsılastırma operatoru kullanmak zorunda degılız
        // bool medeniHal = true;
        // if (medeniHal == true)
        // if (!medeniHal) // bool degısken false ise
        // if (medeniHal) // bool degısken true ise
        // {
        //    Console.WriteLine("hayırlı olsun....");
        // }

        #region If - Else
        // if else yapısı sarta gore bır kopdun calısıp sartın olmadıgı bır durumda bır baska kodun calısmasını belırleyen bır yapılanma
        // sartın olumsuz/ degıl durumunda calısacak kodu belırlemıs oluyoruz

        //  if () // sart true ise burası
        //  {

        //  }
        //  else // sart false ıse burası
        //  {

        //  }
        // If blogunda else varsa sartın false olması durumunda kesınlıkle else blogu tetıklenır
        // ıf else yapılanmasında sart dogru oldugunda sadece ıf, yanlıs oldugunda ıse sadece else blokları tetıklenır
        /* Ornek  
        int i = 3;
         if (i > 5)
        {
            Console.WriteLine("i degerı 5ten buyuktur");
        }
        else
        {
            Console.WriteLine("i degeri 5ten kucuktur");
        } */

        // tek satırlık ıslemlerde scopesuz ıf yazılabılır 
        //if (true) 
        //  Console.WriteLine("merhaba");
        //else(false)
        //  Console.WriteLine("sdvf");

        // ORNEK SORU
        // Klavyeden 2 ürün fiyatı girildiginde toplam fiyatı 200 tl'den fazla ise 2.üründen
        // %25 indirim yaparak odencek tutarı gosteren prog
        //Console.Write("lutfen 1.urun fıyatını gırınız"); // write ekrana yazıp altsatıra gecer
        //int birinciUrununFiyati = int.Parse(Console.ReadLine());
        //Console.Write("lutfen 2.urunun fıyatını gırınız");
        //int ikinciUrununFiyati = int.Parse(Console.ReadLine());
        //int toplam = birinciUrununFiyati + ikinciUrununFiyati;

        //if (toplam > 200)
        //{
        //    Console.WriteLine("indirimli tutar : " + birinciUrununFiyati+(ikinciUrununFiyati*75/100));
        //}
        //else
        //{
        //    Console.WriteLine("toplam tutar : " + toplam);
        //}

        // ORNEK SORU 2
        // Belirlenen kullanıcı adı ve sıfre dogru gırıldıgınde "gırıs basarılı" yanlıs gırıldıgınde
        // "gırdıgınız kullanıcı adı veya sıfre hatalı" mesajı veren prog.
        //string kullaniciAdi = "yunuscicek25";
        //string sifre = "Yunus443!";

        //Console.WriteLine("kullanıcı adını gırınız : ");
        //string kAdi = Console.ReadLine();
        //Console.WriteLine("sıfreyı gırınız");
        //string sfr = Console.ReadLine();

        //if (kAdi == kullaniciAdi && sfr == sifre) // degısken atamak yerıne sart kısmında da yazılabılırdı kullanıcı adı sıfre
        //    Console.WriteLine("Giriş Başarılı");
        //else 
        //    Console.WriteLine("Girmis oldugunuz kullanıcı adı veya sıfre hatalı");

        // Ternary operatoru ile
        //Console.WriteLine("kullanıcı adını gırınız : ");
        //string kAdi = Console.ReadLine();
        //Console.WriteLine("sıfreyı gırınız");
        //string sfr = Console.ReadLine();
        //Console.WriteLine(kAdi == "yunus" && sfr == "yunuscck" ? "Giriş Basarılı" : "Gırdıgınız sıfre veya kullanıcı adı hatalı");




        #endregion




        #endregion

        #region PATTERN MATCHING

        #region Type Pattern
        // Object ıcerısındekı bır tıpın belırlenmesınde kullanılan is operatorunun
        // desenkestırılmıs halıdır.
        // is İle belirlenen türün direkt dönüşümünü sağlar

        // İLK HALİ
        //object x = 125;
        //if (x is string)
        //{
        //    string xx = x as string;
        //    Console.WriteLine($"x bir string");
        //}
        //else if (x is int)
        //{
        //    int xx = (int)x;
        //    Console.WriteLine($"x bir inttir");
        //}

        // TYPE PATTERN HALİ 
        //object x = 123;
        //if (x is string xx)
        //    Console.WriteLine("x degıskenı bir string");
        //else if (x is int x2)
        //    Console.WriteLine("x degıskenı bir string");

        //object x = "gencay";
        //if (x is string x2)
        //{
        //    //string xx = (string)x;
        //}

        #endregion

        #region Constant Pattern
        // Elimizdeki veriyi (is operatoru ile) sabit bir deger ile karşılaştırabilmemizi saglar

        // is operatoru bı degıskenın turunu sormamızı belırlememızı saglyan bır operatordur
        // ve bu operatorun kullanıldıgı degıskenlerın turu ılla reeferans oolmak zorunda degıldır
        // İsterseniz deger turlu degıskenlerde de is operatoru kullanılabılmektedır ve hatt primitive
        // turlerde bile kullanılabilmektedir

        // egrki is operatoruyle bir degıskenın degerını == operatorunun sorumluluguyla
        // check ediyorsa iste buna constant pattern demektir.

        #endregion

        #region Var Pattern
        // Eldeki veriyi 'var' degiskeni ile elde etmemizi saglamaktadır

        //object x = "Turkey";
        //if (x is var a)
        //{
        //    Console.WriteLine(a);
        //}

        //object x = "sdfsdfsdf";
        //if (x is var a) // var'ın turu runtimede belirlenecek burada/ normalde var da direkt belirlenirdi
        //{ }

        // var keywordu ıle var patterndeki var yapılanması arasında davranıs farkı vardır
        // var keywordu : derleme zamanında turu belirlerken
        // var patternı : runtime de belirlenecek
        // dynamic runtimeda belirlenen bir turdur ancak var pattern var keywordu ile calıstıgı ıcın burada kullanılmaz

        #endregion

        #region Recursive Pattern
        // bu desen switch-case yapılanması üzerinde biircok yenilik getirmektedir.
        // switch blogunda referans turlu degiskenlerde kontrol edilebilmektedir
        // tur kontrolu yaptıgı ıcın Type patternı kapsamaktadır.
        // (ornekteki case kodunda case null vardı...) case null komutu ıle iligil turun/referansın null olup olmamasını kontrol edebilmesinden dolayı Constant patterni kpasamaktadır

        #endregion

        #region Type ve Var Patterni Üzerine Kritik
        //var patterni ile degiskene atanınca o degiskenin turu rutimede belirlenecegi icin o degiskeni sonradan cagırıp kullanailiyoruz

        //object x = "sdfsadf";
        //if (x is string a)
        //{
        //    Console.WriteLine(a);
        //}
        //else if (x is var b)
        //{

        //}

        // TYPE PATTERN
        // type patternda x degıskenın degerının string olmama ihtimalinde,
        // o1'in null olma soz konusu oldugu ıcın o1 kullanılırken hata vermektedir
        //bool result = x is string o1;
        //Console.WriteLine(o1);

        // VAR PATTERN
        // var patternde ise x degiskenin de degeri ne olursa olsun var ile o2'ye atanacagından dolayı
        // o2'nin null olma ihtimali yoktur.. dolayısıyla o2'yi rahatca kullanabilmekteyiz
        //bool result2 = x is var o2;
        //Console.WriteLine(o2);

        #endregion

        #endregion

        #region PATTERN MATCHING ENHANCEMENTS

        #region Simple Type Patterns
        // normal type patternın aynısı daha gelişmiş hali
        #endregion

        #region Relational Pattern
        // desenlerde <, >, >=, <= operatorleri kullanabilmekte ve belirli karsılastırmaları hızlıca yapabiliriz
        //int n = 550;
        //string result = n switch
        //{
        //    < 50 => "50den kucuk",
        //    > 50 => "50den buyuk",
        //    50 => "50ye esit"
        //};

        #endregion

        #region Logical Patterns
        // and, or ve not gibi mantıksal operatorler kullanılabilmekteyiz
        //int number = 65;
        //string result = number switch
        //{
        //    > 10 and 50 => "10 ile  50 arasında",
        //    > 50 or 100 => " 50 ile 10 arasında ",
        //    not 51 => "51 degil"
        //};
        #endregion

        #region Not Pattern
        // not operatorunun kullanılabildigi bir desendir
        //object obj = new Goggles();
        //if (obj is not Tech)
        //{
        //    //..
        //}


        #endregion

        #endregion

        #endregion

        #region HATA KONTROL MEKANIZMALARI

        #region Syntax Error - Sözdizimi Hataları
        // prog dili kurallarına aykırı olan hatalardır
        // ozellıkle gelısmıs edıtorler (VS) sayesınde soz dızımı hataltaı derlemeye gerek bile kalmaksızın fark edilebilmektedirler
        // hatanın buludugu satır derleyıcı tarafından rapor edılır
        // o yuzden fark edılmesı ve cozulmesı en kolay hata turudur
        #endregion

        #region Run-Time Error - Çalısma Zamanı Hataları TRYCATCH
        // runtiime hataları genellıkle kullanılan mımarıde öntanımlı mesajları verecektır
        // egerkı alınan hatanın mimaride bir karsılıgı yoksa isletim sistemi dili kullanılacak ve daha kompleks bir acıklamayla karsılasılacaktır

        #region Run-Time Hata Durumları
        // olmayan bır dosyayı acöaya yahut uzerıne yazmaya okumaya vs calısmak
        // olmayan deger uzerınde ıslem yapmaya calısmak
        // uygun olmayan formatta calısmak
        // veritabanı baglantısı hatası

        // ORNEK
        // istenilen degerlerın turune uygun deger gırmezsek runtıme hatası verecek
        //Console.WriteLine("1.sayıyı gırın");
        //int sayi1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("2.sayıyı girin");
        //int sayi2 = int.Parse(Console.ReadLine());

        //Console.WriteLine("toplam : " + (sayi1 + sayi2));

        #endregion

        #region Try - Catch Yapılanması
        // Calısma zamanında alınan olası hataları kontrol etmemızı, karsılamamızı, manipule etmemızı saglayan bir yapılanmadır.
        // try catch yapılanması uygulama surecınde yasaanan olası hatayı kullanıcıya hıssettırmeksızın farklı bır durum
        // yada olagan bır mesaj gıbı gostermemızı saglayan ve bunun yanında patlamaya/hataya dair bizlere bilgi sunan ve boylece
        // bu bılgıler eslıgınde kayıtlar/log olusturmamızı saglayan bır programatık yapılanmadır.
        // AMACI :
        // 1 - kullanıcıya alınan hatayı hıssettırmemek.
        // 2 - alınan hatanın nedenıne dair kullanıcıyı bılgılendırmek.
        // 3 - ısletım sıstemlerı aykırı durum yasandıgında uygulamayı sonlandırmak ısterler ve sonlandırırlar.
        // -try catch yapılanması ıle alınan hataya dair bir manipulasyon gerceklestırılıyor ve uygulamanın 
        // -kapanmadan devam edilmesi saglanabiliyor.

        /* PROTIP - İSKELET YAPISI   
        try
        {
            // olası calısma zamanı hatalarını verebilecek kodlari buraya yaziyoruz
        }
        catch
        {
            // try icerisinde olasi hata soz konusuysa akisi orada kesilecek ve akis catch blogundan devam edecektir
            // hataya dair; log, kullanici bilgilendirme, kontrollü kapanis vs.  
        } */

        /* ORNEK 
        try
        {
            Console.WriteLine("1.sayıyı gırın");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("toplam : " + (sayi1 + sayi2));
        }
        catch
        {
            Console.WriteLine("lutfen dogru bir ifade giriniz");
        } */

        /* ORNEK 2
        Console.WriteLine("1.sayıyı gırın");
        int sayi1 = 0, sayi2 = 0;
        try // sadece olası hata verecek kodları yazarak try catch'in sistem maliyetini düsürmüs  oluyoruz
        { 
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            sayi2 = int.Parse(Console.ReadLine());
        }
        catch
        {

            Console.WriteLine("lutfen dogru bir ifade giriniz");
        }
        Console.WriteLine("toplam : " + (sayi1 + sayi2)); */

        #region Try-Catch Hata Parametreleri
        // Calisma zamaninda alinan hataya dair bizlere bilgi veren/tasiyan parametrelerdir
        //int s1 = 0, s2 = 10;
        //int a = s1 / s2;
        //// Runtime da hata alındıgında bunu edıtor uzxerınde gorebiliriz burada gorunen DivideByZeroException bizim aldıgımız hatanın turunu ifade eder
        //// alınan hatanın yapısına fıtratına gore hata turu fırlatılacaktır
        //object x = null;
        //x.ToString(); // null deger stringe cevrilemez
        //int.Parse("sfsf"); // strıng inte donusmez

        //try
        //{
        //    int s1 = 0, s2 = 10;
        //    int a = s2 / s1;
        //}                    // bu parametre catch blogunda yazılmak zorunda degildir. eger ki tanımlama yapılırsa hataya dair bilgi alabiliriz. eger tanımlama yapılmıssa hata netıcesınde catch calısacak ve bılgı alamayacagız
        //catch (Exception ex) // Exception : fırlatılan hata ile ilgili tum bilgileri getirecek olan bir ust turdur
        //{                       // usttur : butun hataları karsılayan bır turdur
        //                        // bu parametre uzerınde bizler alınan hataya dair bilgiler edinebilmekte ve gerkli loglama vs gibi operasyonları gerceklestirebilmekteyiz

        //    Console.WriteLine("mesaj : " + ex.Message); // divide by zero
        //}

        // Exception tum hata turlerının atasıdır...

        #endregion

        #region Try Catch Hata Turleri Orneklerle
        /* ORNEK - 1     
        try
        {
            int s1 = 0, s2 = 10;
            int a = s2 / s1;
            int.Parse("fsdfsadg");// bu senartoda try catch blogu kullanıldıgı halde fızıksel patlama meydana gelmıs ve uygulama sona ermıstır
            // catch blogu eger ki ture ozgu ıse (genel olmayan) boyle bir durumda sadece o turden hatalrı yakalayabilen bir yapı haline gelir
            // Dolayısıyla try*catch blogu hangi parametre tanımlandıysa o parametrenin yakalayabileceği turdeki hatalari manupüle etmekte eger ki
            // parametrenin disinda farkli bir turde hata fırlatilirsa try catch blogu ilgili hatayi manupule etmeyecek ve fiziksel olarak uygulamayı patlatıp sonlandıracaktır
        }
        catch (DivideByZeroException ex) // catch blogu bır parametre tanımlanmazsa eger tum hataları karsılayan bı blogtur. eger bi parametre tanımlanır ve 
        {                                //  bu exception ise yine aynı durum gecerlidir. Fakat parametre ozelleştirilmiş bir hataya indirgenmisse sadece ilgil ture ait hatalrı yakalayabilecektir.
            Console.WriteLine("Mesaj : "+ ex.Message);
        }
        // cozum olarak bu durumda bırden fazla catch blogu ile diger turdeki parametreleri kontrol etmek olacaktır  */

        // --  BIRDEN FAZLA CATCH ORNEGİ  --  
        // Try-catch yapılanması olası run-time hatasi alındıgında catch sıralamasına gore kontrol etmektedir
        // SIRALAMA ONEMLİDİR...
        // Egerki birden fazla catch blogunun tanımlanmasında exception kullanılacaksa bu Exception en sona tanımlanmalıdır... gerekmektedir!!

        //try
        //{
        //    int s1 = 0, s2 = 10;
        //    int a = s2 / s1; // DivideByException hatası

        //    int.Parse("sgfsag"); // FormatException
        //}                                // Exception Her iki ihtimalde de aynı davranısı sergileyecektir. Dolayısıyla farklı turlerdeki hata durumlarında bu sekilde bir fark yaratamayız
        //catch (DivideByZeroException ex) // DivideByException hatası aldıgında bu hatayı karsılayacak olan catch haline getirilmiş oldu
        //{

        //}                       // ex farklı scopelarda tanımlandıgı ıcın aynı sekilde isimlendirebiliyoruz
        //catch (FormatException ex) // FormatException hatasını karsılayacak olan catch tanımlanmıs oldu
        //{                       // bu catchlerin dısında farklı bır hata turu daha olabilmesine karsı baska catch blogları da acılmalıdır

        //}
        //catch (Exception ex) // catch bloglarının en sonuna Exception turunde parametre (catch) tanımlarsan alınan hata usttekı turlerden herhangı bırı degılse kesınlıkle o exception tartafından karsılanabilir olacagından dolayı en kotu buraya gelecektır 
        //{

        //}

        #endregion

        #region Finally Blogu
        // Finally blogu try catch yapılanmasında hata alınsa da alınmasa da her 2 durumda da tetiklenmesi/calıstırılması gereken kodları yazdıgımız bloktur
        //try
        //{
        //    // hata verebilecek kodlar buraya
        //    Console.WriteLine("try");
        //}
        //catch (Exception)
        //{
        //    // hata alındıgında yapılacak ıslem kodları buraya
        //    Console.WriteLine("catch");
        //}
        //finally // her zaman catch bloglarının en sonuna yazılır aksi taktirde zaten hata verecektir
        //{
        //    // her 2 durumda da calısmasını ıstedıgımız kodlar buraya yazılır
        //    Console.WriteLine("finally");
        //}

        #endregion

        #region When Yapısı İle Hata Filtreleme (C# 6.0)
        // Try-catch bloglarına when keywordu ıle sart uygulayabılıriz
        //string x = "a";
        //try
        //{
        //    int s1 = 0, s2=19;
        //    int a = s2 / s1;
        //}
        //catch (DivideByZeroException ex) when(x == "a")
        //{
        //    Console.WriteLine("Mesaj : " + ex.Message);
        //}
        //catch (DivideByZeroException ex) when (x == "b")
        //{
        //    Console.WriteLine("Mesaj : " + ex.Message);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Mesaj : " + ex.Message);
        //}

        #endregion

        #endregion

        #endregion

        #region Logic Error - Mantıksal Hatalar
        // Kodun semantiğinde bi hata yoktur ama sonucu ıstedgımız gıbı vermez.. her halukarda bır sonuc verecektır ama
        //Console.WriteLine(2*6); // 2*5 = 10 sonucunu almak ıstedık ama yanlıslıkla bır mantıksl hata yapıp 6 degerı ile islem yaptık
        // bu da hata vermeden sonucu ekrana verdı ama sonuc ıstedıgımız sonuc olmadı ıste buna mantıksal hatalar denır 
        #endregion

        #endregion

        #region DONGULER
        // FOR - WHILE - DoWHILE
        // Hangi dongu nerede kullanılmalı sorusu yanlıstır. Dogru soru, hangı dongu nereye/hangı senaryoya daha cok yaıkısır.
        // Bu dongulerın hepsı bir kombinasyona baglı bir sekilde calıstıkları icin en nihayetinde birbirinin yerine kullanılabilri.

        #region For Dongusu
        // Prosödürer programlamada dongu yapılarından birisi de for dongusudur.
        // Genellikle ardasık islemlerde kullanilan bir donu yapılanmasidir
        // PROTOTIP

        //for (int i = 0; i < 10; i++)
        //{

        //}

        // VERSIYON 2
        //int i = 0; // i baslangıc degerini dısarda da tanımlayabiliriz
        //for (; i  < 10; i++)
        //{

        //}
        // baska bı varyasyonda tanımlanan i degıskenını for dongusunde baslangıc degerı olarak gostermek ıstıyorsak eger
        // yine bir baslangıc degeri zorunlu kılmaktadir. Yani bu baslangıc degerını vermemız gerekmektedir aksi takdir de derlenmeyecektir.

        // VERSIYON 3
        //int i = 0;
        //for (; i < 10;)
        //{
        //    i++; // i arttırma islemini scope icinde uygun bir yerdede kullanabiliriz.
        //}

        // VERSIYON 4
        //for (; ;) // sonsuza kadar tekrarlanacak dongu
        //{
        //    Console.WriteLine("fdsgsdg");
        //}

        // VERSIYON 5
        //for (int i = 0; ; i++) // sonsuza kadar tekrarlanacak dongu
        //{
        //    Console.WriteLine("fdsgsdg");
        //}

        // VERSIYON 6
        //for (int i = 0, i2 = 12; i < 10 && i2 <5; i++, i2++) // for ıcınde 1den fazla degısken tanımlayıp 1den fazla sart yazıp bırden fazla degıskenı arttırabılırız
        //{
        //    Console.WriteLine(i);
        //    Console.WriteLine(i2);
        //}


        #endregion

        #region While Dongusu
        //while ( sart )
        //{
        //}
        // sart dogtulandıkca while dongusu tetiklenir
        // while dongusu sadece sarta baglı bır dongudur. For'a nazaran daha sade ve ilkel bir dongudur. While dongusu programlamanın ilk 
        // tasarlanmıs dongusudur
        // Genellikle sonsuz dongulerde yahut surecı bilinmeyen durumlarda kullanılan bır dongudur ama ıstediginiz yerde kullanabilirsiniz.
        // while dongusunde for gibi calısabilmek ıcın kombınasyonu kendimiz yapmamız gerekmektedir

        //int _i = 0; // fordaki baslangıc degıskenı
        //while (_i <10) // fordaki sart blogu
        //{
        //    Console.WriteLine("sdfsdf");
        //    _i++;  // fordaki arttırma ıslemi
        //}

        // ORNEK
        //int i = int.Parse(Console.ReadLine());
        //while (i>=0)
        //{
        //    Console.WriteLine(i);
        //    i--;
        //}

        // ORNEK 2
        // 0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gosteren prog
        //int i = 1;
        //int sonuc = 0;
        //while (i<100)
        //{
        //    if (i % 2 == 1)
        //        sonuc = sonuc + i;
        //    i++;
        //}
        //Console.WriteLine(sonuc);

        // ORNEK 3
        // klavyeden girilem sayının faktorıyelını hesaplama
        //Console.WriteLine("sayı gırın : ");
        //int i = int.Parse(Console.ReadLine());
        //int top = 1;
        //while (i>0)
        //{
        //    top *= i;
        //    i--;
        //}
        //Console.WriteLine(top);

        // ORNEK 4
        // o anki tarihin saniyesi 5'in katı ise on anki tarihi ekrana yazdıran prog
        //while (true)
        //{
        //    var second = DateTime.Now.Second;
        //    if (second % 5==0)
        //        Console.WriteLine("date : {0}\nhour : {1}\nminute : {2}\nsecond : {3}", DateTime.Now, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        //}




        #endregion

        #region Do-While Dongusu
        // While dongusu once sarta bakar sonra kodu calıstırır ama Do-While ise once kodu calıstırır sonra sarta bakar.
        // While ile yapılan kontrolde sart true olursa dongu tetiklenecek false olursa hicbir zaman tetiklenmeyecektir
        // Do-While dongusu sart true da olsa false da olsa en az bir kere tetiklenecektir
        //do
        //{
        //    Console.WriteLine("sdfsdf"); // kod false olsa bile bir kerelik ekrana yazacaktır
        //} while (false);

        #endregion

        #region Scope'suz Donguler
        // Tek satırlı kodlarda scopesuz dongu yazılabilir

        //for (int i = 0; i < 10; i++)
        //    Console.WriteLine("sfsdf");

        //while (true)
        //    Console.WriteLine("sdfsafd");

        //do
        //    Console.WriteLine("ssdaf");
        //while (true);

        #endregion

        #region Sonsuz Dongu
        // for
        //bool dongu = true;
        //for (; dongu;) // (; true;)
        //{
        //    if (true) // aranılan deger sonuc her ne ıse true olunca
        //    {
        //        dongu = !dongu; // true olan degerı false yaparak sonsuz donguyu bitirir
        //    }

        //}

        // while
        //bool durum = true;
        //while (!durum);
        //{
        //    if (true)
        //    {
        //        durum= !durum;
        //    }
        //}

        // do while
        //bool durum2= true;
        //do
        //{
        //    if (true)
        //    {
        //        durum2 = !durum2;
        //    }
        //} while (durum2);





        #endregion

        #region İc-İce Donguler
        // FOR
        // ıc ıce dongulerde  degısken ısımlerı farklı olmalıdır.
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {


        //    }
        //}
        #endregion

        #region Foreach dongu mudur
        // dongu belirli bir kombinasyon esliginde calisan ve belirli bir sartta baglı olan periyodik islemler gerceklestiren yapılanmalardır
        // İTERASYON
        // iterasyon mantıgında ne kombinasyon ne de sart vardır. İterasyonda sonraki veri oteki ver anlamına gelen itere etme fiili vardır.
        // bir veri kumesi uzerinde islem yapmamızı/verileri elde etmemizi saglayan yapılanmalardır

        #endregion

        #endregion

        #region KEYWORD
        // Programlama dilinin en atomik parcalaridir.
        // derleyici icin on tanımlı olan nerede hangi amaca hizmet edeceği belli kod icerisinde hangi noktalarda
        // cagrılabilceği/kullanılabileceği kurallara sinirlandirilmiş olan anahtar sozcuklerdir
        // Keywordler operatorleri de kapsar 

        #endregion

        #region YARDIMCI MANEVRATIK KOMUTLAR
        // Kodu yonlendırmek ıcın kullanılan komutlardır.
        //for (int i = 0; i < 100; i++)
        //{
        //    if (i == 22)
        //    {
        //        break;
        //    }
        //}
        // manevratık komuylar yapamayacagımız seyleri yapmamızı saglayan kodlar degildir .. Yapabilecegimiz manevraları/kodun yonlendirmelerini daha efektif yapmamizi saglarlar

        #region Break Komutu
        // switch-case ve donguler de kullanılabilir
        // kullanıldıgı yapıdan cıkıs yapılmasını kullanıldıgı yapıyı sonlandırmaya yarayan bir keyworddur.
        //// SWITCH-CASE
        //switch (10)
        //{
        //    case 5:

        //        break;
        //    case 6:
        //        break; 
        //    case 7:
        //        break;
        //}
        //// WHILE
        //while (true)
        //{
        //    break;
        //}
        //// Do-WHILE
        //do
        //{
        //    break;
        //}
        //while (true);
        //// FOR
        //for (int i = 0;i<10;i++)
        //{
        //    break;
        //}
        //// İTERASYON AMA DONGU NITELİGİNDE
        //foreach (var item in new [] { "" })
        //{
        //    break;
        //}

        // İcİce de olur
        //do
        //{
        //    if (true)
        //    {
        //        break;
        //    }
        //} while (true);

        // ORNEK
        // saniye 45 olana kadar ekrana sonsuz dongude yazıp 45 olunca breakle sonlandıran prog
        //while(true)
        //{
        //    if (DateTime.Now.Second==45)
        //        break;
        //    Console.WriteLine(DateTime.Now);
        //}
        // ORNEK
        //for (int j = 0; j < 3; j++)
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (i==1)
        //            break; // sadece icerdeki fordan cıkıs yapacak
        //        Console.WriteLine("i : " + i + " j : " + j);
        //    }
        //}

        // ORNEK
        // Kullanııcı 't' harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulama
        //int toplam = 0;
        //while (true)
        //{
        //    Console.WriteLine("sayı gırn");
        //    string girilenDeger = Console.ReadLine();
        //    if (girilenDeger == "t")
        //    {
        //        Console.WriteLine("toplam sonuc: " + toplam);
        //        break;
        //    }
        //    else
        //    {
        //        toplam += int.Parse(girilenDeger);
        //    }
        //}

        // ORNEK
        // Kullanıcıdan alınan sonsuz adet sayı degerlerınden 37'nin katı girildiginde sonlanan uygulama
        //bool durum = true;
        //while (true) // (durum)
        //{
        //    Console.WriteLine("sayı gırınız");
        //    int sayi = int.Parse(Console.ReadLine());
        //    if (sayi % 37 == 0)
        //    {
        //        Console.WriteLine("program sonlandı");
        //        //durum = !durum;
        //        break;
        //    }
        //}

        #endregion

        #region Continue Komutu
        // Sadece dongulerden erişilebilen ve kullanılabilen bir keyworddur
        // Amacı dongude bir sonraki tura gecilmesini saglar. yani sonraki periyoda direkt gecis yaptırır.

        //for(int i = 0; i<10; i++)
        //{
        //    if (i % 2 == 0)
        //        continue;
        //    Console.WriteLine(i);
        //}

        // ORNEK 1 
        // Kullanıcının girdigi sonsuz adet sayıdan pozitif olanlarını carpan ve 't' girildiğinde sonucu ekrana yazdıran uygulama
        //int toplam = 1;
        //while (true)
        //{
        //    Console.WriteLine("sayı giriniz");
        //    string girilenDeger = Console.ReadLine();
        //    if (girilenDeger == "t")
        //    { 
        //        Console.WriteLine(toplam);
        //        break;
        //    }
        //    else if (int.Parse(girilenDeger) < 0)
        //        continue;
        //    else if (int.Parse(girilenDeger) > 0)
        //        toplam *= int.Parse(girilenDeger);
        //}

        // ORNEK 2
        // 1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazma
        //for (int i = 1; i <= 1000; i++)
        //{
        //    if (i % 7 != 0)
        //        Console.WriteLine(i);
        //    else
        //        continue;

        //    //if (i % 7 = 0)
        //    //    continue;
        //    //Console.WriteLine(i);
        //}


        #endregion

        #region Return Komutu;
        // Her yerde (metot icinde) kullanılabilir, erişilebilir bir keyworddur.
        // İki islevi görmektedir. Nerede cagılıyorsa cagrılsın bulundugu metottan cıkıs yapar. yani metodu sonlandırır.
        // İleride gorecegimiz metotlar konusunda geriye deger dondurme sorumlulugunu da ustlenen bir keyworddur.
        // Returndan sonra hangi komut gelirse gelsin işlenmeyecektir

        // ORNEK
        // Kullanıcı 'c' tusuna basana kadar sonsuz dongude donen uygulama
        //while (true)
        //{
        //    if (Console.ReadKey().KeyChar=='c')
        //    {
        //        Console.WriteLine("\nuygulama sona erdi");
        //        return;
        //    }
        //    Console.WriteLine("\nuygulama calısıyor");
        //}

        #endregion

        #region Goto Komutu
        // Kodun senkronizsyonunu bozup akısı ters ıstıkamette almamızı saglayan bir manevratik komuttur
        // Switch-Case yapılanmasında dahili olarak kullanılan bu komut, metot icerisinde heryerde kullanılabilir

        // Switch-Case Hali
        //switch (sart)
        //{
        //    case 1:
        //        break;
        //    case 2:
        //        goto case 1;
        //}

        /* PROTOTIP 
        a: // baslangıc referansı
        .
        .
        // islemler kodlar vs
        .
        .
        goto a; // tanımlanmıs olan referansa kodun akısını yonlendırıyoruz */

        //a:
        //Console.WriteLine("sdfsad");
        //Console.WriteLine("asdfsads");
        //goto a; // sonsuz dongu gıbı tekrarlanacak

        // ORNEK
        // 1'den 100 kadar sayma
        //int i = 1;
        //x:
        //Console.WriteLine(i++);
        //if (i <= 100)
        //    goto x;

        // KRITIK
        // scope tanımaz ıcınde bulundugu scope dısına da cıkabilir
        //a:
        //for (int i = 0; i < 190; i++)
        //{
        //    goto a;
        //}

        #endregion

        #region Dongulerde Bos Scope Kullanmak Istedigimiz Durumlarda ; Operatorü ile Temiz Kod
        // Sonsuz donguye girmemizi saglar

        // While ile
        //while (true)
        //{   
        //}
        //while (true) ;

        // Do-While ile
        //do
        //{
        //} while (true);
        //do;
        //while (true);

        // For ile 
        //for ( ; ; )
        //{  
        //}
        //for (; ; );

        // Bazen ici bos sonsuz dongulere ıhtıyacımız olablir. Bu durumlarda normal dongu govdelerini
        // kullanabilecegimiz gibi scopesuz bu sekilde de kullanabiliriz.
        #endregion

        #region If Yapısında Bos Scope Kullanmak Istedigimiz Durumlarda ; Operatorü ile Temiz Kod
        //if (true)
        //{ 
        //}
        //if (true) ;

        #endregion

        #endregion

        #region DIZILER - ARRAY
        // Tek bir degisken altında birden fazla "aynı turde" degeri toplamamızı saglayan veri kumelerine dizi denmektedir.
        // Prosedurel programlamanın temel veri kumesidir. Yani yazılımsal boyutta yazılım adına RAM'de birden fazla degeri tek bir
        // - degisken altında bir veri kümesi halinde tutabilrler.
        // Diziler veri kumerleri oldukları icin iclerindeki birden fazla veri uzerinde kumesel islemler yapmamızı saglayabilirler.
        // Diziler prosedurel prog. temel yapılari oldukları icin daha gelismis yapılar olan koleksiyonlarında temelini teskil etmektedirler ve gelismelerine katkıda bulunmaktadır
        // Diziler REFERANS turlu degerlerdir Yani nesnel yapılardır. Ozlerinde CLASS'tırlar
        // Yapısal olarak RAM'de Heap icinde tutulur.

        // -----KRITIK----
        // Dizi ıcerısıne her turlu deger konulabilir(deger-referans turlu).
        // Bir dizi sadece tek bir turde deger alabilir.
        // Dizi icerisinde koyulan degerler ıslevsel olarak aynı mahiyette olamilidir
        // ORN yas dizisine maas bilgisi verilmemelidir, aynı turde oldugu halde verilmemelidir.
        // Diziler icerisine deger/eleman eklendıkce bunları serserı bir sekılde depolamaz duzenli bi sekilde sıralı depolayacaktır
        // Diziler de eklenen elemanlar index ismini verdigimiz numaralarla ardasık bir sekilde numaralandırılır
        // İndex no : Her biri elemana verilen ardasık sayi / 0 dan baslar n-1e kadar gider

        // ----PROTOTIP----
        // type[] a ---> dizi
        // type[] name = new type[....]; // new : bir dizi nesnesi olusturmamızı saglar OOP de detayları inceleyecegiz

        // [] Indexer Operatorü
        // Bir degisken tanımlanırken turunun yanına bu operatoru koyarsak o degısken o turde bır dızı degıskenı olacaktır
        // index, indexer kavramı dizilerden gelir...

        // Type[] a = new Type[5]; // 5 elemanlı type turunde dizi degiskeni
        // int[] yaslar = new int[5];
        // bool[] x = new bool[7];

        // dizi tanımlama surecınde eleman sayısı mecburı gırılmek zorundadır. yani dizide calısacak deger adedi basta bilrdirilmelidir. bu durum sınırlılıktır
        // int[] yaslar = new int[5];

        // Bir dizi tanımlaması yapıldıgı an o dızıyı kullansakta kullanmasakta verilen eleman sayısı kadar alan tahsısı bulunur
        // Dizilerde tanımlama yapıldıgı an alan tahsısınde bulunbması bizim icin pekte dogru bir durum degildir.
        // Kullanılmadıgı halde diziler direkt olarak bellekten belirtilen eleman sayısı kadar alan tahisisinde bulunması bir sınırlılıktır
        // Diziler alan tahsisi yapıldıgında ilgili alanlara turune uygun default degerleri atarlar.

        //int[] yaslar = new int[7];
        //yaslar[0] = 4; // Tanımlanmıs diziye deger atama
        //yaslar[1] = 5;
        //yaslar[2] = 6;
        //yaslar[3] = 7;
        //yaslar[4] = 8;
        //yaslar[5] = 9;
        //yaslar[6] = 10;
        //Console.WriteLine(yaslar[6]); // Tanımlanmıs diziden deger okuma

        #region Sınırlılıklar
        // Diziler de taınmlama yaparken eleman sayısının bıldırılmesı zorunlulugu bir sınırlılıktır
        // Diziler tanımlandıgında kullansakta kullanmsakta bellekte belirtilen eleman sayısı kadar alan tahsisinde bılunurlar.
        // - bu durum bellek boyunda ekstradan maliyete sebep olacagı icin bir sınırlılıktır.
        // Dizilerde eleman sayısının basta belirlenmesi durumunda, ihtiyaca binayen daha fazla deger atamak ıstedımızde
        // - bu degerlerı atayamayacagımızdan ve dizinin aralıgını genişletemeyecegimizden dolayı bu durum bir sınırlılıktır
        // Dizilerde elemanlara deger atarken indexer opr. ile cok hasır nesir olunmakta bu ise bir sınırlılıktır.

        #endregion

        #region Tanımlanmıs  Dizi İcerisinde Donguyle Donme
        // Diziler genellikle dongulerle birlikte algoritmalarda kullanılmaktadırlar
        // Donguler de genellıkle dizilerde yada ileride gorecegimiz koleksiyonlarla goruelebilir

        //string[] personeller = new string[10];
        //personeller[0] = "ahmet";
        //personeller[1] = "mehmet";
        //personeller[2] = "yunus";
        //personeller[3]= "emre";
        //personeller[4] = "seyma";
        //personeller[5] = "ala";
        //personeller[6] = "fati";
        //personeller[7] = "yusuf";
        //personeller[8] = "berat";
        //personeller[9] = "fırat";

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(personeller[i]); // i sayısı arttıkca personel index sayısı da degisecek ve dongu dondukce her elemanı yazacak
        //}

        //int i = 0;
        //while (i < 10)
        //{
        //    Console.WriteLine(personeller[i++]);
        //}

        // dizi icerisinde donecek olan dongu kombinasyonunda dizinin eleman sayisini manuel bir sekilde kullanmamalı, bu sayısal degeri dizinin kendisinden almalıyız
        //for (int  i = 0;  i <personeller.Length;  i++)
        //{
        //    Console.WriteLine(personeller[i]);
        //}   

        #endregion

        #region Dizi Tanımlama Varyasyonları
        // ---- 1
        //int[] yaslar = new int[6];
        //yaslar[0] = 2;
        //yaslar[1] = 4;
        //Console.WriteLine(yaslar[2]);

        // ---- 2
        //int[] yaslar2 = { 32, 43, 56, 87, 22 };
        //string[] isimler = { "yunus", "emre", "seyma", "sdfg", "gdfg" };

        // ---- 3
        //string[] isimler2 = new string[] { "yunus", "emre", "seyma", "sdfg", "gdfg" };

        // ---- 4
        //string[] isimler3 = new string[3] { "yunus", "emre", "seyma" }; // eleman sayısı belirtildigi icin ne eksik ne fazla eleman girilebilir.

        // ---- 5 !! ÖNEMLİ
        //int[] sayilar4 = new[] { 3, 5, 7 };
        //var sayilar5 = new[] { 3, 5, 7 };

        #endregion

        #region Array Sınıfı
        // Dizi olarak tanımlanan degıskenler Array sınıfından turetılmektedırler
        // Dolayısıyla dizilerden Array sınıfından gelen belirli metotlar ve ozellıkler mevcuttur.
        //int[] yaslar = new int[6];   // bir dizi eger kendi turunde tutuluyorsa indexer opr kullanılablilir.
        // --bu sekilde calısıldıgında ilgili diziye verisel mudahaleler operatıf ( [] ) gercekleştırılırken           
        // Genellikle bu format algoritmalarda tercih edilir. Cunku indexer algoritmalarda cok kullanılır.
        //Array yaslar = new int[6];   // Yok eger dizi array turunde referans ediliyosa indexer opr kullanılamaz.
        // --Bu sekilde ise fonksiyonel cozumler getirilmektedir
        // Genellikle elimzideki dizinin uzerinde islem yaparken tercih edilen formattır. Dizi hakkında bilgi edinirken vds kullaınılır.

        /* Array Turunden Dizilere Deger Atama / Okuma
        //Array dizi = new int[4];
        //dizi[2]= 34; // hata alır burada

        // ---- 1
        //int[] dizi = new int[3];
        //dizi[0] = 232;
        //dizi[1] = 324;
        //dizi[2] = 432;
        //Array dizi2 = dizi;

        // ---- 2
        //Array dizi = new int[] { 3, 4, 6, 7 };
        //Array dizi = new int[3] { 3, 4, 5 };
        //Array dizi = new[] { 3, 4, 5, 7, 8 };
        // Array dizi = { 2, 3, 4, 5 }; // KULLANILAMAZ

        // ---- 3 
        //Array dizi = new int[3];
        //dizi.SetValue(23, 2); // 2. index'li elemana 23 degerini atayacak
        //dizi.SetValue(34, 0);
        //dizi.SetValue(21, 1);

        // OKUMA
        //object value = dizi.GetValue(1);
        //Console.WriteLine(value); */

        #region Metotlar
        // Array isimler = new[] { "yunus", "emre", "seyma", "asdf", "beren" };

        #region Clear
        // Dizi icerisindeki tum elemanları siliyor diye biliniyor ama bu yanlıstır. Dizi icerisndeki tum elemanlara,
        // dizinin turune uygun default degerleri atayan bir fonksiyondur

        //for (int i = 0; i < isimler.Length; i++)
        //    Console.WriteLine(isimler.GetValue(i));
        //Array.Clear(isimler, 0, isimler.Length); // isimler arrayinde 0.elemandan baslayıp isimler eleman sayısı kadar sıra sil. isimler.lenght yerine 3 yazılsa 0dan 3.elemana kadar default deger verecek. 3.elemanı da kapsar tabi
        //        // (isimleri, 1, 3) // orn isimler dizisinde 1.indexli elemandan basla, 3.indexli elemana kadar default deger ver 
        //Console.WriteLine("*************************");
        //for (int i = 0;i < isimler.Length;i++)
        //    Console.WriteLine(isimler.GetValue(i));

        #endregion

        #region Copy
        // Elimizdeki bir dizinin bir baska diziye kopyalamamızı saglayan bir fonksiyondur
        //string[] isimler2 = new string[isimler.Length];

        //Array.Copy(isimler, isimler2, 5);
        //for (int i = 0; i < isimler2.Length; i++)
        //    Console.WriteLine(isimler2[i]);

        //Array.Copy(isimler, 2, isimler2, 0,2); // isimler 2.indexten itibaren al, isimler2 dizisine kopyala, 0.indexten basla, 2.indexten itibaren kac tane eleman alsın=2tane
        //for (int i = 0; i < isimler2.Length; i++)
        //    Console.WriteLine(isimler2[i]);


        #endregion

        #region IndexOf
        // Dizi icerisinde bir elemanınn var olup olmadıgını sorgulayabildigimiz fonksiyondur
        // Arama neticesinde ilgili deger varsa int olarak o degerin index numarısını dondurecektir
        // yoksa -1 degerini dondurur.

        //int index = Array.IndexOf(isimler, "yunus");
        //if (index != -1)
        //{
        //    Console.WriteLine("mevcut"); // demekki aranan deger ilgili dizide bulunmaktadır
        //}

        //int index = Array.IndexOf(isimler, "yunus", 0, 3); // isimler dizisinde 0.index ile 3.index arasında yunus degerini arar

        #endregion

        #region Reverse
        // Elimizdeki dizinin elemanlarını tersine sıralayan bir fonksiyondur

        //for (int i = 0; i < isimler.Length; i++)
        //    Console.WriteLine(isimler.GetValue(i));

        //Array.Reverse(isimler); // butun dizi elemanları sıralamasını tersine cevirdi
        //Console.WriteLine("********************");

        //for (int i = 0; i < isimler.Length; i++)
        //    Console.WriteLine(isimler.GetValue(i));

        //Array.Reverse(isimler, 0, 3); // isimler dizisinde 0.index ile 3.index arasındakileri ters sıralar 0 ve 3 de dahil.
        //for (int i = 0; i < isimler.Length; i++)
        //    Console.WriteLine(isimler.GetValue(i));

        #endregion

        #region Sort
        // Elimizdeki dizinin sıralamasını kucukten buyuge sıralayan fonksiyondur.

        //for (int i = 0; i < isimler.Length; i++)
        //    Console.WriteLine(isimler.GetValue(i));

        //Array.Sort(isimler);
        //Console.WriteLine("--------------------");

        //for (int i = 0; i < isimler.Length; i++)
        //    Console.WriteLine(isimler.GetValue(i));

        #endregion

        #endregion

        #region Ozellıkler
        //Array isimler = new[] { "yunus", "emre", "seyma", "asdf", "beren" };

        #region IsReadyOnly
        // bir dizinin sadece okunabilir olup olmadıgını bildiren bir ozelliktir.
        //Console.WriteLine(isimler.IsReadOnly);

        #endregion

        #region IsFıxedSize
        // bir veri kumesinin eleman sayısının sabit olup olmama durumunu bu fonk ile oğrenebiliriz
        // tum dizilerde eleman sayısı sabit olduu icin surekli true donecektirç ornegin ArrayList koleksiyonunda false doner.
        //Console.WriteLine(isimler.IsFixedSize);

        #endregion

        #region Length
        // Bir dizinin eleman sayısını getirir
        //Console.WriteLine(isimler.Length);

        #endregion

        #region Rank
        //int[,,] x = new int[3, 4, 5]; // virgüle göre rank/derece belirler virgül sayısına gore artar. [,] 2 rank [,,] 3 rank gibi
        //Console.WriteLine(isimler.Rank); // 1 degeri verir
        //Console.WriteLine(x.Rank); // 3 degeri verir

        #endregion

        #endregion

        #region CreateInstance Metodu ile Dizi Tanımlama
        //int[] yaslar = new int[3];
        // Normalde yukarıdaki gibi yapılan dizi tanımlaması esasında arkaplanda array sınıfının CreateInstance Metodunu kullanır 
        // -- bizlerde bu metodu kullanarak fonksiyonel diziler olustuırabilmekteyiz
        //Array yaslar2 = Array.CreateInstance(typeof(int), 3);
        #region CreateInstance Cok Boyutlu Dizi Tanımlama
        //Array dizi = Array.CreateInstance(typeof(int), 5, 7, 5, 8); // 4 dereceli int turunde dizi adında bir array 
        //Console.WriteLine(dizi.Rank);
        #endregion
        #endregion

        #endregion

        #region Range and Indices (C# 8.0)

        #region System.Index
        // Dizi ve koleksiyon yapılarondaki index kavramını tip olarak belirlenmiş halidir.
        // Temelde bir degerini bir tur ile tutmakla beraber ^ operatoruyle birlikte daha fazla anlam ifade etmekte ve
        // --dizinin index degerlerini tersine ifade edecek şekilde bir sorumluluk yüklenmektedir.

        //Index i = 3; //       0 - 1 - 2 - (3) 
        //Index i2 = ^3; //    (3) - 2 - 1  // tersine ifadesinde 0 yoktur

        //string[] isimler = { "yunus", "emre", "seyma", "beren" };
        //Index index = 3;   //   0       1        2        3

        //string[] isimler2 = { "yunus", "emre", "seyma", "beren" };
        //Index index2 = ^3;  //           3        2        1            

        //Console.WriteLine(isimler[index]);
        //Console.WriteLine(isimler2[index2]);

        #endregion

        #region System.Range
        // Veri kumelerinde hangi degerler ile calısacagımızı belirleyebilmek icin index üzerinden aralık vermemizi ve
        // --bunu .. operatoruyle  gerceklestirmemizi saglayan yapılanmadır

        //// -- 1 -->       0 (1) 2  3  4  5  6  7  8   9  10 11 
        //int[] sayilar = { 2, 5, 2, 7, 8, 3, 8, 5, 32, 6, 8, 4 };
        //// -- 4 -->       1  2  3 (4) 5  6  7  8  9   10 11 12   // 1 - 1.indexi temsil ederken 7 sıra no temsil eder yani 0'dan baslamaz
        //Range r = 1..4;
        //Console.WriteLine(sayilar[r]);


        //// -- 1 -->       0 (1) 2  3  4  5  6  7  8   9  10 11 
        //int[] sayilar2 = { 2, 5, 2, 7, 8, 3, 8, 5, 32, 6, 8, 4 };
        //// -- 4 -->       12 11 10  9  8  7  6 (5)  4  3  2  1   // 1 - 1.indexi temsil ederken 4 sıra no temsil eder yani 0'dan baslamaz
        //Range r2 = 1..^4; //                  ( 5<--4'ten oncekine kaydı )
        //// ..'nın sagında tersine alınırsa bir oncekine kayacaktır. aynı islem sol icin gecerli degildir
        //Console.WriteLine(sayilar2[r2]);

        //Range r3 = ..;  // tum diziye karsılık gelir
        //var sayilar3 = sayilar[r3];    // sayilar dizisini sayilar3 degiskenine kopyaladı.
        //sayilar3[0] = 333;               // --dolayısıyla sayilar3 dizisinde yapılan herhangi bir degisiklik sayilar dizisini etkilemez. 2 ayrı diziler cunku...

        //Index i1 = 5, i2 = 2; // int koyulabilir ama aradaki fark aritmetik islemler yapılamaz index ile
        //Range r4 = i1..i2;
        //// var sayilar4 = sayilar[r4];
        //var sayilar4 = sayilar[i1..i2]; // direkt burayada yazılabilir.

        #endregion

        #endregion

        #region Cok Boyutlu Diziler
        // Cok boyutlu dızıler oyun prog.da yahut yuksek ıstatıksel calısmalarda kullanılan bır yapıdır
        // tek boyutlu tanımlama = type[]       ||       cok boyutlu tanımlama = type[,,,] 3 virgül yani 4 boyutlu
        // Virgül sayısının +1 fazlası derece sayısını verecektir.
        //int[,,,] sayilar = new int[3,4,5,7];

        #region Cift/2 Boyutlu Deger Atama
        // Koordinat düzleminde 1.boyut x, 2.boyut y olarak ele alınır
        //int[,] sayilar = new int[3, 4]; // 1.boyut = 3 elemanlı  ||  2.boyut = 4 elemanlı
        //sayilar[1, 2] = 1;  // 1.boyutun 1.indexi ve 2.boyutun 2.indexindeki deger = 1
        //sayilar[2, 0] = 2;  // 1.boyutun 2.indexi ve 2.boyutun 0.indexindeki deger = 2
        #endregion

        #region Cok Boyutlu Deger Atama
        // -- 4D
        //int[,,,] sayilar = new int[2, 3, 4, 5];
        //sayilar[0, 0, 0, 0] = 1;
        //sayilar[0, 0, 0, 1] = 2;
        //sayilar[0, 0, 0, 2] = 3;
        //sayilar[0, 0, 0, 3] = 4;
        //sayilar[0, 0, 0, 4] = 5;
        //sayilar[1, 0, 0, 0] = 1;

        // -- 3D
        //int[,,] sayilar = new int[2, 3, 4];
        //sayilar[0, 0, 1] = 15;

        // Farklı bir varyasyon
        //int[,] sayilar =
        //{
        //    {3, 5, 4},
        //    {8, 9, 3},
        //    {4, 2, 7},
        //    {5, 1, 6}
        //};
        //Console.WriteLine(sayilar[2,1]); // cıktı 2
        //Console.WriteLine(sayilar[3,2]); // cıktı 6
        //Console.WriteLine(sayilar.Rank); // kac dereceli dizi oldgunu soyler
        //Console.WriteLine(sayilar.Length); // dizinin tum derecelerindeki eleman sayılarını carpınca toplam eleman sayısını verir
        //Console.WriteLine(sayilar.GetLength(2));// 2.indexli boyutun eleman sayısını verecek // Cok boyutlu dizilerde belirli bir boyuttaki eleman sayısını getirir.

        #endregion

        // Cok Boyutlu Dizilerde Verileri İcİce Dongulerle Ekrana Yazma
        //int[,,] sayilar = new int[2, 2, 4];
        //sayilar[0, 0, 0] = 1;
        //sayilar[0, 0, 0] = 2;
        //sayilar[0, 0, 0] = 3;
        //sayilar[0, 0, 0] = 4;
        //sayilar[0, 0, 0] = 5;
        //sayilar[0, 0, 0] = 6;
        //sayilar[0, 0, 0] = 7;
        //sayilar[0, 0, 0] = 8;
        //sayilar[0, 0, 0] = 9;
        //sayilar[0, 0, 0] = 10;
        //sayilar[0, 0, 0] = 11;
        //sayilar[0, 0, 0] = 12;
        //sayilar[0, 0, 0] = 13;
        //sayilar[0, 0, 0] = 14;
        //sayilar[0, 0, 0] = 15;
        //sayilar[0, 0, 0] = 16;

        //for (int i = 0; i < sayilar.GetLength(0); i++)
        //{
        //    for (int j = 0; j < sayilar.GetLength(1); j++)
        //    {
        //        for (int h = 0; h < sayilar.GetLength(2); h++)
        //        {
        //            Console.Write(sayilar[i, j, h] + "          ");
        //        }
        //        Console.WriteLine("");
        //    }
        //}

        #endregion

        #region Duzensiz Diziler
        // Duzensız diziler  her bir elemanı kendi icerisnde farklı bir dizi barındıran dizilerdir.
        // Cok boyutlu dızılerden tek farkı, cok boyutlu dızılerın sutun sayıları sabıt halbuki duzensız dizilerin sutun sayısının degisken olmasıdır

        // tpye[][] type dizisi turunde degerler tutacak bir dizi tanımlamıs oluyoruz

        //int[][] sayilar = new int[3][]; // 'int dizisi' turunde 3 elemanlı dizi, her indexte ayrı dizilere sahip
        //sayilar[0] = new int[3] { 3, 4, 5 }; // 0.indexli eleman dizisinin 3 elemanı
        //sayilar[1] = new int[5] { 6, 7, 8, 9, 10 }; // 1.indexli eleman dizisinin 5 elemanı
        //sayilar[2] = new int[8] { 11, 12, 13, 14, 15, 16, 17, 18 }; // 2.indexli eleman dizisinin 8 elemanı


        #region Dizi İcerisnde Dizi Okuma/Deger Atama
        //Console.WriteLine(sayilar[0][0]); // 0.indexli eleman dizisinin 0.indexli elemanını ekrana yazar
        //sayilar[0][0] = 13; // 0.indexli eleman dizisinin 0.indexli elemanını '13' olarak degistirir.
        //Console.WriteLine(sayilar[0][0]); // tekrar degisen 0.indexli eleman dizisinin 0.indexli elemanını ekrana yazar

        //Console.WriteLine(sayilar.Length); // Duzensiz dizinin eleman sayısını getirir. Bu bize total eleman sayısını vermez. Cok boyutlu dizilerde oldugu gibi duzensiz diziler
        // --başlı başına farklı bir dizi yapısı degildir. Normal dizi yapılanmasıdır, lakin icerisinde dizi barındıran bir dizidir. Haliyle eleman sayısını dondurur.
        // İçteki dizilerin eleman sayılarını totalde elde edebilmek icin herbirini toplamamız gerekmektedir.
        //Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length);

        #endregion

        #region Düzensiz Dizilerde İcİce Dongulerle Calısma

        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    for (int j = 0; j < sayilar[i].Length; j++) // sayilar dizisinin i.indexli dizisinin eleman sayısı kadar
        //    {
        //        Console.WriteLine(sayilar[i][j] + "   -   ");
        //    }
        //}

        #endregion

        #endregion

        #endregion

        #region STRING NEDİR?
        // String referans turlu oldugu halde programlama dilinde bir keyword barındıran tek degerdir
        //int a = 5;          // STACKT'te (int) a = 5 seklinde tutulur
        //string b = "yunus"; // STACK'te (string) b, HEAP'te (yunus) seklinde tutulur
        #region Null - Empty Durumları, Farkarı
        // -- NULL --
        // Bir degisken/nullable/referans eger ki null alıyorsa bur durum ilgili degiskenin herhangi bir alanı tahsis etmedigi anlamına gelir.
        // Deger turlu degıskenler null alamazlar sadece referans turler alabilr
        // Deger turlu degıskenlerin null alabilmeleri icin nullable(?) olmaları gerekmektedir
        // Bellekte yer kaplamaz.
        // Null olan bir deger üzerinde islem yapmak istenirse run-time'da hata alınır
        //int? c = null;
        //string d = null; // referans turlu oldugu ıcın direkt null alabilir

        // -- EMPTY --
        // Bir degisken nullable referans eger ki empty ise bu degiskenin degeri yok anlamına gelir, lakin alan tahsisinde bulunulmustur.
        // Tum degerler empty atanabilir. Alan tahisinde bulunduktan sonra ilgili alana bir deger koymamak empty durumudur
        // Default degerlerin oldugu durumlar empty olarak gecerler.
        // Her ne kadar deger olmasada bellekte yer kaplayacak ve bir alan tahsisinde bulunacaktır.
        // Empty olan bir deger üzerinde islem yapılabilir.

        //int e = 0; // default deger 0, empty olarak gorulebilir.
        //bool f = false; // default deger false, empty olarak gorulebilir
        //int[] g = new int[55]; // 55 elemanlı bir dizi ama elemanlar bos yani alan tahsisi var fakat deger yok yani empty

        //string h = null; // ici boş fakat alan tahsisi yok
        //string i = "";   // ici boş fakat alan tahsisi var, empty
        //string j = string.Empty; // strin degiskenini empty yapmak istiyorsan üstteki satırdaki gibi veya bu sekılde yapabilirsin.

        #endregion

        #region IsNullOrEmpty
        // Elimizdeki string ifadelerin isleme tabi tutulmadan once kesinlikle kontrol edilmesi gerekmektedir
        //string x = "";
        //if (x!=string.Empty && x is not null)
        //{
        //    // operasyon
        //}

        //// IsNullOrEmpty fonksiyonu elimizdeki string ifadenin null olup olmama dırumları hakkında bir check yapar ve geriye bool turde sonuc doner
        //// Eger ki deger null ya da empty ise geriye true, degilse false donecektir.
        //if (string.IsNullOrEmpty(x))
        //{

        //}

        #endregion

        #region IsNullOrWhiteSpace
        // IsNullOrWhiteSpace fonksiyonu elimizdeki string ifadenin null empty yahut bosluk karakterlerinden ibaret olma durumunda geriye bool true degerini donduren bir fonksiyondur.
        //string x = "      ";  // null/string.Empty/"" gibi degerleri de kontrol eder.. farklı bir deger girilmişse eger aynı sart bloguna degil (!) operatoru ekleyerek sonucu elde edebilirsiniz.
        //if (string.IsNullOrWhiteSpace(x))
        //{

        //}

        #endregion

        #region String RAM(Heap) Ilıskısı
        //string x = "fgdsfg";
        #endregion

        #region String - Char Dizisi
        // String ifadeler esasında bir Char dizisidir. Yani yazılım acısından string ifade yoktur! Esasında karakterlerin bir araya gelmis hali vardır.
        // Dolayısıyla karakterleri bir araya getirebilecek yegane sey bir dizidir. String ifadeler yazılımsal acıdan bilgisayarda bir char dizisi olarak tarif
        // --edilmekte ve o sekilde tutulmaktadır.
        // String ifadeler ozunde bir char dizisi/yani dizi olmasından dolayı referans turlu degiskenlerdir. Cunku diziler referans turludurler. Yani nesnedirler.
        // --yani heap'te tutulurlar

        //string metin = "sebepsiz boş yere ayrılacaksın...";
        //// strin ifadeler char dizisi olduklarından dolayı yapısal olarak her bir karakter bastan sona otomatik indexlenmektedir.

        //Console.WriteLine(metin[3]);

        //Array array = metin; // String ozunde bir char dizisi olablir ama velakin yapısal olarak yine de string oldugu icin Array referansına atılamaz. Array ile karsılanamaz

        #region  Dongulerle String Metin İcindeki Her Bir Karaktere Ulasma
        //string metin = "sebebsiz bos yere ayrılacaksın";
        // FOR
        //for (int i = 0; i < metin.Length; i++)
        //{
        //    if (metin[i]=='e')
        //        Console.WriteLine(i + " : " + metin[i]);
        //}

        // DoWHILE
        //int i = 0;
        //do
        //{
        //    if ('e' == metin[i])
        //        Console.WriteLine(i + " : " + metin[i]);
        //    i++;
        //} while (i < metin.Length);

        #endregion

        #endregion

        #region String İfadelerde + Operatoru
        // + operatoru string bir ifadeyle herhangi bir turdeki ifadeleri isleme tabi tutarken object + string davranısı sergiler
        //herhangi bir ifadeyi stringe donusturmek icin o ifadeyi + "" ile isleme tutmak yeterlidir.
        //int a = 4;
        //string b = "merhaba";
        //var sonuc = a + b; // string deger dondurur gerıye
        //Console.WriteLine(3 + 5 + 8 + 4 + "hey"); // aritmetik islemi yapıp (sonuc 20) hey ifadesi ile beraber ekrana string ifade olarak yazacak -- 20 hey --

        #endregion

        #region String Formatlama
        //string isim = "gencay", soyisim = "yıldız", tcNo = "12345679898";
        //int yas = 29;
        //bool medeniHal = true;
        //Console.WriteLine("TC No : " + tcNo + " olan " + isim + " " + soyisim + " sahsın bilgileri | Yas : " + yas + " | Medeni Hal : " + (medeniHal ? "evli" : "bekar"));
        // + opr ile string formatlama operasyonu hem kod hem de performans acısından cok maliyetlidir bu yuzden cok fazla tercih etmeyiz.

        #region string.Format
        // String.Format fonkisyonu metinsel kalibin icerisindeki indexel beilrlenen noktalara sırasıyla deger gondermemizi saglayan bir fonksiyondur.
        //string sonuc = string.Format("TC No : {0} olan {1} {2} sahsın bilgileri | Yas : {3} | Medeni Hal : {4}", tcNo, isim, soyisim, yas, medeniHal ? "evli" : "bekar");
        //Console.WriteLine(sonuc);

        #endregion

        #region $ (String Interpolation) (C# 6.0) 
        // String Intepolation string ifadenin icersinde suslu parantez ile araya girerek programatik bir degiskenin degerini bırakmamızı/eklememizi saglayan bir operatordur
        // Bir String degerin basına $ isareti konulursa bu ifadenin icerisinde Strin Interpolation operasyonunun/operatorunun kullanılabilrliği saglanır. Yani ilgili string icerisndeki
        // --{} suslu parantezler bir ınterpolation ozellıgı sergıler.

        //Console.WriteLine("TC No : .............. olan ...... ...... sahsın bilgileri | Yas : .. | Medeni Hal : .....");
        //Console.WriteLine($"TC No : {tcNo} olan {isim} {soyisim} sahsın bilgileri | Yas : {yas} | Medeni Hal : {(medeniHal ? "evli" : "bekar")}");
        //Console.WriteLine($"TC No : {4+5} olan {"yunus"} {soyisim} sahsın bilgileri | Yas : {23} | Medeni Hal : {(medeniHal ? "evli" : "bekar")}");

        // Ternary operatoru kullanılacaksa parante icinde kullanılmalı
        // String Interpolation, yapısal olarak arkaplanda string.Format fonksiyonuyla sekillenen bir operatordur
        // String Interpolation kullanılan string ifadelerde metinsel olarak {} suslu parantez kullanmak ihtiyacı durumunda operatif olan suslu parantezleri yine aynı operatorle ezerek metinsel hale getirebiliriz orn-{{}}
        //Console.WriteLine($"{{cicek}} TC No : {tcNo} olan {isim} {soyisim} sahsın bilgileri | Yas : {yas} | Medeni Hal : {(medeniHal ? "evli" : "bekar")} {{yunus}} ");

        #endregion

        #endregion

        #region String Kacıs Karakterleri ( \ Backward Slash)
        //Console.WriteLine("\"bdfgdfg\"");
        // kendisinden sonra gelen karakterin metinsel bir ifade oldugunu ifade eder
        //Console.WriteLine("sdfsad\\fsadf"); // Slashı metin icinde kullanmak istersek yine kendisiyle ezerek kullanılır
        //Console.WriteLine("\a"); // bip sesi cıkarır
        //Console.WriteLine("dfg\tsgfsag\tfgdfsgd\tdfgdg"); // tab olusturmak ıcın kullanılır
        //Console.WriteLine("sdfg\b"); // kendisinden onceki ifadeyi siler
        //Console.WriteLine("sdfs\nfsafsdaf"); // altsatıra iner
        //char c = '\''; // ' karakterini girebilmek icin de kullanılabilir
        // Gordugunuz uzere enter, satır, sonuc vs. gibi dogrudan klavye tarafından girilemyen bazı tusları olusturmak ıcınde kullanlabilir

        #endregion

        #region @(Verbatim Strings) Operatoru
        #region 1.Kullanımı
        //int a = 3;
        //int @void=5;
        //int @class= 3;
        //string @namespace="fdg";
        //metot vs tanımlarken de kullanılabilir
        //void @void()
        //{
        //}
        #endregion

        #region 2.Kullanımı
        // Escape karakterlerinin kullanılması ıcap eden durumlarda @ opr kullanarak eylemsel karakterleri kendileriyle ezebilecek ozellik kazandırabiliyoruz
        //string metin = "hava cok \"güzel\""; // kacıs operatoru ile
        //string metin2 = @"hava cok ""güzel"""; // eylemsel karakteri kendisi ile ezerek @ operatoru sayesinde
        #endregion

        #region 3.Kullanımı
        //string metin = "sdafsadfsaf
        //    sdfsadfasdf
        //    sdfsafsadfsda";
        // C#'da string ifade birlestirilmeden altalta yazılamaz

        //string metin2 = @"sdfsadf
        //sadfasdfa
        //sfadasdfsdfsadf";
        // Yazabilmek icin @(Verbatim) operatoru kullanabiliyoruz.

        //string metin3 = "sadfasdfsaf" +
        //    "sadfsafasdf" +
        //    "sdfasddfhdh";
        // -- yada metinsel birleştırme yapılabilir.

        #endregion

        #endregion

        #region String Interpolation İle Verbatim Strings Birlikteliği (C# 8.0)
        //string isim="Yunus", soyisim="Cicek", siparisNo="234224";
        //int fiyat=240;

        //string mailMessage = @$"Merhaba {isim} {soyisim},
        //{siparisNo} nolu siparis talebiniz tarafımızca alınmıstır.
        //Fiyat : {fiyat}";
        //Console.WriteLine(mailMessage);
        // $ string ınterpolation ile string ifadeler arasına direkt olarak parametreleri cagırabildik
        // @ vebratim opr ile de uzun bir satır yerine gozumuzun daha iyi anlayabileceği sekilde yine aynı kodu yazdık daha okunabilir oldu bizim icin

        #endregion

        #region String Fonksiyonları
        //string metin = "laylaylom galiba sana göre sevmeler...";

        #region Contains
        //bool sonuc = metin.Contains("sana"); // metin degiskeninde sana kelimesini arayacak ve sonucu bool donecektir
        // S harfi buyuk olsaydı eger false donecekti cunku C# buuyk kucuk harf duyarlılıgına sahiptir.
        //Console.WriteLine(sonuc);
        #endregion

        #region StartsWith
        //Console.WriteLine(metin.StartsWith("laylay")); // laylay ile baslayıp baslamadıgını kontrol eder bool deger doner gerıye
        #endregion

        #region EndsWith
        //Console.WriteLine(metin.EndsWith("...")); // ... nokta ile bitip bitmedigini kontrol eder
        #endregion

        #region Equals
        // Elimizdeki metinsel ifade ile herhangi bir ifadenin degersel olarak esıt olup olmadıgını check eden ve gerıye bool sonuc donen bir fonks
        //Console.WriteLine(metin.Equals("laylaylom galiba sana göre sevmeler"));
        #endregion

        #region Compare
        // Metinsel ifadeleri karsılastırmamızı ve sonuc olarak int turde deger elde etmemızı saglar.
        //  0 : her iki deger esit
        //  1 : soldaki sagdakinden alfanumerik olarak büyük
        // -1 : soldaki sagdakinden alfanumerik olarak kücük

        //Console.WriteLine(string.Compare(metin, "Z"));
        //Console.WriteLine(string.Compare(metin, "a"));
        //Console.WriteLine(string.Compare(metin, metin));

        //Console.WriteLine(string.Compare(metin,9,metin,8,5));
        // metinin 9.indexteki degerini al, metinin 8.indexteki degerini al ve her ikisinde 5 tane karakter al

        #endregion

        #region CompareTo
        // Metinsel ifadeleri karsılastırmamızı ve sonuc olarak int turde deger elde etmemızı saglar.
        //Console.WriteLine(metin.CompareTo("z"));
        //Console.WriteLine(metin.CompareTo("a"));
        //Console.WriteLine(metin.CompareTo(metin));
        #endregion

        #region IndexOf
        // Verilen degerin string ifade icerisinde olup olmamasını geriye int donduren bir fonk.
        // geriye index nosunu int olarak dondurur. hic yoksa -1 degeri verir
        //Console.WriteLine(metin.IndexOf("la"));
        //Console.WriteLine(metin.IndexOf("lay"));
        //Console.WriteLine(metin.IndexOf("La"));
        //Console.WriteLine(metin.IndexOf("sana"));
        // IndexOf ilk eslesen degerin indexini dondurecektir
        #endregion

        #region Insert
        // Elimizdeki metinsel ifadeye bir deger dahil etmemizi, eklememizi saglayan bir fonksiyondur.
        //string eklenmisMetin = metin.Insert(17,"merhaba ");
        // İlgili ekleme operasyonu gerceklestıkten sonra eklenmis hali, strinbg olarak dondurelecektir.
        // --lakin metin orijinal verisi ayrı bir sekilde tutulacaktır. Yani donen eklenmıs veriyle var olan metin arasında fark vardır. 
        //Console.WriteLine(metin);
        //Console.WriteLine(eklenmisMetin);
        #endregion

        #region Remove
        // Metinsel ifadede indeksel olarak verilen deger aralıgını silen bir fonk.dur
        //Console.WriteLine(metin.Remove(2)); // 2.indexten sonraki tum degerleri silecektir
        //Console.WriteLine(metin.Remove(2,10)); // 2.indexten sonraki 10 degeri sil
        // insertte oldugu gibi ilgili foksiyonun yapmıs oldugu islem neticesinde yeni deger i üreterek bizlere string olarak dondurelecektir.
        // Elimizdeki Orijinal veri degismeyecektir.
        //Console.WriteLine(metin);
        #endregion

        #region Replace
        // Elimiizdeki metinsel ifadede belirtilen degerleri yahut karakterleri, beilrtilen diger degerler yada karakterlerle degistirmemizi saglayan fonk.
        // Sonuc olarak string deger uretecek ve geriye dondurecektir
        //Console.WriteLine(metin.Replace('a','b'));
        //Console.WriteLine(metin.Replace("la","lo"));
        #endregion

        #region Split
        // Metinsel ifadeyi verilen degeri ayrac olarak kullanıp parcalayan ve sonucu string dizisi olarak donduren bir fonk.
        //string[] dizi = metin.Split(' '); // bosluk gordugu yerde parcalayıp, parcayı dizi elemanı olarak atayacak
        //string[] dizi = metin.Split(' ', 'a'); // bosluk ve a gordugu yerde parcalayıp, parcayı dizi elemanı olarak atayacak
        #endregion

        #region Substring
        // Metinsel ifadenin belirli bir aralıgını elde edip calısmamızı saglar.
        //Console.WriteLine(metin.Substring(5)); // 5.indexten sonuna kadar tum degerleri getir
        //Console.WriteLine(metin.Substring(5,10)); // 5.indexten basla 10 deger getir
        #endregion

        #region ToLower
        //// Elimizdeki tum metinsel degerleri kucuk karakter olarak duzenler
        //Console.WriteLine(metin);
        //Console.WriteLine(metin.ToLower());
        #endregion

        #region ToUpper
        // Elimizdeki tum metinsel degerleri buyuk karakter olarak duzenler
        //Console.WriteLine(metin);
        //Console.WriteLine(metin.ToUpper());
        #endregion

        #region Trim
        // Met,nsel ifadelerin varsa solundaki ve sagındaki bosluk karakterlerini temizleyen fonkdur
        //Console.WriteLine("yyyyy ccccc");
        //Console.WriteLine("     yyyyy ccccc    ".Trim());
        #endregion

        #region TrimEnd
        //Console.WriteLine("yyyyy ccccc");
        //Console.WriteLine("     yyyyy ccccc    ".TrimStart());
        #endregion

        #region TrimStart
        //Console.WriteLine("yyyyy ccccc");
        //Console.WriteLine("     yyyyy ccccc    ".TrimStart());
        #endregion

        #region String Fonksiyonları ORNEKLER
        // -- 1 --  Adımızın ilkten 3 soy adımızın sondan 5.karakterini getirme

        // cozum 1
        //string isim ="Yunus Cicek";
        //Console.WriteLine(isim[2]);
        //Console.WriteLine(isim[isim.Length - 5]);

        //// cozum 2
        //string aralık = isim[2..^4];
        //Console.WriteLine(aralık[0]);
        //Console.WriteLine(aralık[aralık.Length - 1]);

        // -- 2 -- Girilen metnin icerisinde kac adet "n" karakterinin gectigini hesaplayalım
        //Console.WriteLine("lutfen bir metin girin");
        //string metin = Console.ReadLine();
        //int adet = 0;
        //for (int i = 0; i < metin.Length; i++)
        //{
        //    if (metin[i] == 'n')
        //        adet++;
        //}

        // -- 3 -- Girilen metindeki kelime sayısını hesaplayalım
        //Console.WriteLine("lutfen bir metin girin");
        //string metin = Console.ReadLine();

        // cozum 1
        //string[] kelimeler = metin.Split(' ');
        //Console.WriteLine(kelimeler.Length);

        // cozum 2
        //int adet = 0;
        //while (true) // sonsuz dongude
        //{
        //    int index = metin.IndexOf(' '); // bosluk karakterını bulup index numarasını index adlı degiskene int olarak gonderecek
        //    if (index == -1) // IndexOf bosluk karakterini bulamazsa -1 degerini verecegi icin bu durumu kontrol edecek ve eger -1 ise donguyu kıracak olan sart blogu
        //        break;
        //    adet++; // bosluk buldugu halde adet satısını 1 arttıracak
        //    metin = metin.Substring(index+1); // ve buldugu bosluktan sonraki degerleri tekrar metin degiskenine atayarak tekrar aynı bosluk degerine denk gelmesini engelliyor
        //}// --bu sayede metin degiskeninin geri kalan kısmını da dongu boyunca tarayıp sonuca ulasmıs oluyoruz
        //Console.WriteLine(adet);

        #endregion

        #endregion

        #endregion
    }
}
