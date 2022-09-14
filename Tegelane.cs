using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_GG
{
    class Tegelane : Uksus, IComparable<Tegelane>
    {
        private string nimi;
        List<Ese> eseList = new List<Ese>();
        public Tegelane(string nimi)
        {
            this.nimi = nimi;

        }

        public string info()
        {
            double end = 0;
            Console.WriteLine($"\n______________________________\n{nimi} ");
            foreach (string line in System.IO.File.ReadLines(@"..\..\..\list.txt"))
            {
                string[] row = line.Split(";");
                end += Double.Parse(row[1]);
                Ese ese = new Ese(row[0], Int32.Parse(row[1]));
                eseList.Add(ese);
                Console.WriteLine(row[0]+" "+row[1]);
            }
            Console.WriteLine(eseList.Count());
            Console.WriteLine(end);
            Console.WriteLine("______________________________");
            return ($"{nimi}");
        }

        public int LisaEse(int punkt_arv)
        {
            return punkt_arv;
        }

        public int punktideArv()
        {
            int sum = 0;
            foreach (Ese item in eseList) { sum += item.punktideArv(); }
            return sum;
        }
        public void Equip(Ese item) 
        { 
            eseList.Add(item);
        }

        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.eseList.Count - other.eseList.Count();
        }
    }
}
