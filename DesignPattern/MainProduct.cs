using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class MainProduct : Summator
    {
        private int MainPrice = 17;
        private double Coeff = 1.4;
        private List<int> priceProducts;

        public MainProduct()
        {
            priceProducts = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                priceProducts.Add(i);
            }
        }

        protected override int SumCollection()
        {
            return Convert.ToInt32(priceProducts.Sum() * MainPrice * Coeff);
        }
    }
}
