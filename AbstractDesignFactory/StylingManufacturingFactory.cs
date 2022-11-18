using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public abstract class StylingManufacturingFactory
    {
        public abstract IProduct GetProduct(string productType);
        public static StylingManufacturingFactory CreateStylingFactory(string factoryType)
        {
            if (factoryType.Equals("Men"))
                return new MenStylingFactory();
            else
                return new WomenStylingFactory();
        }
    }
}
