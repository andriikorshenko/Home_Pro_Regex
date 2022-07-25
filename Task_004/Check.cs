using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_004
{
    internal class Check
    {
        private Product[] _products;

        public Check(Product[] products)
        {
            _products = products;
        }

        public IEnumerable<Product> Show()
        {
            foreach (var item in _products)
            {
                yield return item;
            }
        }
    }
}
