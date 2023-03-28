namespace Hafta5SetGetStaticKopytaKurucuConstReadOnly
{
    class Zaman
    {
        int saat;
        int dakika;
        int saniye;

        //kurucular
        public Zaman()
        {
            saat = 12;
            dakika = 0;
            saniye = 0;
        }
        public Zaman(int saat,int dakika,int saniye)
        {
            Saat = saat;   
            Dakika = dakika;
            Saniye = saniye;       
        }
        //copy constructor - kopya kurucu
        public Zaman(Zaman z)
        {
            saat = z.saat;
            saniye= z.saniye; 
            dakika= z.dakika;   
         }
        void zamanYazdir()
        {
            Console.WriteLine(Saat + ":" + Dakika + ":" + Saniye);

        }

        //get/set anahtar/prop/arayüz
        public int Saat
        {
            get
            {
                return saat;
            }
            set
            {
                saat =value;
            }
        }
        public int Dakika
        {
            get
            {
                return dakika;
            }
            set
            {
                dakika = value;
            }
        }
        public int Saniye
        {
            get
            {
                return saniye;
            }
            set
            {
                saniye = value;
            }
        }

        static void Main(string[] args)
        {
            
            Zaman z1=new Zaman(); 
            z1.zamanYazdir();
            Zaman z2 = new Zaman(14,15,0);
            z2.zamanYazdir();
            Zaman z3 = new Zaman(z2);
            z3.zamanYazdir();


        }
    }
    
}