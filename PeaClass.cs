using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_GG
{
    internal static class PeaClass
    {

            public static Random rng = new Random();
        public static List<Ese> loeEsemed() //return list with items
        {
            List<Ese> NewList = new List<Ese>();
            foreach (string line in System.IO.File.ReadLines(@"..\..\..\list.txt"))
            {
                string[] row = line.Split(";");
                Ese ese = new Ese(row[0], Int32.Parse(row[1]));
                NewList.Add(ese);
            }
            return (NewList);
        }
        static string RandomSym() //return random name from random sybmbols
        {
            string[] symbl = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "l", "k"};
            string name = "";
            while (name.Length != rng.Next(3, 12))
            {
                name += symbl[rng.Next(symbl.Length)];
            }
            return (name);
        }

        public static void Shuffle<T>(this IList<T> list) //Shuffle list
        {
            var shufflelist = list.OrderBy(a => rng.Next()).ToList();
            Console.WriteLine(string.Join("U+002CU+0020", shufflelist));
        }


        static Tegelane[] populatePlayers(int CountTeg)
        {
            if (CountTeg < 4) throw new Exception();
            Tegelane[] plrs = new Tegelane[CountTeg];
            for (int i = 0; i < CountTeg; i++)
            {
                Tegelane plr = new Tegelane(RandomSym());
                plrs[i] = plr;
            }

            return giveItems(plrs);
        }
        static Tegelane[] giveItems(Tegelane[] plrs)
        {
            List<Ese> itemList = loeEsemed();
            if (itemList.Count <= 0) throw new Exception();
            foreach (Tegelane plr in plrs)
            {
                int amount = rng.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    plr.Equip(itemList[i]);
                }
            }
            return plrs;
        }

    }
}
