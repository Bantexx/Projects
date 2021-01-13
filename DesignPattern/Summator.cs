using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class Summator
    {
        private const int DefValue = 5;
        public void ShowSum()
        {
            Console.WriteLine(DefValue * SumCollection());
        }
        protected abstract int SumCollection();

    }
}
