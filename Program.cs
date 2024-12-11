namespace Abstract_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru
            //Örnek: Bir tane Tasit sınıfı oluşturalım ancak bu sınıftan nesne üretilemesin. İçerisinde Marka, Model, TabanFiyat property'leri  bir de türeyen her sınıfa özel hesaplanacak Fiyat property'si ekleyelim.
            //Tasit'dan türeyen Araba, Ucak, Tren ve Gemi class'larımız olsun.
            //Araba'ya özel fiyat hesabı YakitTuru, VitesTuru bilgilerine göre yapılsın (Dizel'se +5000, Otomatikse'se +10000)
            //Uçak'a özel fiyat hesabı kapasite bilgisine göre yapılsın. (Kapasite başına +100)
            //Trene özel fiyat hesabı vagon sayısı ve sınıf bilgisine göre yapılsın (sınıf A ise + 50000, B ise +10000 vagon sayısı başına + 30000)
            //Gemi'ye özel fiyat hesabı kamara sayısına göre yapılsın (kamara başına +40000)
            /*
                public override double Fiyat
                {
                    get{
                            if(YakitTuru=="Dizel")
                                TabanFiyat+=5000;
                            if(VitesTuru=="Otomatik")
                                TabanFiyat+=10000;

                        }
            return tabanfiyat;
                }
            */
            #endregion
            Araba araba = new Araba
            {
                Marka = "BMW",
                Model = "İ7",
                YakitTuru = "Benzin",
                VitesTuru = "Otomatik",
                TabanFiyat = 100,
            };
            Console.WriteLine($"Marka: {araba.Marka} Model: {araba.Model} Yakıt Türü: {araba.YakitTuru} Vites Türü: {araba.VitesTuru} Fiyat: {araba.Fiyat}");
            Ucak ucak = new Ucak
            {
                Marka = "Boeing",
                Model = "777",
                TabanFiyat = 100,
                Kapasite = 10
            };
            Console.WriteLine($"Marka: {ucak.Marka} Model: {ucak.Model} Kapasite: {ucak.Kapasite} Fiyat: {ucak.Fiyat}");
            Tren tren = new Tren
            {
                Marka = "CAF",
                Model = "HT 65000",
                TabanFiyat = 100,
                VagonSayısı = 10,
                Sınıf = "A",
            };
            Console.WriteLine($"Marka: {tren.Marka} Model: {tren.Model} Vagon Sayısı: {tren.VagonSayısı} Sınıf: {tren.Sınıf} Fiyat: {tren.Fiyat}");
            Gemi gemi = new Gemi
            {
                Marka = "Handysize",
                Model = "Handysize",
                TabanFiyat = 100,
                Kamara = 10,
            };
            Console.WriteLine($"Marka: {gemi.Marka} Model: {gemi.Model} Kamara: {gemi.Kamara} Sınıf: Fiyat: {gemi.Fiyat}");
            Console.ReadKey();
        }
    }
    abstract class Tasit 
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double TabanFiyat { get; set; }
        public abstract double Fiyat { get; }
    }
    class Araba : Tasit
    {
        public string YakitTuru { get; set; }
        public string VitesTuru { get; set; }

        public override double Fiyat
        {
            get 
            { 
                if (YakitTuru == "Dizel")
                {
                    TabanFiyat += 5000;
                }
                
                if (VitesTuru == "Otomatik")
                {
                    TabanFiyat += 10000;
                }
                return TabanFiyat;
            }
        }
    }
    class Ucak : Tasit
    {
        public int Kapasite {  get; set; }
        public override double Fiyat
        {
            get 
            {
                return TabanFiyat + (Kapasite * 100);
            }
        }
    }
    class Tren : Tasit
    {
        public int VagonSayısı { get; set; }
        public string Sınıf { get; set; }
        public override double Fiyat
        {
            get
            {
                if (Sınıf == "A")
                {
                    TabanFiyat += 50000;
                }
                if (Sınıf == "B")
                {
                    TabanFiyat += 10000;
                }
                TabanFiyat = VagonSayısı * 30000;
                return TabanFiyat;
            }
        }
    }
    class Gemi : Tasit
    {
        public int Kamara {  get; set; }
        public override double Fiyat
        {
            get
            {
                return TabanFiyat + (Kamara * 50000);
            }
            
        }
    }
}
