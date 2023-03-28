namespace Hafta3asiriYuklenmisFonk
{
    internal class Program
    {
       static void fonk()
        {
            Console.WriteLine("boş fonksiyon");
        }
        static int fonk(int x)
        {
          return  x* x*3;
        }
        static double fonk(float x)
        {
            return Math.Pow(x, 4);
        }
        static int fonk(int x,int y)
        {
            return x * y;
        }

        static void yeniFonk(params object[] d)
        {
            Console.WriteLine("------------------");
            foreach (object t in d)
            {
                Console.WriteLine("Parametre:" + t);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sonuc:" + fonk(3));
            Console.WriteLine("Sonuc:" + fonk(4.8f));
            Console.WriteLine("Sonuc:" + fonk(3, 4));
            fonk();
            yeniFonk(100);
            yeniFonk("kocaeli");
            yeniFonk(100, "kocaeli", true);
            
        }
    }
}