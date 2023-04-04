namespace Hafta6OperatorOverloadKalitimFarkliSiniflarErisim
{
    class Kompleks
    {
        double sanal;
        double gercek;
        public Kompleks()
        {
            Sanal = 0;
            Gercek = 0;
        }
        public Kompleks(double r, double s)
        {
            Sanal = s;
            Gercek = r;
        }
        public double Sanal
        {
            get { return sanal; }
            set { sanal = value; }
        }
        public double Gercek
        {
            get { return gercek; }
            set { gercek = value; }
        }

        // + operatörünü aşırı yükleyelim  k3=k1+k2
        public static Kompleks operator +(Kompleks a, Kompleks b)
        {
            //a ve b'nin sanalları ve gerçekleri ayrı ayrı toplanıp geri dönecek
            //Kompleks c= new Kompleks();
            //c.Sanal = a.Sanal + b.Sanal;
            //c.Gercek=a.Gercek + b.Gercek;
            //return c;

            return new Kompleks(a.Gercek + b.Gercek, a.Sanal + b.Sanal);
        }
        public static bool operator==(Kompleks a, Kompleks b)
            {
            if (a.Gercek == b.Gercek && a.Sanal == b.Sanal)
                return true;
            else
                return false;
            }
        public static bool operator !=(Kompleks a, Kompleks b)
        {
            if (a.Gercek != b.Gercek && a.Sanal != b.Sanal)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {   //  k1     k2
           // (a+bj) (c+dj)
           // k1    +    k2

          Kompleks k1= new Kompleks(4,5); // k1=4+5j 
          Kompleks k2= new Kompleks(6,8); // k2=6+8j
          Kompleks k3 = new Kompleks();  // k3=0+0j
          k3 = k2 + k1;
          Console.WriteLine("Sonuc=" +k3.Gercek+"+"+k3.Sanal+"j");
          
            if (k1 == k2)
                Console.WriteLine("k1 k2'ye eşit");
            else
                Console.WriteLine("k1 k2'ye eşit değil");

        }
    }
}