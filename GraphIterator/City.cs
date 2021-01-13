using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{
    class City
    {
        public string Name { get; }
        public List<House> Houses { get; }
        public House goal;
        private HashSet<House> visited;
        private LinkedList<House> path;

        public City(string name)
        {
            Name = name;
            Houses = new List<House>();
        }
        public void AddHouseInCity(House house)
        {
            Houses.Add(house);
        }       
        public LinkedList<House> DFS(House start, House goal)
        {
            visited = new HashSet<House>();
            path = new LinkedList<House>();
            this.goal = goal;

            DFS(start);
            if (path.Count > 0)
            {
                path.AddFirst(start);
            }
            return path;
        }
        private bool DFS(House node)
        {
            if (node == goal)
            {
                return true;
            }
            visited.Add(node);
            foreach (var child in node.LinkedHouses.Where(x => !visited.Contains(x)))
            {
                if (DFS(child))
                {
                    path.AddFirst(child);
                    return true;
                }
            }
            return false;
        }
    }
    
}
