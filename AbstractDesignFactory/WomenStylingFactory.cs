using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class WomenStylingFactory:StylingManufacturingFactory
    {
        public override IProduct GetProduct(string productType)
        {
            if (productType.Equals("Traditional"))
            {
                return new Traditional();
            }
            else if (productType.Equals("Westren"))
            {
                return new Westren();
            }
            else if (productType.Equals("Shoe"))
            {
                return new Shoes();
            }
            else
                return null;
        }
    }
}
