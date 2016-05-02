using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ourGroup = new List<string>()
            {
                "Андрей П.",
                "Константин",
                "Андрей Ж.",
                "Виталий",
                "Иван",
                "Илья"
            };

            Mix(ourGroup);
            Show(ourGroup);
            Console.ReadKey();

        }

        static void Mix(List<string> group)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int x = rand.Next(0, group.Count - 1);
                int y = rand.Next(0, group.Count - 1);
                string temp = group[x];
                group[x] = group[y];
                group[y] = temp; 
            }
        }

        static void Show(List<string> group)
        {
            foreach (string item in group)
                Console.WriteLine(item);
        }


    }
}
