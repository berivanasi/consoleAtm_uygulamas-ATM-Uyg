using System;
using System.Threading;

namespace ConsoleAtmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 7000;

            Console.WriteLine("Bakiyeniz : " + bakiye);
        
            Console.WriteLine("1- Para Çekme");
            Console.WriteLine("2- Para Yatırma");
            Console.WriteLine("3- Bakiye sorgulama");
            Console.WriteLine("4- Kart İade");
            menu:
            Console.Write("\nİsleminizi Seciniz: ");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > bakiye)
                    {
                        Console.Write("Yetersiz bakiye. ");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye -= tutar;
                    Console.WriteLine("Yeni bakiyeniz = " + bakiye);
                    break;
                case 2:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += tutar;
                    Console.WriteLine("Yeni bakiyeniz = " + bakiye);
                    break;
                case 3:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    break;
                case 4:
                    Console.WriteLine("Kartınızı almayı unutmayınız!");
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim Yaptınız.Lütfen Tekrar Deneyiniz.");
                    break;
            }
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("AnaMenüye Geçiliyor Lütfen Bekleyiniz");
            Thread.Sleep(500);
            goto menu;

        }
    }
}
