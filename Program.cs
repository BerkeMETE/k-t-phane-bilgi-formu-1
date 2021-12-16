using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Kütüphane Bilgi Formu");
            Console.WriteLine("*************************************");
            
            
            Console.Write("Üye adı = ");
            string uyeadı;
            uyeadı = Console.ReadLine();

            Console.Write("Üye soyadı = ");
            string uyesoyadı;
            uyesoyadı = Console.ReadLine();

            Console.Write("Üye Doğum Tarihi = ");
            string uyedoumtarih;
            uyedoumtarih = Console.ReadLine();

            Console.Write("Toplam Bakiye = ");
            string toplambakiye;
            toplambakiye = Console.ReadLine();
           
            Console.WriteLine("Yenileme Ücreti = 90TL");


            Console.Write("Kalan Bakiye = ");
            int x = 120;
            int y = 90;
            int hesapla = (x - y);
            Console.Write(hesapla);    
            
            Console.ReadKey();







        }
    }
}
