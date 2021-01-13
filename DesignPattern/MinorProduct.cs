using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class MinorProduct : Summator
    {
        private int MinPrice = 9;
        private int Coeff = 1;
        private List<int> priceProducts;

        public MinorProduct()
        {
            priceProducts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                priceProducts.Add(i);
            }
        }
        protected override int SumCollection()
        {
            return Convert.ToInt32(priceProducts.Sum() * MinPrice * Coeff) - (priceProducts.Sum() / priceProducts.Count);
        }
    }
}
