using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        public Decimal CalculatePrice(IEnumerable<PotterBook> products) 
        {
            Decimal summaryPrice = 0;
            foreach (var item in products)
            {
                summaryPrice += item.Price;
            }
            return summaryPrice;
        }
    }

    public class PotterBook 
    {
        public String Name { get; set; }

        public Decimal Price { get; set; }
 
    }
}
