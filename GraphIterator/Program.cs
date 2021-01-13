using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            House home1 = new House(1);
            House home2 = new House(2);
            House home3 = new House(3);

            home1.AddLinkedHouse(home2);
            home1.AddLinkedHouse(home3);
            home2.AddLinkedHouse(home3);

            City city1 = new City("Moscow");
            city1.AddHouseInCity(home1);
            city1.AddHouseInCity(home2);
            city1.AddHouseInCity(home3);

            var firstPath = city1.DFS(home1, home3);
            PrintPath(firstPath);


        }
        private static void PrintPath(LinkedList<House> path)
        {
            Console.WriteLine();
            if (path.Count == 0)
            {
                Console.WriteLine("Нет пути");
            }
            else
            {
                Console.WriteLine(string.Join(" -> ", path.Select(x => x.Number)));
            }
            Console.Read();
        }
    }
}
