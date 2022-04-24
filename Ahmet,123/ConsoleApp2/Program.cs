using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi,sifre;
            Console.WriteLine("Kullanici Adını Giriniz:");
            kullaniciadi = Console.ReadLine();
            Console.WriteLine("Şifreyi Giriniz");
            sifre=Console.ReadLine();
            if (kullaniciadi == "Ahmet" && sifre == "123")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanici Adı veya Şifre Hatalı");
            }


            Console.ReadKey();
        }
    }
}
