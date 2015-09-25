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
            switch (bookCount)
            {
                case 2:
                    summaryPrice = summaryPrice * 0.95m;
                    break;
                case 3:
                    summaryPrice = summaryPrice * 0.9m;
                    break;
                case 4:
                    summaryPrice = summaryPrice * 0.8m;
                    break;
                case 5:
                    summaryPrice = summaryPrice * 0.75m;
                    break;
                case 1:
                default:
                    break;
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
