using System;
using System.Collections.Generic;
using System.Linq;
namespace Agregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int testy = int.Parse(Console.ReadLine());

            SortedDictionary<string, int> ImieCzas = new SortedDictionary<string, int>();
            SortedDictionary<string, List<string>> ImieIp = new SortedDictionary<string, List<string>>();

            for (int i = 0; i < testy; i++)
            {
                string logi = Console.ReadLine();
                string[] dane = logi.Split(" ");

                if (ImieIp.ContainsKey(dane[1]) == false)
                {
                    ImieIp.Add(dane[1], new List<string> { dane[0] });
                }

                else
                {
                    ImieIp[dane[1]].Add(dane[0]);
                }

                int minuty = int.Parse(dane[2]);

                if (ImieCzas.ContainsKey(dane[1]))
                {
                    ImieCzas[dane[1]] += minuty;
                }
                else
                {
                    ImieCzas.Add(dane[1], minuty);
                }

            }

            foreach (KeyValuePair<string, List<string>> element2 in ImieIp)
            {
                element2.Value.Sort();
                List<string> lista = element2.Value.Distinct().ToList();
                Console.WriteLine("{0}" + ":" + " " + "{1}" + " " + "[" + "{2}" + "]", element2.Key, ImieCzas[element2.Key], string.Join(", ", lista));
            }

        }
    }
}
