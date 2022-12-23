using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ile_mini_atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kulanıcıya ne yaptırmak istediğini soracağız.
            //1-) Bakiye görüntüleme
            //2-) Para Çekme
            //3-) Para Yatırma
            //4-) q'ya basarsa çıkış yaptıracağız.
            int bakiye = 1000;
            Console.WriteLine("ATM'ye hoşgeldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1-)Bakiye Görüntüleme");
            Console.WriteLine("2-)Para Çekme");
            Console.WriteLine("3-)Para Yatırma");
            Console.WriteLine("4-)Çıkış yapmak.");
            string secım = Console.ReadLine();

            if (secım == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz" + bakiye);
                Console.ReadLine();
            }
            else if (secım == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
                int cekılecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekılecek_tutar < bakiye)
                {
                    Console.WriteLine("Yeni bakiyeniz:" + (bakiye - cekılecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden daha büyük bir tutar girdiniz!");
                    Console.ReadLine();
                }
            }
            if (secım == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz.");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz." + (bakiye + yatırılacak_tutar));
                Console.ReadLine();
            }
            else if (secım == "4")
            {
                Console.WriteLine("Çıkış yapmak istiyorsanız q tuşuna basınız.");
                Console.WriteLine("Çıkış yapıldı, İyi günler.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
                Console.ReadLine();
            }
        }
    }
}
