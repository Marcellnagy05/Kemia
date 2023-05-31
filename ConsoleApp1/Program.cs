using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<kemia> elemek = new List<kemia>();
            using (StreamReader sr = new StreamReader("felfedezesek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    kemia elem = new kemia(line);
                    elemek.Add(elem);
                }
            }

            //3
            Console.WriteLine($"3. feladat: Elemek száma:{elemek.Count()}");
            //4
            Console.WriteLine($"4. feladat: Felfedezések az ókorban: {elemek.Where(x => x.Ev == "ókor").Count()}");
            //5

            string kivVegyjel = "";
            string[] betuk = { "A","B","C","D","E","F","G","H","I","K","L","M","N","O","P","Q","R","S","T","V","X","Y","Z" };


            do
            {
              Console.WriteLine("5. Feladat: Kérek egy vegyjelet:");
                kivVegyjel = Console.ReadLine();
            } while (kivVegyjel.Length > 2 && !betuk.Contains(kivVegyjel));

            //6

            //elemek.Where(x => x.Vegyjel == kivVegyjel.ToLower()).OrderBy(x => x.Vegyjel).ToList().ForEach(x => Console.WriteLine($"{}"));

            //7


        }
    }
}
