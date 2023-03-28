namespace Hafta3SinifGiris
{
    class Kart
    {
        //üye değişkenler
        string musAdSoyad;
        double bakiye;
        double limit;
        int musNo;
        
        //kurucu ve yıkıcı metotlar
        //get/set anahtarların görevi
        public Kart()
        {
            limit = 1000;
            bakiye = 1000;
            
        }
        public Kart(double limit)
        {
            this.limit = limit;
            bakiye = 1000;
        }
        public Kart(double limit,double bakiye):this(limit)
        {
           this.bakiye = bakiye;
        }
         ~Kart()
        {
            Console.WriteLine("sınıf yok edildi...");
        }

        //üye metotlar
        //paraCek(miktar)
        //paraYatir(miktar)
        //hesapYazdir()
        //hesapAc()

        void hesapAc(string musAdSoyad,int musNo,double bakiye,double limit)
        {
            this.musAdSoyad = musAdSoyad;   
            this.musNo = musNo;
            this.limit = limit;
            this.bakiye=bakiye;
        }
        void hesapYazdir()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Müsteri Adı Soyadı:"+musAdSoyad);
            Console.WriteLine("Müsteri No:"+musNo);
            Console.WriteLine("Müsteri Bakiye:"+bakiye);
            Console.WriteLine("Müsteri Limit:"+limit);
            Console.WriteLine("****************************");
        }


        static void Main(string[] args)
        {
            //nesne oluşturma
            //Kart k1 = new Kart();
            //Kart k2 = new Kart(5000);
            //Kart k3 = new Kart(1500, 2000);
            Kart k1=new Kart();
            k1.hesapAc("ali veli",1,13000,20000);
            k1.hesapYazdir();
            Kart k2 = new Kart(5000, 1000);
            k2.hesapYazdir();


        }
    }
}