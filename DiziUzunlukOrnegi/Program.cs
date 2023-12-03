using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziUzunlukOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elemanlar = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}, eleman girişi yapın ");
                elemanlar[i] = Console.ReadLine();
            }
            string uzuneleman = "";
            int enuzuneleman = -1;

            for (int i = 0; i < 5; i++)
            {
                if (elemanlar[i].Length > uzuneleman.Length)
                {
                    uzuneleman = elemanlar[i];
                    enuzuneleman = i;
                }
            }
            Console.WriteLine($"Çıktı = En uzun eleman = {uzuneleman}");
            Console.WriteLine($"Çıktı = En uzun elemanın uzunluğu = {uzuneleman.Length}");
            Console.WriteLine($"Çıktı = En uzun elemanın indexi = {enuzuneleman}");

            Console.ReadLine();
        }
    }
}
