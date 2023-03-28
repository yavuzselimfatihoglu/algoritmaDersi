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
        void paraYatir(double yatirilan)
        {
            bakiye += yatirilan;
        }

        void paraCek(double cekilen)
        {
            //kişi hesabından fazla para çekemez!!
            //bakiye 10000
            //limit 20000
            //cekilen 55000
            //cekilen-bakiye
            //limit= limit- (cekilen-bakiye)
            //bakiye=0

            if (cekilen <= bakiye)
            {
                bakiye -= cekilen;
            }
            else if(cekilen<=bakiye+limit)
            {
                limit = limit - (cekilen - bakiye);
                bakiye = 0;
            }
            else
            {
                Console.WriteLine("Hesap yetersiz...");
                //limitArttir();
            }

        }
        static void Main(string[] args)
        {
            //nesne oluşturma
            //Kart k1 = new Kart();
            //Kart k2 = new Kart(5000);
            //Kart k3 = new Kart(1500, 2000);
            Kart k1=new Kart();
            k1.hesapAc("ali veli",1,10000,20000);
            k1.hesapYazdir();
            k1.paraYatir(5000);
            k1.hesapYazdir();
            k1.paraCek(50000);
            k1.hesapYazdir();

            //Kart k2 = new Kart(5000, 1000);
            //k2.hesapYazdir();


        }
    }
}