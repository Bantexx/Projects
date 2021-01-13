using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    class House
    {
        public int Number { get; }
        public List<House> LinkedHouses { get; }

        public House(int number)
        {
            Number = number;
            LinkedHouses = new List<House>();
        }

        public void AddLinkedHouse(House house)
        {
            LinkedHouses.Add(house);
        }
        public override string ToString()
        {
            return $"Номер дома:{this.Number}";
        }
    }
}
