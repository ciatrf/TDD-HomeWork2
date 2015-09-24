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
            return 0;
        }
    }

    public class PotterBook 
    {
        public String Name { get; set; }

        public Decimal Price { get; set; }
 
    }
}
