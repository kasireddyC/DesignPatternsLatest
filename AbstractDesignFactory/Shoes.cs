using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class Shoes:IProduct
    {
        public string GetProductDetails(string gender)
        {
            if (gender == "Male")
            {
                return "Men shoes.";
            }
            else if (gender == "Female")
            {
                return "Women shoes";
            }
            else
            {
                return "Shoes";
            }
        }
    }
}
