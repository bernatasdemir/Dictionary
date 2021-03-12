using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> flowers = new MyDictionary<int, string>();
            flowers.Add(1, "Gül");
            flowers.Add(2, "Zambak");
            flowers.Add(3, "Kiraz Çiçeği");
            flowers.Add(4, "Şakayık");
            flowers.Add(5, "Lavanta");
            flowers.Add(6, "Orkide");
            flowers.Add(7, "Manolya");
            flowers.Add(8, "Zambak");
            flowers.Add(9, "Yasemin");
            flowers.Add(10, "Sümbül");

            foreach (var flower in flowers.values)
            {
                Console.WriteLine(flower);
            }
        }
    }
}
