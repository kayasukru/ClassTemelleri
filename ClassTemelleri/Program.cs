internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Class temelleri: Yapıcı metodlu, List<> tanımlı, override yapısı ile çıktı biçimlendirme, Liste çıktısını .ForEach ve LAMBDA ile verme");

        OgretimElemani ogrEl1 = new OgretimElemani();
        ogrEl1.SicilNo = 11;
        ogrEl1.Adi = "Şükrü";
        ogrEl1.Soyadi = "Kaya";
        ogrEl1.Cinsiyet = true;
        Console.WriteLine(ogrEl1);
        Console.WriteLine();

        OgretimElemani ogrEl2 = new OgretimElemani()
        {
            SicilNo = 22,
            Adi = "Yusuf",
            Soyadi = "kolaçan",
            Cinsiyet = true
        };
        Console.WriteLine(ogrEl2);
        Console.WriteLine();

        OgretimElemani ogEl3 = new OgretimElemani(33, "Yeşim", "Kurt", false);
        Console.WriteLine(ogEl3);
        Console.WriteLine();

        var ogrElemaniListesi = new List<OgretimElemani>()
        {
            new OgretimElemani(44,"Şüheda", "Vatan", false),
            new OgretimElemani(55, "Selim", "Güner", true),
            new OgretimElemani(66, "Yavuz", "Sağ", true),
            new OgretimElemani(77, "Tuğba", "Kara", false)
        };
        Console.WriteLine("List<> yapısı ile foreach() çıktısı");
        foreach (var ogEl in ogrElemaniListesi)
        {
            Console.WriteLine(ogEl);
        }
        Console.WriteLine();
        
        Console.WriteLine("List<> yapısı ile .ForEach() çıktısı");
        ogrElemaniListesi.ForEach(oe => Console.WriteLine(oe));
        Console.WriteLine();

        Console.WriteLine("Eleman Ekleme");
        ogrElemaniListesi.Add(new OgretimElemani(88,"Yonca", "Yaprak", false));
        ogrElemaniListesi.ForEach (oe => Console.WriteLine(oe));
        Console.WriteLine();

        Console.WriteLine("Eleman Silme");
        ogrElemaniListesi.RemoveAt(0);
        ogrElemaniListesi.ForEach(oe=> Console.WriteLine(oe));
        Console.WriteLine();
    }
}

public class OgretimElemani
{
    //Varsayılan Yapıcı metod
    public OgretimElemani()
    {
        Console.WriteLine("OgretimElemani() Yapıcı metodu çalıştı");
    }

    public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet = true)
    {
        SicilNo = sicilNo;
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyet = cinsiyet;
    }

    public int SicilNo { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool Cinsiyet { get; set; }

    public override string ToString()
    {
        return $"{SicilNo,-5} {Adi,-10} {Soyadi,-10} " + string.Format("{0, -8}", Cinsiyet == true ? "Erkek" : "Kadın");
    }

}