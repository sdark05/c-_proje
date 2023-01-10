using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize4
{
    internal class Program
    {



        static void Main(string[] args)
        {



            string kare, dikdortgen, daire = "";
            int secim;
            string secenek = "";
            int a = 0, b = 0, r = 0, π = 0;
            int cevre = 0, alan = 0;
            bool devam = true;
            while (devam)
            {

                Console.Write("Kare için: 1 \nDikdörtgen için: 2 \nDaire için: 3 \nÇıkış için:4");
                secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:

                        secenek = "";
                        Console.Write("Kare için uzunluk giriniz: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Alan için 1, Çevre 2, her ikisi için 3 giriniz:");
                        secenek = (Console.ReadLine());
                        if (secenek == "1") { alan = a * a; Console.WriteLine("Alanı: " + alan); }
                        else if (secenek == "2") { cevre = 4 * a; Console.WriteLine("Çevresi: " + cevre); }
                        else if (secenek == "3")
                        {
                            cevre = 4 * a;
                            alan = a * a;
                            string exit = ("4");
                            break;
                            Console.WriteLine("Alanı: " + alan);
                            Console.WriteLine("\nÇevresi: " + cevre);
                        }
                        else Console.Write("Yanlış Giriş");
                        if (secenek == "2" || secenek == "3")
                            Console.WriteLine("Çevresi:" + cevre);
                        break;

                    case 2:
                        secenek = "";
                        Console.Write("dikdortgen için kısa kenarı giriniz: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("dikdortgen için uzun kenarı giriniz: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("Alan için 1, Çevre 2, her ikisi için 3 giriniz:");
                        secenek = (Console.ReadLine());
                        if (secenek == "1")
                        {
                            alan = a * b;
                            Console.WriteLine("Alanı: " + alan);
                        }
                        else if (secenek == "2")
                        {
                            cevre = 2 * a + b;
                            Console.WriteLine("Çevresi: " + cevre);
                        }
                        else if (secenek == "3")
                        {
                            cevre = 2 * a + b;
                            alan = a * b;
                            string exit = ("4");
                            break;
                            Console.WriteLine("Alanı: " + alan);
                            Console.WriteLine("\nÇevresi: " + cevre);
                        }
                        else
                        {
                            Console.Write("Yanlış Giriş");
                        }
                        break;
                    case 3:
                        Console.Write("daire için yarı çap giriniz: ");
                        r = int.Parse(Console.ReadLine());
                        Console.Write("pi değerini gir: ");
                        π = int.Parse(Console.ReadLine());
                        if (secenek == "1") { alan = π * r * r; Console.WriteLine("Alanı: " + alan); }
                        else if (secenek == "2") { cevre = 2 * π * r; Console.WriteLine("Çevresi: " + cevre); }
                        else if (secenek == "3")
                        {
                            cevre = 2 * π * r;
                            alan = π * r * r;
                            string exit = ("4");
                            Console.WriteLine("Alanı: " + alan);
                            Console.WriteLine("\nÇevresi: " + cevre);

                        }
                        break;
                    case 4:
                    default:
                        devam = false;
                        break;
                }

                Console.ReadKey();
            }

        }
    }
}