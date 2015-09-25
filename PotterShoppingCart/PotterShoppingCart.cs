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
            Decimal summaryPrice;
            var bookCount = products.Count();
            summaryPrice = products.Sum(x => x.Price);
            decimal disCount = 0.95m;
            if (bookCount == 2) 
            {
                summaryPrice = summaryPrice * disCount;
            }
            
            return summaryPrice;
        }
    }

    public class PotterBook 
    {
        public String Name { get; set; }

        public Decimal Price { get; set; }

        public int 集數 { get; set; }
 
    }
}
