using System.Collections;
namespace Hafta2ArrayList
{
    internal class Program
    {
      static void yazdir(ArrayList dizi,string islem)
        {
            
            Console.WriteLine("--------"+islem+"------------");
            foreach (object t in dizi)
            {
                Console.WriteLine("Eleman:" + t);
            }
            Console.WriteLine("Eleman sayısı:" + dizi.Count);
        }
        static void Main(string[] args)
        {
            //arraylist tanımla
            
            ArrayList liste=new ArrayList();
            //ADD fonk
            liste.Add(100);
            liste.Add("kocaeli");
            liste.Add(true);
            liste.Add(75.4);
            yazdir(liste,"Add");
            liste.Add("üniversitesi");
            liste.Add(120);
            yazdir(liste,"Add");
            //INSERT
            liste.Insert(2, "deneme");
            yazdir(liste,"Insert");
            //REMOVE ve REMOVEAT
            liste.Remove("kocaeli"); //ilk rastladığı değeri
            liste.RemoveAt(3);
            yazdir(liste,"Remove/RemoveAt");
            //REVERSE
            liste.Reverse();
            //liste.Reverse(2, 4); //2. indisten itibaren 4 elemanı ters çevirir 
            yazdir(liste,"Reverse");
            //SORT sıralayacak, farklı tipte sıralama patlıyor
            // liste.Sort();
            //liste.Sort(2, 4); //2. indisten itibaren 4 elemanı kısmi sıralama
            // yazdir(liste, "Sort");

            //CONTAINS : değerin listede olup olmadığı... true/false döner
            object aranan = 100;
            if(liste.Contains(aranan))
            {
                Console.WriteLine(aranan+" listede var");

            }
            else { Console.WriteLine(aranan + " listede yok!"); }

            //INDEXOF : aranan değerin varsa konumu
            int yer;
            yer = liste.IndexOf(aranan);
            if (yer<0)
            {
                Console.WriteLine(aranan + " listede yok!");
            }
            else
            {
                Console.WriteLine(aranan + " listede " + (yer+1) + ".sırada");
            }
            //CLEAR: listeyi temizler
            liste.Clear();
            yazdir(liste, "Clear");
        }
    }
}